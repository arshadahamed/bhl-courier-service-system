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

namespace BHL_COURIER_SERVICE
{
    public partial class Form_Welcome : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=db_bhl.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        public string UserName { get; set; }
      
        public Form_Welcome()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to Close this App?", "Application Close", MessageBoxButtons.YesNo) == DialogResult.Yes)
           
            {
                Application.Exit();
            }
        }

        private void Form_Welcome_Load(object sender, EventArgs e)
        {
            if (lblWCUType.Text == "Cashier" || lblWCUType.Text == "Assitant" || lblWCUType.Text == "Demo")
            {
                btnUsers.Hide();
                btnEmployee.Hide();
                btnReport.Hide();
                button5.Hide();
            }


          
            UserName = lblWCUName.Text;
            CustCount();
            EmpCount();
            JobCount();
            timer1.Start();
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void Timer1_Tick_1(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongDateString();
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void BtnCustomer_Click(object sender, EventArgs e)
        {
            Form_Customer customerform = new Form_Customer();
            customerform.ShowDialog();
        }

        private void BtnUsers_Click(object sender, EventArgs e)
        {
            Form_UserList userform = new Form_UserList();
            userform.ShowDialog();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to Logout?", "User Logout", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                new UsersForm().Show();
                this.Hide();
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            new Form_Employee().ShowDialog();
            
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Form_Transport transportform = new Form_Transport();
            transportform.ShowDialog();
        }
        void CustCount()
        {
            con.Open();
            string countcustomer = "SELECT COUNT(CustomerID) FROM tbl_customers";
            cmd = new OleDbCommand(countcustomer, con);
            Int32 rows_count = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Dispose();
            con.Close();
            lblTotalCus.Text = rows_count.ToString();
        }
        void EmpCount()
        {
            con.Open();
            string countemployees = "SELECT COUNT(EmployeeID) FROM tbl_employees";
            cmd = new OleDbCommand(countemployees, con);
            Int32 rows_count = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Dispose();
            con.Close();
            lblTotalEmp.Text = rows_count.ToString();
        }
        void JobCount()
        {
            con.Open();
            string countjob = "SELECT COUNT(InvoiceNumber) FROM tbl_job";
            cmd = new OleDbCommand(countjob, con);
            Int32 rows_count = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Dispose();
            con.Close();
            lblTotalJob.Text = rows_count.ToString();
        }

        private void BtnBranch_Click(object sender, EventArgs e)
        {
            new Form_Branch().ShowDialog();
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Form_Packages packform = new Form_Packages();
            packform.ShowDialog();
        }

        private void BtnShipment_Click(object sender, EventArgs e)
        {
            Form_Job jobform = new Form_Job();
            jobform.ShowDialog();
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void LblWCUType_Click(object sender, EventArgs e)
        {

        }

        private void LblWCUName_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Form_Settings setform = new Form_Settings();
            setform.ShowDialog();
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            CustCount();
            EmpCount();
            JobCount();
        }
    }
    
}
