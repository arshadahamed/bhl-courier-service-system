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
    
    public partial class UsersForm : Form
    {
        DbHelper db;
        public bool visible = true;
        public UsersForm()
        {
            InitializeComponent();
            db = new DbHelper();
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            db.getButtons("SELECT * from tbl_users", panel1);
 
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Label5_Click(object sender, EventArgs e)
        {
            new Form_Register().Show();
            this.Hide();
        }

        private void BtnUser1_Load(object sender, EventArgs e)
        {


        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
