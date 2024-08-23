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
    public partial class Form_Employee : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=db_bhl.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        public Form_Employee()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCLear_Click(object sender, EventArgs e)
        {
            lblEmpD.Text = "";
            txtEmpName.Text = "";
            txtNic.Text = "";
            cbEmpType.Text = "";
            txtEmpPhoneNum.Text = "";
            txtEmpName.Focus();
        }

        private void BtnAddEmp_Click(object sender, EventArgs e)
        {
            if (txtEmpName.Text == "" && txtNic.Text == "" && cbEmpType.Text == "" && txtEmpPhoneNum.Text == "" )
            {
                MessageBox.Show("The Field are empty", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                con.Open();
                string addemployee = "INSERT INTO tbl_employees ([EmployeeName], [NIC], [EmployeeType], [PhoneNumber]) VALUES ('" + txtEmpName.Text + "','" + int.Parse(txtNic.Text) + "','" + cbEmpType.Text + "', '" + int.Parse(txtEmpPhoneNum.Text) + "')";
                cmd = new OleDbCommand(addemployee, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Your Addemployee details has been Successfully Inserted", "Add Addemployee Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                BlindData();
            }
              

            lblEmpD.Text = "";
            txtEmpName.Text = "";
            txtNic.Text = "";
            cbEmpType.Text = "";
            txtEmpPhoneNum.Text = "";
            txtEmpName.Focus();
        }
        void BlindData()
        {
            con.Open();
            string viewemployees = "SELECT * FROM tbl_employees";
            cmd = new OleDbCommand(viewemployees, con);
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(viewemployees, con);
            DataTable ds = new DataTable();
            dataAdapter.Fill(ds);
            dgvEmployees.DataSource = ds;
            con.Close();
        }

        private void BtnEditEmp_Click(object sender, EventArgs e)
        {
            
                try
                {
                    con.Open();
                    string updateemployee = "UPDATE tbl_employees SET EmployeeName= '" + txtEmpName.Text + "' ,NIC= '" + int.Parse(txtNic.Text) + "',EmployeeType= '" + cbEmpType.Text + "',PhoneNumber= '" + int.Parse(txtEmpPhoneNum.Text) + "' WHERE EmployeeID= " + int.Parse(lblEmpD.Text) + " ";
                    cmd = new OleDbCommand(updateemployee, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Your Employee details has been Successfully updated", "Edit Employee Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    BlindData();


                    lblEmpD.Text = "";
                    txtEmpName.Text = "";
                    txtNic.Text = "";
                    cbEmpType.Text = "";
                    txtEmpPhoneNum.Text = "";
                    txtEmpName.Focus();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error  " + ex);

                }
            
                
        }

        private void BtnDeleteEmp_Click(object sender, EventArgs e)
        {
            if (txtEmpName.Text != "")
            {
                if (MessageBox.Show("Are you sure to delete?", "Delete The Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    con.Open();
                    string deleteemployee = "DELETE FROM tbl_employees WHERE EmployeeName = '" + txtEmpName.Text + "'";
                    cmd = new OleDbCommand(deleteemployee, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Your Employee has been Successfully Deleted", "Delete Employee Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    BlindData();

                }


            }
            else
            {
                MessageBox.Show("Please Enter Employee ID");
            }

            lblEmpD.Text = "";
            txtEmpName.Text = "";
            txtNic.Text = "";
            cbEmpType.Text = "";
            txtEmpPhoneNum.Text = "";
            txtEmpName.Focus();
        }

        private void DgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblEmpD.Text = dgvEmployees.SelectedRows[0].Cells[0].Value.ToString();
            txtEmpName.Text = dgvEmployees.SelectedRows[0].Cells[1].Value.ToString();
            txtNic.Text = dgvEmployees.SelectedRows[0].Cells[2].Value.ToString();
            cbEmpType.Text = dgvEmployees.SelectedRows[0].Cells[3].Value.ToString();
            txtEmpPhoneNum.Text = dgvEmployees.SelectedRows[0].Cells[4].Value.ToString();
          
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
           /* if (MessageBox.Show("Are you sure to Clear the all the records ?", "Reset Records", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                con.Open();
                string resetEmp = "TRUNCATE TABLE tbl_employees;";
                cmd = new OleDbCommand(resetEmp, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Your Employees Table  has been Fully Cleared", "Employee Table Reset", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                BlindData();

                lblEmpD.Text = "";
                txtEmpName.Text = "";
                txtNic.Text = "";
                cbEmpType.Text = "";
                txtEmpPhoneNum.Text = "";
                txtEmpName.Focus();
            }*/
            
        }

        private void Form_Employee_Load(object sender, EventArgs e)
        {
            BlindData();
        }
    }
}
