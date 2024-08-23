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
    public partial class Form_Packages : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=db_bhl.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        public Form_Packages()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCLear_Click(object sender, EventArgs e)
        {
            lblPackID.Text = "";
            txtPackageName.Text = "";
            cbPakType.Text = "";
            cbPakLoadType.Text = "";
            txtPackPrice.Text = "";
            txtPackageName.Focus();
        }
        void BlindData()
        {
            con.Open();
            string viewpack = "SELECT * FROM tbl_packages";
            cmd = new OleDbCommand(viewpack, con);
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(viewpack, con);
            DataTable ds = new DataTable();
            dataAdapter.Fill(ds);
            dgvPackages.DataSource = ds;
            con.Close();
        }

        private void DgvPackages_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblPackID.Text = dgvPackages.SelectedRows[0].Cells[0].Value.ToString();
            txtPackageName.Text = dgvPackages.SelectedRows[0].Cells[1].Value.ToString();
            cbPakType.Text = dgvPackages.SelectedRows[0].Cells[2].Value.ToString();
            cbPakLoadType.Text = dgvPackages.SelectedRows[0].Cells[3].Value.ToString();
            txtPackPrice.Text = dgvPackages.SelectedRows[0].Cells[4].Value.ToString();
           
        }

        private void BtnAddBranch_Click(object sender, EventArgs e)
        {
            if (txtPackageName.Text == "" && cbPakType.Text == "" && cbPakLoadType.Text == "" && txtPackPrice.Text == "")
            {
                MessageBox.Show("The Field are empty", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                con.Open();
                string addpack = "INSERT INTO tbl_packages ([PackageName], [PackageType], [Package Load Type], [Price]) VALUES ('" + txtPackageName.Text + "' ,'" + cbPakType.Text + "','" + cbPakLoadType.Text + "','" + txtPackPrice.Text + "')";
                cmd = new OleDbCommand(addpack, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Package details has been Successfully Inserted", "Add Package Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                BlindData();
            }
                

            lblPackID.Text = "";
            txtPackageName.Text = "";
            cbPakType.Text = "";
            cbPakLoadType.Text = "";
            txtPackPrice.Text = "";
            txtPackageName.Focus();
        }

        private void Form_Packages_Load(object sender, EventArgs e)
        {
            BlindData();
        }

        private void BtnEditBranch_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string updatepack = "UPDATE tbl_packages SET PackageName= '" + txtPackageName.Text + "' ,PackageType= '" + cbPakType.Text + "',Package Load Type= '" + cbPakLoadType.Text + "',Price= '" + txtPackPrice.Text + "' WHERE PackageName= '" + txtPackageName.Text + "'  ";
                cmd = new OleDbCommand(updatepack, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Your Vehicle details has been Successfully updated", "Edit Vehicle Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BlindData();

                lblPackID.Text = "";
                txtPackageName.Text = "";
                cbPakType.Text = "";
                cbPakLoadType.Text = "";
                txtPackPrice.Text = "";
                txtPackageName.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error  " + ex);

            }
        }

        private void BtnDeleteBranch_Click(object sender, EventArgs e)
        {
            if (txtPackageName.Text != "")
            {
                if (MessageBox.Show("Are you sure to delete?", "Delete The Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    con.Open();
                    string deletepack = "DELETE FROM tbl_packages WHERE PackageName= '" + txtPackageName.Text + "'";
                    cmd = new OleDbCommand(deletepack, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("The Package details has been Successfully Deleted", "Delete Package Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    BlindData();

                }


            }
            else
            {
                MessageBox.Show("Please Type Package Name");
            }

            lblPackID.Text = "";
            txtPackageName.Text = "";
            cbPakType.Text = "";
            cbPakLoadType.Text = "";
            txtPackPrice.Text = "";
            txtPackageName.Focus();
        }
    }
}
