using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ProductForm form = new ProductForm())
            {
                form.ShowDialog();
            }
        }

        private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SupplierForm form = new SupplierForm())
            {
                form.ShowDialog();
            }
        }
    }
}
