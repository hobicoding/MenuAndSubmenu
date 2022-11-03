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
    public partial class Form1 : Form
    {
        string Username = "";
        string Password = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            Data.Connect();
            DataTable dt = Data.SelecDataTable("SELECT Username,Password FROM UserLogin WHERE UPPER(Username)=@0", new object[] { tbUsername.Text.ToUpper() });
            Data.Disconnect();

            if (dt.Rows.Count > 0)
            {
                Username = dt.Rows[0][0].ToString().ToUpper();
                Password = dt.Rows[0][1].ToString();

                if (tbUsername.Text.ToUpper() == Username && tbPassword.Text == Password)
                {
                    Form2 frm = new Form2();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username or Password wrong!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Username wrong!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
