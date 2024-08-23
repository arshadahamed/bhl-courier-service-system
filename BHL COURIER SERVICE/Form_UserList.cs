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
    public partial class Form_UserList : Form
    {

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=db_bhl.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        public Form_UserList()
        {
            InitializeComponent();
        }

        private void BtnAddSup_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "" && txtUserPassword.Text == "" && cbUserType.Text == "")
            {
                MessageBox.Show("Username and Password Field are empty", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                con.Open();
                string register = "INSERT INTO tbl_users ([username], [type], [password]) VALUES('" + txtUserName.Text + "','" + cbUserType.Text + "','" + txtUserPassword.Text + "')";
                cmd = new OleDbCommand(register, con);
                cmd.ExecuteNonQuery();
                con.Close();

                txtUserName.Text = "";
                txtUserPassword.Text = "";
                cbUserType.Text = "";

                MessageBox.Show("Your Account has been Successfully Craeted", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                BlindData();
            }
            
        }

        private void BtnCLear_Click(object sender, EventArgs e)
        {
            lblUserID.Text = "";
            txtUserName.Text = "";
            txtUserPassword.Text = "";
            cbUserType.Text = "";
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        void BlindData()
        {
            con.Open();
            string viewuser = "SELECT * FROM tbl_users";
            cmd = new OleDbCommand(viewuser, con);
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(viewuser, con);
            DataTable ds = new DataTable();
            dataAdapter.Fill(ds);
            dgvUser.DataSource = ds;
            con.Close();
        }

        private void Form_UserList_Load(object sender, EventArgs e)
        {
            BlindData();
        }

        private void DgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblUserID.Text = dgvUser.SelectedRows[0].Cells[0].Value.ToString();
            txtUserName.Text = dgvUser.SelectedRows[0].Cells[1].Value.ToString();
            cbUserType.Text = dgvUser.SelectedRows[0].Cells[2].Value.ToString();
            txtUserPassword.Text = dgvUser.SelectedRows[0].Cells[3].Value.ToString();
         
        }

        private void BtnEditCus_Click(object sender, EventArgs e)
        {
            try
            {
                /*con.Open();
                string updatevuserlist = "UPDATE tbl_users SET username= '" + txtUserName.Text + "' ,type= '" + cbUserType.Text + "',password= '" + txtUserPassword.Text + "' WHERE id= " + int.Parse(lblUserID.Text) + " ";
                cmd = new OleDbCommand(updatevuserlist, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Your User details has been Successfully updated", "Edit User Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BlindData();*/

                con.Open();
                string updateUsersList = "UPDATE tbl_users SET username= '" + txtUserName.Text + "' ,type= '" + cbUserType.SelectedValue + "',password= '" + txtUserPassword.Text + "' WHERE id= " + int.Parse(lblUserID.Text) + " ";
                cmd = new OleDbCommand(updateUsersList, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Your User details has been Successfully updated", "Edit User Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                BlindData();

                txtUserName.Text = "";
                txtUserPassword.Text = "";
                cbUserType.Text = "";
                txtUserName.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error  " + ex);

            }


        }

        private void BtnDeleteCus_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text != "")
            {
                if (MessageBox.Show("Are you sure to delete?", "Delete The Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    con.Open();
                    string deleteuser = "DELETE FROM tbl_users WHERE username = '" + txtUserName.Text + "'";
                    cmd = new OleDbCommand(deleteuser, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Your User has been Successfully Deleted", "Delete User Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BlindData();
                    txtUserName.Text = "";
                    txtUserPassword.Text = "";
                   cbUserType.Text = "";
                    txtUserName.Focus();
                }


            }
            else
            {
                MessageBox.Show("Please Enter Userr Name");
            }
            /*
            con.Open();
            string deleteuser = "DELETE FROM tbl_users WHERE id= '" + lblUserID.Text + "'";
            cmd = new OleDbCommand(deleteuser, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Your User has been Successfully Deleted", "Delete User Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BlindData();


            lblUserID.Text = "";
            txtUserName.Text = "";
            txtUserPassword.Text = "";
            cbUserType.Text = "";
            txtUserName.Focus(); */
        }
    }
}
