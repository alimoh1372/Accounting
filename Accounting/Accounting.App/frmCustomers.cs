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
    }
}
