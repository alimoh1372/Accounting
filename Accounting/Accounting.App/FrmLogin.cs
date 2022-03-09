using Accounting.DataLayer;
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

namespace Accounting.App
{
    public partial class FrmLogin : Form
    {
        public bool iSEdit = false;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                using (UnitOfWorkPattern db = new UnitOfWorkPattern())
                {
                    if (iSEdit)
                    {
                        Login lgin = new Login();
                        lgin = db.LoginRepository.Get().First();
                        lgin.UserName = txtUserName.Text;
                        lgin.Password = txtPassword.Text;
                        db.LoginRepository.Update(lgin);
                        int result = db.Save();
                        if (result > 0)
                        {
                            RtlMessageBox.Show("نام کاربری و رمز عبور با موفقیت تغییر یافت.");
                            DialogResult = DialogResult.OK;
                            Application.Restart();
                        }
                        else
                        {
                            RtlMessageBox.Show("خطا در هنگام ثبت تغییرات");
                        }
                    }
                    else
                    {
                        string pass = txtPassword.Text;
                        string user = txtUserName.Text;
                        if (db.LoginRepository.Get(l => l.UserName == txtUserName.Text && l.Password == txtPassword.Text).Any())
                        {
                            DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            RtlMessageBox.Show("نام کاربری یافت نشد.");
                            this.txtUserName.Focus();
                        }
                    }
                }
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            if (iSEdit)
            {
                this.Text = "تغییر نام کاربری یا رمز عبور";
                this.btnLogin.Text = "ثبت تغییرات";
                using (UnitOfWorkPattern db = new UnitOfWorkPattern())
                {
                    var login = db.LoginRepository.Get().First();
                    txtUserName.Text = login.UserName;
                    txtPassword.Text = login.Password;
                }
            }
        }
    }
}
