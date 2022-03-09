using Accounting.DataLayer.Context;
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
        UnitOfWorkPattern db ;
        public int accountigId = 0;
        public frmNewAccountig()
        {
            InitializeComponent();
        }

        private void frmNewAccountig_Load(object sender, EventArgs e)
        {
            db = new UnitOfWorkPattern();
            BindGridSelect();
            if (accountigId==0)
            {
                this.Text = "تراکنش جدید";
                this.btnSaveTransaction.Text = "ثبت تراکنش";
            }
            else
            {
                this.Text = "ویرایش تراکنش";
                this.btnSaveTransaction.Text = "ثبت ویرایش";
                DataLayer.Accounting accounting1 = new DataLayer.Accounting();
                accounting1 = db.AccountigRepository.GetById(accountigId);
                txtAmount.Text = accounting1.Amount.ToString();
                txtCustomerName.Text = db.customRepository.GetCustomerNameById(accounting1.CostomerID);
                txtDescrepcion.Text = accounting1.Description;
                if (accounting1.TypeID==1)
                {
                    rdRecieve.Checked = true;
                }
                else
                {
                    rdPay.Checked = true;
                }
                dgvSelectCustomers.ClearSelection();
                foreach (DataGridViewRow row in dgvSelectCustomers.Rows)
                {
                    if (row.Cells["FullName"].Value.ToString() == txtCustomerName.Text)
                    {
                        row.Selected = true;
                        break;
                    }
                }

            }
            db.Dispose();
            

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
            db = new UnitOfWorkPattern();
            
            if (BaseValidator.IsFormValid(this.components))
            {
                if (rdPay.Checked || rdRecieve.Checked)
                {
                   DataLayer.Accounting accounting = new DataLayer.Accounting()
                    {
                        TypeID = (rdRecieve.Checked) ? 1 : 2,
                        Amount = Convert.ToInt32(txtAmount.Text.DeleteSomecharFromString(',')),
                        CostomerID = db.customRepository.GetCustomerIdByName(txtCustomerName.Text),
                        DateTitle = DateTime.Now,
                        Description=txtDescrepcion.Text
                    };
                    int result;
                    string title = "";
                    if (accountigId==0)
                    {
                        db.AccountigRepository.Insert(accounting);
                        result = db.Save();
                        title = "خطا هنگام ثبت";
                        
                    }
                    else
                    {
                        accounting.ID = accountigId;
                        db.AccountigRepository.Update(accounting);
                        result=db.Save();
                        title = "خطا هنگام ویرایش";
                    }
                    
                    if (result>0)
                    {
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {

                        RtlMessageBox.Show("در هنگام انجام عملیات  مشکلی بوجود آمده است لطفا بعدا مجددا انجام، یا با ادمین تماس حاصل فرمائید..باتشکر ", title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    RtlMessageBox.Show("لطفا یکی از نوع تراکنش ها را انتخاب نمائید ", "انتخاب تراکنش", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            db.Dispose();
        }
    }
}
