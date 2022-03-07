using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accountig.DataLayer.Context;
using Accountig.DataLayer;
using Accounting.Utility;

namespace Accounting.App
{
    public partial class frmRecivePayReport : Form
    {
        public int TypeId = 0;
        public frmRecivePayReport()
        {
            InitializeComponent();
        }

        private void frmRecivePayReport_Load(object sender, EventArgs e)
        {
            if (TypeId == 1)
            {
                this.Text = "گزارش دریافتی ها(درآمد)";
                Filter();
            }
            else
            {
                this.Text = "گزارش پرداختی ها";
                Filter();
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            Filter();
        }
        private void Filter()
        {
            using (UnitOfWorkPattern db = new UnitOfWorkPattern())
            {
                var result = db.AccountigRepository.Get(a => a.TypeID == TypeId);
                // dgvAccountingReport.AutoGenerateColumns = false;
                //dgvAccountingReport.DataSource = result;
                dgvAccountingReport.Rows.Clear();
                foreach (Accountig.DataLayer.Accounting accountigItem in result)
                {
                    string customerName = db.customRepository.GetCustomerNameById(accountigItem.CostomerID);
                    dgvAccountingReport.Rows.Add(accountigItem.ID.ToString(), customerName, accountigItem.Amount.ToString("#,0"), accountigItem.Description, accountigItem.DateTitle.ToShamsiDate());
                }
            }

        }

        private void btnDeleteAccountig_Click(object sender, EventArgs e)
        {
            if (dgvAccountingReport.CurrentRow != null)
            {
                using (UnitOfWorkPattern db = new UnitOfWorkPattern())
                {

                    int accountigId = Convert.ToInt32(dgvAccountingReport.CurrentRow.Cells["ID"].Value);
                    db.AccountigRepository.Delete(accountigId);
                    int result = db.Save();
                    if (result>0)
                    {
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        RtlMessageBox.Show("خطا در هنگام حذف از دیتابیش", "عدم حذف", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
