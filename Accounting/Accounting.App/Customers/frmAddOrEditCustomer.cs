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
using Accountig.DataLayer;
using Accountig.DataLayer.Context;
using Accountig.DataLayer.Services;
using System.IO;

namespace Accounting.App
{
    public partial class frmAddOrEditCustomer : Form
    {
        UnitOfWorkPattern db = new UnitOfWorkPattern();
        public int customerId;
        public frmAddOrEditCustomer()
        {
            InitializeComponent();
            customerId = 0;
        }


        private void btnPictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pcCustomer.ImageLocation = openFile.FileName;
            }
        }

        private void btnSubmitCustomer_Click(object sender, EventArgs e)
        {

            if (BaseValidator.IsFormValid(this.components))
            {
                Customers oldCustomer = db.customRepository.GetCustomerById(customerId);
                string imgOldName = oldCustomer.CustomerImage;
                string imageName = Guid.NewGuid().ToString() + Path.GetExtension(pcCustomer.ImageLocation);
                string savePath = Application.StartupPath + "/Images/";
                Customers customer = new Customers()
                {
                    FullName = txtName.Text,
                    Address = txtAddress.Text,
                    Email = txtEmeil.Text,
                    Mobile = txtMobile.Text,
                    CustomerImage = imageName
                };
                if (customerId == 0)
                {
                    db.customRepository.InsertCustomer(customer);
                }
                else
                {
                    customer.CustomerID = customerId;
                    db.customRepository.UpdateCustomer(customer);
                }
                int result = db.Save();
                if (result > 0)
                {

                    if (!Directory.Exists(savePath))
                    {
                        Directory.CreateDirectory(savePath);
                    }
                }
                pcCustomer.Image.Save(savePath + imageName);
                DialogResult = DialogResult.OK;
            }
            else
            {
                RtlMessageBox.Show("در هنگام ثبت در بانک اطلاعاتی مشکلی به وجود آمده لطفا مجددا سعی کنید یا با ادمین خود تماس بگیرید.با تشکر...", "خطا در ثبت ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        private void frmAddOrEditCustomer_Load(object sender, EventArgs e)
        {
            if (customerId != 0)
            {
                this.Text = "ویرایش اطلاعات و تصویر شخص";
                this.btnSubmitCustomer.Text = "ثبت ویرایش";
                Customers customer = db.customRepository.GetCustomerById(customerId);
                txtAddress.Text = customer.Address;
                txtName.Text = customer.FullName;
                txtMobile.Text = customer.Mobile;
                txtEmeil.Text = customer.Email;
                string imageLocation = Application.StartupPath + "/Images/" + customer.CustomerImage;
                if (!File.Exists(imageLocation))
                {
                    pcCustomer.Image = Properties.Resources.no_profile_image;
                }
                else
                {
                    pcCustomer.ImageLocation = imageLocation;
                }

            }
        }
    }
}
