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
    public partial class Form_Customer : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=db_bhl.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        public Form_Customer()
        {
            InitializeComponent();
        }

        private void Form_Customer_Load(object sender, EventArgs e)
        {
            BlindData();

        }

        private void BtnCLear_Click(object sender, EventArgs e)
        {
            lblCustID.Text = "";
            txtCusName.Text = "";
            txtCusAddress.Text = "";
            txtCusCity.Text = "";
            txtCusPhoneNum.Text = "";
            txtCMobNumber.Text = "";
            txtCusEmail.Text = "";
            txtCusName.Focus();

        }
        void BlindData()
        {
            con.Open();
            string viewcustomer = "SELECT * FROM tbl_customers";
            cmd = new OleDbCommand(viewcustomer, con);
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(viewcustomer, con);
            DataTable ds = new DataTable();
            dataAdapter.Fill(ds);
            dgvCustomer.DataSource = ds;
            con.Close();
        }


        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblCustID.Text = dgvCustomer.SelectedRows[0].Cells[0].Value.ToString();
            txtCusName.Text = dgvCustomer.SelectedRows[0].Cells[1].Value.ToString();
            txtCusAddress.Text = dgvCustomer.SelectedRows[0].Cells[2].Value.ToString();
            txtCusCity.Text = dgvCustomer.SelectedRows[0].Cells[3].Value.ToString();
            txtCusPhoneNum.Text = dgvCustomer.SelectedRows[0].Cells[4].Value.ToString();
            txtCMobNumber.Text = dgvCustomer.SelectedRows[0].Cells[5].Value.ToString();
            txtCusEmail.Text = dgvCustomer.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void BtnAddSup_Click(object sender, EventArgs e)
        {
            if (txtCusName.Text == "" && txtCusAddress.Text == "" && txtCusCity.Text == "" &&txtCusPhoneNum.Text == "" && txtCMobNumber.Text == "" && txtCusEmail.Text == "")
            {
                MessageBox.Show("The Field are empty", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                con.Open();
                string addcustomer = "INSERT INTO tbl_customers ([CustomerName], [Address], [City], [PhoneNumber], [MobileNumber], [Email]) VALUES ('" + txtCusName.Text + "','" + txtCusAddress.Text + "' ,'" + txtCusCity.Text + "','" + int.Parse(txtCusPhoneNum.Text) + "','" + int.Parse(txtCMobNumber.Text) + "','" + txtCusEmail.Text + "')";
                cmd = new OleDbCommand(addcustomer, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Your Customer details has been Successfully Inserted", "Add Customer Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                BlindData();
            }
                


            lblCustID.Text = "";
            txtCusName.Text = "";
            txtCusAddress.Text = "";
            txtCusCity.Text = "";
            txtCusPhoneNum.Text = "";
            txtCMobNumber.Text = "";
            txtCusEmail.Text = "";
            txtCusName.Focus();
        }

        private void BtnEditCus_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string updatecustomer = "UPDATE tbl_customers SET CustomerName= '" + txtCusName.Text + "' ,Address= '" + txtCusAddress.Text + "' ,City= '" + txtCusCity.Text + "' ,PhoneNumber= '" + int.Parse(txtCusPhoneNum.Text) + "' ,MobileNumber= '" + int.Parse(txtCMobNumber.Text) + "' ,Email= '" +txtCusEmail.Text + "' WHERE CustomerID= " + int.Parse(lblCustID.Text) + " ";
                cmd = new OleDbCommand(updatecustomer, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Your Customer details has been Successfully updated", "Edit Customer Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BlindData();

                lblCustID.Text = "";
                txtCusName.Text = "";
                txtCusAddress.Text = "";
                txtCusCity.Text = "";
                txtCusPhoneNum.Text = "";
                txtCMobNumber.Text = "";
                txtCusEmail.Text = "";
                txtCusName.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error  " + ex);

            }
        }

        private void BtnDeleteCus_Click(object sender, EventArgs e)
        {
            if (txtCusName.Text != "")
            {
                if (MessageBox.Show("Are you sure to delete?", "Delete The Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    con.Open();
                    string deletecustoemr = "DELETE FROM tbl_customers WHERE CustomerName = '" + txtCusName.Text + "'";
                    cmd = new OleDbCommand(deletecustoemr, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Your Customer has been Successfully Deleted", "Delete Customer Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    BlindData();

                }


            }
            else
            {
                MessageBox.Show("Please Enter Customer ID");
            }

            lblCustID.Text = "";
            txtCusName.Text = "";
            txtCusAddress.Text = "";
            txtCusCity.Text = "";
            txtCusPhoneNum.Text = "";
            txtCMobNumber.Text = "";
            txtCusEmail.Text = "";
            txtCusName.Focus();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            con.Open();
            string searchcus = "SELECT * FROM tbl_customers WHERE CustomerName LIKE '" + txtSearch.Text + "%' OR CustomerID LIKE '" + txtSearch.Text + "%'";
            cmd = new OleDbCommand(searchcus, con);
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(searchcus, con);
            DataTable ds = new DataTable();
            dataAdapter.Fill(ds);
            dgvCustomer.DataSource = ds;
            con.Close();
        }
    }
}
