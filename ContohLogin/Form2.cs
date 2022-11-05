using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ContohLogin
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void menuMasterItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("INI ADALAH MENU MASTER ITEM");
        }

        private void menuMasterSupplier_Click(object sender, EventArgs e)
        {
            MessageBox.Show("INI ADALAH MENU MASTER SUPPLIER");
        }

        private void subMenuItemStandard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("INI ADALAH SUBMENU ITEM STANDARD");
        }

        private void submenuItemNonStandard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("INI ADALAH SUBMENU ITEM NON STANDARD");
        }
    }
}
