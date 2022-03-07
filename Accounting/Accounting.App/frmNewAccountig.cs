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

        }
    }
}
