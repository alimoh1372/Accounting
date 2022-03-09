using Accounting.Business;
using Accounting.Utility;
using Accounting.ViewModels;
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
                var list = Enumerable.Range(1, 31).Cast<object>().ToArray();
                cbDayReport.Items.AddRange(list);
                cbDayReport.SelectedIndex = cbDayReport.Items.IndexOf(31);
                cbDayReport.SelectedText = 31.ToString();
                ReportDay(1);
                ReportMonth();
                ReportDate();

            }
            else
            {
                Application.Exit();
            }
        }
        void ReportDay(int days=31)
        {
            ReportMainFormViewModel rpViewModel = new ReportMainFormViewModel();
            rpViewModel = MainFormReportCalcuting.CalcuteReport(days);
            lblDayPayReport.Text = rpViewModel.Pay.ToString("#,0");
            lblDayRecieveReport.Text = rpViewModel.Recieve.ToString("#,0");
            lblDayBalanceReport.Text = rpViewModel.Balance.ToString("#,0");
        }
        void ReportMonth(int month=1)
        {
            DateTime startDateTime = DateTime.Now.AddMonths(-month);
            DateTime endDateTime = DateTime.Now;
            int numberOfdays = Convert.ToInt32((endDateTime - startDateTime).TotalDays);
            ReportMainFormViewModel rpViewModel = new ReportMainFormViewModel();
            rpViewModel = MainFormReportCalcuting.CalcuteReport(numberOfdays);
            lblMonthsBalanceReport.Text = rpViewModel.Balance.ToString("#,0");
            lblMonthsPayReport.Text = rpViewModel.Pay.ToString("#,0");
            lblMonthsRecieveReport.Text = rpViewModel.Recieve.ToString("#,0");
        }
        void ReportDate(string startDate= "    /  /", string endDate= "    /  /")
        {
            ReportMainFormViewModel rpViewModel = new ReportMainFormViewModel();
            if (startDate!= "    /  /")
            {

            }
            string startDateTime = txtFromDate.Text;
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
