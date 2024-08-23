using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using BHL_COURIER_SERVICE.CustomControl;

namespace BHL_COURIER_SERVICE.CustomControl
{
    public partial class btnUser : UserControl
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=db_bhl.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        public string UserID { get; set; }
        public string UserType
        {
            get { return lblType.Text; }
            set { lblType.Text = value;  }
        }

        public string UserName
        {
            get { return lblUName.Text; }
            set { lblUName.Text = value; }
        }
        public btnUser()
        {
            InitializeComponent();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void LblUName_Click(object sender, EventArgs e)
        {
            Form_Login login = new Form_Login();
            login.lblUserLo.Text = UserName;
            login.lblUsType.Text = UserType;
            login.Show();
            ((Form)this.TopLevelControl).Close();







        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Form_Login login = new Form_Login();
            login.lblUserLo.Text = UserName;
            login.lblUsType.Text = UserType;
          
            login.Show();

            ((Form)this.TopLevelControl).Close();


        }
    }
}
