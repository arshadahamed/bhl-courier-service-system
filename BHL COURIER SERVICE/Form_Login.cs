using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using BHL_COURIER_SERVICE.Helpers;

namespace BHL_COURIER_SERVICE
{
    public partial class Form_Login : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=db_bhl.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        public string UName { get; set; }

        public string USType
        {
            get { return lblUsType.Text; }
            set { lblUsType.Text = value; }
        }
        public string UserName
        {
            get { return lblUserLo.Text; }
            set { lblUserLo.Text = value; }
        }

        public Form_Login()
        {
            InitializeComponent();
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {
            UName = lblUserLo.Text;
            USType = lblUsType.Text;
            
            

        }

        public void Caps()
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                label7.Text = "Caps Lock On";
                label7.Visible = true;
                label7.ForeColor = System.Drawing.Color.Lime;
            }
            else
            {
                label7.Visible = false;
                /*label7.Text = "Caps Lock Off";
                label7.ForeColor = System.Drawing.Color.Red;*/

            }
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtPassword.Focus();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            

            
            con.Open();
            string login = "SELECT username,password FROM tbl_users WHERE username= '" + lblUserLo.Text + "' AND password= '" + txtPassword.Text + "'";
            cmd = new OleDbCommand(login, con);
            OleDbDataReader dr = cmd.ExecuteReader();



            if (dr.Read() == true)
            {
                Form_Welcome welcome = new Form_Welcome();
                welcome.lblWCUName.Text = UserName;
                welcome.lblWCUType.Text = USType;
                welcome.Show();
                /*new Form_Welcome().Show();*/
                this.Hide();
                


                /*UsersForm f1 = new UsersForm();
                f1.Hide();*/



            }
            else
            {
                MessageBox.Show("Invalid Username or Password, Please Try Again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = "";
                txtPassword.Focus();
            }

            con.Close(); 
        }

        private void CheckbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxShowPas.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void Label5_Click(object sender, EventArgs e)
        {
            new Form_Register().Show();
            this.Hide();
        }

        private void Label6_Click(object sender, EventArgs e)
        {
            new UsersForm().Show();
            this.Hide();
        }

        private void TxtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            Caps();

            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
            
            if (e.KeyCode == Keys.F1)
            {
                button1.PerformClick();
            }
        }
    }
}
