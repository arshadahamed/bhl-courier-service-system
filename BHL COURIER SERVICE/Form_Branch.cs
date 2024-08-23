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
    public partial class Form_Branch : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=db_bhl.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        public Form_Branch()
        {
            InitializeComponent();
        }

        private void BtnCLear_Click(object sender, EventArgs e)
        {
            lblBranchID.Text = "";
            txtBranchName.Text = "";
            txtBranchCode.Text = "";
            txtBranchName.Focus();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        void BlindData()
        {
            con.Open();
            string viewbranch = "SELECT * FROM tbl_branch";
            cmd = new OleDbCommand(viewbranch, con);
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(viewbranch, con);
            DataTable ds = new DataTable();
            dataAdapter.Fill(ds);
            dgvBranch.DataSource = ds;
            con.Close();
        }

        private void DgvBranch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblBranchID.Text = dgvBranch.SelectedRows[0].Cells[0].Value.ToString();
            txtBranchName.Text = dgvBranch.SelectedRows[0].Cells[1].Value.ToString();
            txtBranchCode.Text = dgvBranch.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void BtnAddBranch_Click(object sender, EventArgs e)
        {
            if (txtBranchName.Text == "" && txtBranchCode.Text == "")
            {
                MessageBox.Show("The Field are empty", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                con.Open();
                string addbranch = "INSERT INTO tbl_branch ([BranchName], [BranchCode]) VALUES ('" + txtBranchName.Text + "' ,'" + txtBranchCode.Text + "')";
                cmd = new OleDbCommand(addbranch, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Branch details has been Successfully Inserted", "Add Branch Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                BlindData();
            }

                

            lblBranchID.Text = "";
            txtBranchName.Text = "";
            txtBranchCode.Text = "";
            txtBranchName.Focus();
        }

        private void BtnEditBranch_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string updatebranch = "UPDATE tbl_branch SET BranchName= '" + txtBranchName.Text + "' ,BranchCode= '" + txtBranchCode.Text + "' WHERE BranchName= '" + txtBranchName.Text + "' ";
                cmd = new OleDbCommand(updatebranch, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Your Vehicle details has been Successfully updated", "Edit Vehicle Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BlindData();

                lblBranchID.Text = "";
                txtBranchName.Text = "";
                txtBranchCode.Text = "";
                txtBranchName.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error  " + ex);

            }
        }

        private void BtnDeleteBranch_Click(object sender, EventArgs e)
        {
            if (txtBranchName.Text != "")
            {
                if (MessageBox.Show("Are you sure to delete?", "Delete The Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    con.Open();
                    string deletebranch = "DELETE FROM tbl_branch WHERE BranchName= '" + txtBranchName.Text + "'";
                    cmd = new OleDbCommand(deletebranch, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("The Branch has been Successfully Deleted", "Delete Branch Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    BlindData();

                }


            }
            else
            {
                MessageBox.Show("Please Enter Vehicle ID");
            }

            lblBranchID.Text = "";
            txtBranchName.Text = "";
            txtBranchCode.Text = "";
            txtBranchName.Focus();
        }

        private void Form_Branch_Load(object sender, EventArgs e)
        {
            BlindData();
            txtBranchName.Focus();

        }
    }
    
}
