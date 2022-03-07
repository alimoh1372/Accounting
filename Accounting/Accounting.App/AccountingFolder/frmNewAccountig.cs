using Accountig.DataLayer.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValidationComponents;
using Accounting.Utility;




namespace Accounting.App
{
    public partial class frmNewAccountig : Form
    {
        UnitOfWorkPattern db = new UnitOfWorkPattern();

        public frmNewAccountig()
        {
            InitializeComponent();
        }

        private void frmNewAccountig_Load(object sender, EventArgs e)
        {
            BindGridSelect();

        }

        private void BindGridSelect()
        {
            dgvSelectCustomers.AutoGenerateColumns = false;
            dgvSelectCustomers.DataSource = db.customRepository.GetSelectCustomer(txtFilter.Text);
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            BindGridSelect();
        }

        private void dgvSelectCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCustomerName.Text = dgvSelectCustomers.CurrentRow.Cells["FullName"].Value.ToString();
        }

        private void btnSaveTransaction_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                if (rdPay.Checked || rdRecieve.Checked)
                {
                    Accountig.DataLayer.Accounting accounting = new Accountig.DataLayer.Accounting()
                    {
                        TypeID = (rdRecieve.Checked) ? 1 : 2,
                        Amount = Convert.ToInt32(txtAmount.Text.DeleteSomecharFromString(',')),
                        CostomerID = db.customRepository.GetCustomerIdByName(txtCustomerName.Text),
                        DateTitle = DateTime.Now,
                        Description=txtDescrepcion.Text
                    };

                    db.AccountigRepository.Insert(accounting);
                    int result= db.Save();
                    if (result>0)
                    {
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {

                        RtlMessageBox.Show("در هنگام ثبت تراکنش مشکلی بوجود آمده است لطفا بعدا انتخاب نمائید.یا با ادمین تماس حاصل فرمائید..باتشکر ", "خطا هنگام ثبت", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    RtlMessageBox.Show("لطفا یکی از نوع تراکنش ها را انتخاب نمائید ", "انتخاب تراکنش", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
