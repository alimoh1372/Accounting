using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accounting.DataLayer.Context;
using Accounting.DataLayer;
using System.IO;

namespace Accounting.App
{
    public partial class frmCustomers : Form
    {
        public frmCustomers()
        {
            InitializeComponent();
        }
        private void frmCustomers_Load(object sender, EventArgs e)
        {
            BindGrid();
        }
        private void btnRefreshCustomers_Click(object sender, EventArgs e)
        {
            txtFilter.Text = "";
            BindGrid();
        }

        private void BindGrid()
        {
            using (UnitOfWorkPattern db = new UnitOfWorkPattern())
            {
                dgvCustomers.AutoGenerateColumns = false;
                dgvCustomers.DataSource = db.customRepository.GetAllCustomers();
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWorkPattern db=new UnitOfWorkPattern())
            {
                dgvCustomers.DataSource = db.customRepository.GetCustomerByFilter(txtFilter.Text);
            }
            
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            using (UnitOfWorkPattern db=new UnitOfWorkPattern())
            {
                if (dgvCustomers.CurrentRow!=null)
                {
                    if (RtlMessageBox.Show($"آیا از حذف {dgvCustomers.CurrentRow.Cells["FullName"].Value} مطمئن ههستید؟","عملیات حذف",MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==DialogResult.Yes)
                    {
                        int customerID = Convert.ToInt32(dgvCustomers.CurrentRow.Cells[0].Value);
                        Customers customer = db.customRepository.GetCustomerById(customerID);
                        db.customRepository.DeleteCustomer(customerID);
                        int result= db.Save();
                        if (result>0)
                        {
                            string imagepath = Application.StartupPath + "/Images/" + customer.CustomerImage;
                            if (File.Exists(imagepath))
                            {
                                System.IO.File.Delete(Application.StartupPath + "/Images/" + customer.CustomerImage);
                            }
                            BindGrid();
                        }
                        else
                        {
                            RtlMessageBox.Show("با عرض پوزش حذف انجام نشد.لطفا مجددا سعی نمائید.یا با ادمین خود تماس بگیرید.با تشکر...", "مشکل در دیتابیس", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    RtlMessageBox.Show("لطفا یک نفر را از لیست زیر انتخاب و سپس دکمه حذف را بزنید.", "عدم انتخاب یک نفر", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            frmAddOrEditCustomer frmAddCustomer = new frmAddOrEditCustomer();
            if (frmAddCustomer.ShowDialog()==DialogResult.OK)
            {
                BindGrid();
                frmAddCustomer.Close();
            }
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.CurrentRow!=null)
            {
                frmAddOrEditCustomer frmEditCustomer = new frmAddOrEditCustomer();
                frmEditCustomer.customerId = Convert.ToInt32(dgvCustomers.CurrentRow.Cells["CustomerID"].Value);
                if (frmEditCustomer.ShowDialog()==DialogResult.OK)
                {
                    BindGrid();
                }
            }
        }
    }
}
