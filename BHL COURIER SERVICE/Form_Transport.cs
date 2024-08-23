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
    public partial class Form_Transport : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=db_bhl.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        public Form_Transport()
        {
            InitializeComponent();
        }

        private void BtnCLear_Click(object sender, EventArgs e)
        {
            lblVehiID.Text = "";
            cbVehiType.Text = "";
            txtVehiNumber.Text = "";
            cbVehiType.Focus();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        void BlindData()
        {
            con.Open();
            string viewvehi = "SELECT * FROM tbl_transport";
            cmd = new OleDbCommand(viewvehi, con);
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(viewvehi, con);
            DataTable ds = new DataTable();
            dataAdapter.Fill(ds);
            dgvVehicle.DataSource = ds;
            con.Close();
        }

        private void Form_Transport_Load(object sender, EventArgs e)
        {
            BlindData();
        }

        private void DgvVehicle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblVehiID.Text = dgvVehicle.SelectedRows[0].Cells[0].Value.ToString();
            cbVehiType.Text = dgvVehicle.SelectedRows[0].Cells[1].Value.ToString();
            txtVehiNumber.Text = dgvVehicle.SelectedRows[0].Cells[2].Value.ToString();
            
        }

        private void BtnAddSup_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                con.Open();
                string addvehicle = "INSERT INTO tbl_transport ([VehicleType], [VehicleNumber]) VALUES ('" + cbVehiType.Text + "' ,'" + txtVehiNumber.Text + "')";
                cmd = new OleDbCommand(addvehicle, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Your Vehicle details has been Successfully Inserted", "Add Vehicle Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                BlindData();

                lblVehiID.Text = "";
                cbVehiType.Text = "";
                txtVehiNumber.Text = "";
                cbVehiType.Focus();
            }
            
        }

        private void BtnEditCus_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string updatevehicle = "UPDATE tbl_transport SET VehicleType= '" + cbVehiType.Text + "' ,VehicleNumber= '" + txtVehiNumber.Text + "' WHERE VehicleType= '" + cbVehiType.Text + "' ";
                cmd = new OleDbCommand(updatevehicle, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Your Vehicle details has been Successfully updated", "Edit Vehicle Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BlindData();

                lblVehiID.Text = "";
                cbVehiType.Text = "";
                txtVehiNumber.Text = "";
                cbVehiType.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error  " + ex);

            }
        }

        private void BtnDeleteCus_Click(object sender, EventArgs e)
        {
            if (txtVehiNumber.Text != "")
            {
                if (MessageBox.Show("Are you sure to delete?", "Delete The Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    con.Open();
                    string deletevehicle = "DELETE FROM tbl_transport WHERE VehicleNumber= '" + txtVehiNumber.Text + "'";
                    cmd = new OleDbCommand(deletevehicle, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Your Vehicle has been Successfully Deleted", "Delete Vehicle Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    BlindData();

                }


            }
            else
            {
                MessageBox.Show("Please SELECT Vehicle Number");
            }

            lblVehiID.Text = "";
            cbVehiType.Text = "";
            txtVehiNumber.Text = "";
            cbVehiType.Focus();
        }

        private void TxtVehiNumber_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtVehiNumber.Text))
            {
                e.Cancel = true;
                txtVehiNumber.Focus();
                errorProvider1.SetError(txtVehiNumber, "Please Enter Vehicle Number!");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtVehiNumber, null);
            }
        }
    }
}
