using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accounting.DataLayer;
using Accounting.Utility;
using Accounting.DataLayer.Context;
using Accounting.ViewModels;

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
            using (UnitOfWorkPattern db = new UnitOfWorkPattern())
            {
                List<customerSelectViewModel> listCustomerName = new List<customerSelectViewModel>();
                listCustomerName.Add(new customerSelectViewModel()
                {
                    CustomerId = 0,
                    FullName = "لطفا انتخاب نمائید"
                }
                    );
                listCustomerName.AddRange(db.customRepository.GetSelectCustomer());
                cbCustomer.DataSource = listCustomerName;
                cbCustomer.DisplayMember = "FullName";
                cbCustomer.ValueMember = "CustomerId";
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
                if (Convert.ToInt32(cbCustomer.SelectedValue) != 0)
                {
                    result = result.Where(r => r.CostomerID == Convert.ToInt32(cbCustomer.SelectedValue));
                }
                if (txtFromDate.Text != "    /  /")
                {
                    DateTime dt = txtFromDate.Text.ToMiladi();
                    result = result.Where(r => r.DateTitle >= dt);
                }
                if (txtToDate.Text != "    /  /")
                {
                    DateTime dt = txtToDate.Text.ToMiladi();
                    result = result.Where(r => r.DateTitle <= dt);
                }


                // dgvAccountingReport.AutoGenerateColumns = false;
                //dgvAccountingReport.DataSource = result;

                dgvAccountingReport.Rows.Clear();
                foreach (DataLayer.Accounting accountigItem in result)
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
                    if (result > 0)
                    {
                        DialogResult = DialogResult.OK;
                    }

                }
            }
        }

        private void btnEditAccountig_Click(object sender, EventArgs e)
        {
            if (dgvAccountingReport.CurrentRow != null)
            {
                frmNewAccountig frmedit = new frmNewAccountig();
                frmedit.accountigId = Convert.ToInt32(dgvAccountingReport.CurrentRow.Cells["ID"].Value);

                if (frmedit.ShowDialog() == DialogResult.OK)
                {
                    Filter();
                }
                else
                {
                    RtlMessageBox.Show("خطا در هنگام ثبت ویرایش لطفا بعدا مجددا انجام، یا با ادمین خود تماس حاصل فرمایئد.با تشکر", "عدم ثبت ویرایش");
                }
            }
            else
            {
                RtlMessageBox.Show("لطفا یک تراکنش را از لیست برای ویرایش انتخاب نمائید.با تشکر", "عدم انتخاب تراکنش");
            }

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DataTable dtPtint = new DataTable();
            dtPtint.Columns.Add("Customer");
            dtPtint.Columns.Add("Amount");
            dtPtint.Columns.Add("Date");
            dtPtint.Columns.Add("Description");
            foreach (DataGridViewRow item in dgvAccountingReport.Rows)
            {
                dtPtint.Rows.Add(
                    item.Cells[1].Value.ToString(),
                    item.Cells[2].Value.ToString(),
                    item.Cells[4].Value.ToString(),
                    item.Cells[3].Value.ToString()
                    );
            }
            stiPrint.Load(Application.StartupPath + "/Report.mrt");
            stiPrint.RegData("DT", dtPtint); 
            stiPrint.Show();
        }
    }
}
