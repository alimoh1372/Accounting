using Accounting.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            frmCustomers frmcustomer = new frmCustomers();
            frmcustomer.ShowDialog();
        }

        private void btnNewAccountig_Click(object sender, EventArgs e)
        {
            frmNewAccountig frmNewAccounting = new frmNewAccountig();
            frmNewAccounting.ShowDialog();
        }

        private void btnRecieveReport_Click(object sender, EventArgs e)
        {

            frmRecivePayReport frmReport = new frmRecivePayReport();
            frmReport.TypeId = 1;
            frmReport.ShowDialog();
        }

        private void btnPayReport_Click(object sender, EventArgs e)
        {
            frmRecivePayReport frmReport = new frmRecivePayReport();
            frmReport.TypeId = 2;
            frmReport.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Hide();
            
            
            FrmLogin frmLogin = new FrmLogin();
            if (frmLogin.ShowDialog()==DialogResult.OK)
            {
                lblDate.Text = DateTime.Now.ToShamsiDate();
                lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
                timer1.Start();
                 
            }
            else
            {
                Application.Exit();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.iSEdit = true;
            frmLogin.ShowDialog();
            
        }
    }
}
