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
    public partial class Form_Job : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=db_bhl.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        public Form_Job()
        {
            InitializeComponent();
            invoicenum();
        }
        private void LoadUser()
        {
            DataRow dr;
            con.Open();
            string userselect = "SELECT id,username FROM tbl_users";
            cmd = new OleDbCommand(userselect, con);
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(userselect, con);
            DataTable ds = new DataTable();
            dataAdapter.Fill(ds);
            dr = ds.NewRow();
            dr.ItemArray = new object[] { 0, "--Select User--" };
            ds.Rows.InsertAt(dr, 0);

            cbInvoicerName.ValueMember = "id";

            cbInvoicerName.DisplayMember = "username";
            cbInvoicerName.DataSource = ds;
            con.Close();

        }
        private void Loadpacktype()
        {
            DataRow dr;
            con.Open();
            string packselect = "SELECT PackID,PackageName FROM tbl_packages";
            cmd = new OleDbCommand(packselect, con);
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(packselect, con);
            DataTable ds = new DataTable();
            dataAdapter.Fill(ds);
            dr = ds.NewRow();
            dr.ItemArray = new object[] { 0, "--Select Pack Type--" };
            ds.Rows.InsertAt(dr, 0);

            cbPackType.ValueMember = "PackID";

            cbPackType.DisplayMember = "PackageName";
            cbPackType.DataSource = ds;
            con.Close();

        }
        private void Loaddriver()
        {
            DataRow dr;
            con.Open();
            string driverselect = "SELECT EmployeeID,EmployeeName,EmployeeType FROM tbl_employees WHERE EmployeeType='Driver' ";
            cmd = new OleDbCommand(driverselect, con);
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(driverselect, con);
            DataTable ds = new DataTable();
            dataAdapter.Fill(ds);
            dr = ds.NewRow();
            dr.ItemArray = new object[] { 0, "--Select a Driver--" };
            ds.Rows.InsertAt(dr, 0);

            cbDriver.ValueMember = "EmployeeID";
            cbDriver.DisplayMember = "EmployeeName";
            cbDriver.DataSource = ds;
            con.Close();

        }
        private void LoadVehicle()
        {
            DataRow dr;
            con.Open();
            string vehiselect = "SELECT VehicleID,VehicleType,VehicleNumber FROM tbl_transport";
            cmd = new OleDbCommand(vehiselect, con);
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(vehiselect, con);
            DataTable ds = new DataTable();
            dataAdapter.Fill(ds);
            dr = ds.NewRow();
            dr.ItemArray = new object[] { 0, "--Select a Vehicle--" };
            ds.Rows.InsertAt(dr, 0);

            cbVehicleID.ValueMember = "VehicleID";
            cbVehicleID.DisplayMember = "VehicleNumber";
            cbVehicleID.DataSource = ds;
            con.Close();

        }

        private void Loadassitant()
        {
            DataRow dr;
            con.Open();
            string assistselect = "SELECT EmployeeID,EmployeeName,EmployeeType FROM tbl_employees WHERE EmployeeType='Assistant'";
            cmd = new OleDbCommand(assistselect, con);
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(assistselect, con);
            DataTable ds = new DataTable();
            dataAdapter.Fill(ds);
            dr = ds.NewRow();
            dr.ItemArray = new object[] { 0, "--Select an Assistant--" };
            ds.Rows.InsertAt(dr, 0);

            cbAssistant.ValueMember = "EmployeeID";
            cbAssistant.DisplayMember = "EmployeeName";
            cbAssistant.DataSource = ds;
            con.Close();

        }
        private void LoadSendbranch()
        {
            DataRow dr;
            con.Open();
            string branchselect = "SELECT BranchID,BranchName,BranchCode FROM tbl_branch";
            cmd = new OleDbCommand(branchselect, con);
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(branchselect, con);
            DataTable ds = new DataTable();
            dataAdapter.Fill(ds);
            dr = ds.NewRow();
            dr.ItemArray = new object[] { 0, "--Select A Branch--" };
            ds.Rows.InsertAt(dr, 0);

            cbSendBranchCode.ValueMember = "BranchID";
            cbSendBranchCode.DisplayMember = "BranchCode";
            cbSendBranchCode.DataSource = ds;
            con.Close();

        }
        private void Loadrecievebranch()
        {
            DataRow dr;
            con.Open();
            string branchselect = "SELECT BranchID,BranchName,BranchCode FROM tbl_branch";
            cmd = new OleDbCommand(branchselect, con);
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(branchselect, con);
            DataTable ds = new DataTable();
            dataAdapter.Fill(ds);
            dr = ds.NewRow();
            dr.ItemArray = new object[] { 0, "--Select A Branch--" };
            ds.Rows.InsertAt(dr, 0);

            cbRecieveBranchCode.ValueMember = "BranchID";
            cbRecieveBranchCode.DisplayMember = "BranchCode";
            cbRecieveBranchCode.DataSource = ds;
            con.Close();

        }

        private void Button24_Click(object sender, EventArgs e)
        {
            Close();
            
        }

        private void Button23_Click(object sender, EventArgs e)
        {
            cbInvoicerName.Text = "";
            /*lblInvoiceNum.Text = "";*/
            dtpInvoiceDate.Text = "";
            txtSendCusID.Text = "";
            txtSendCusName.Text = "";
            txtSendCusAddress.Text = "";
            txtSendCusCity.Text = "";
            txtSendCusPhoneNum.Text = "";
            cbSendBranchCode.Text = "";
            txtRecieveCusID.Text = "";
            txtRecieveCusName.Text = "";
            txtRecieveCusAddress.Text = "";
            txtRecieveCusCity.Text = "";
            txtRecieveCusPhoneNum.Text = "";
            cbRecieveBranchCode.Text = "";
            cbPackType.Text = "";
            cbDriver.Text = "";
            cbAssistant.Text = "";
            cbVehicleID.Text = "";
            txtTrackingID.Text = "";
            cbPayment.Text = "";
            cbStatus.Text = "";
            lblTotalAmount.Text = "";
            txtsearchcus1.Text = "";
            cbInvoicerName.Focus();
        }

        private void BtnAddSendCus_Click(object sender, EventArgs e)
        {
            Form_Customer customerform = new Form_Customer();
            customerform.ShowDialog();
        }

        private void BtnAddRecieveCus_Click(object sender, EventArgs e)
        {
            Form_Customer customerform = new Form_Customer();
            customerform.ShowDialog();
        }

        private void Form_Job_Load(object sender, EventArgs e)
        {
            
            LoadUser();
            Loadpacktype();
            Loaddriver();
            Loadassitant();
            LoadSendbranch();
            Loadrecievebranch();
            LoadVehicle();
            timer1.Start();

            OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=db_bhl.mdb");
            OleDbDataAdapter dda = new OleDbDataAdapter("SELECT PackID,PackageName,Price FROM tbl_packages",con);
            DataSet dt = new DataSet();
            dda.Fill(dt, "PackageName");
            cbPackType.DataSource = dt.Tables["PackageName"];
            cbPackType.DisplayMember = "PackageName";
            cbPackType.ValueMember = "Price";
            cbPackType.Text = "Select a Pack Type";
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongDateString();
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void CbPackType_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void CbPackType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            lblTotalAmount.Text = cbPackType.GetItemText(cbPackType.SelectedValue);
        }

        public void invoicenum()
        {
            try
            {
                con.Open();
                string num_rows_query = "SELECT COUNT(InvoiceNumber) FROM tbl_job";
               // string invoicenum = "SELECT MAX(InvoiceNumber) FROM tbl_job";
                cmd = new OleDbCommand(num_rows_query, con);
                string maxid =null;

                var row_count = cmd.ExecuteScalar();
                if (Convert.ToInt32(row_count) != 0)
                {
                    string invoicenum = "SELECT InvoiceNumber FROM tbl_job  ORDER BY InvoiceNumber DESC";
                    cmd = new OleDbCommand(invoicenum, con);
                    maxid = cmd.ExecuteScalar().ToString();
                }
                              

                if(maxid == null)
                {
                    lblInvoiceNum.Text = "INV-00001";
                }
                else
                {
                    int intval = int.Parse(maxid.Substring(4, 5));
                    intval++;
                    lblInvoiceNum.Text = String.Format("INV-0000{0}", intval);
                }
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void CbPayment_SelectionChangeCommitted(object sender, EventArgs e)
        {
            String coloursss = lblTotalAmount.Text;
            if(cbPayment.SelectedItem.Equals("Paid"))
            {
                label21.ForeColor = Color.Green;
                lblTotalAmount.ForeColor = Color.Green;
                
            }
            else if(cbPayment.SelectedItem.Equals("Not Paid"))
            {
                lblTotalAmount.ForeColor = Color.Red;
                label21.ForeColor = Color.Red;
            }
            else
            {
                lblTotalAmount.ForeColor = ColorTranslator.FromHtml("#E2574C");
                label21.ForeColor = ColorTranslator.FromHtml("#E2574C"); 
            }
        }

        private void BtnSaveJob_Click(object sender, EventArgs e)
        {
            
            
                con.Open();
                string addjob = "INSERT INTO tbl_job ([InvoiceNumber], [InvoiceDate], [InvoiceTime], [InvoicerName], [SenderID], [RecieverID], [PackageID], [DriverName], [AssistantName], [TrackingID], [Payment], [Status], [VehicleNumber], [Amount]) VALUES ('" + lblInvoiceNum.Text + "' ,'" + dtpInvoiceDate.Text + "','" + lblTime.Text + "','" + cbInvoicerName.Text + "','" + txtSendCusID.Text + "','" + txtRecieveCusID.Text + "','" + cbPackType.Text + "','" + cbDriver.Text + "','" + cbAssistant.Text + "','" + Int32.Parse(txtTrackingID.Text) + "','" + cbPayment.Text + "','" + cbStatus.Text + "','" + cbVehicleID.Text + "','" + Int32.Parse(lblTotalAmount.Text) + "')";
                cmd = new OleDbCommand(addjob, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Job details has been Successfully Saved", "Saved Job Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                invoicenum();


                cbInvoicerName.Text = "";
                /*lblInvoiceNum.Text = "";*/
                dtpInvoiceDate.Text = "";
                txtSendCusID.Text = "";
                txtSendCusName.Text = "";
                txtSendCusAddress.Text = "";
                txtSendCusCity.Text = "";
                txtSendCusPhoneNum.Text = "";
                cbSendBranchCode.Text = "";
                txtRecieveCusID.Text = "";
                txtRecieveCusName.Text = "";
                txtRecieveCusAddress.Text = "";
                txtRecieveCusCity.Text = "";
                txtRecieveCusPhoneNum.Text = "";
                cbRecieveBranchCode.Text = "";
                cbPackType.Text = "";
                cbDriver.Text = "";
                cbAssistant.Text = "";
                cbVehicleID.Text = "";
                txtTrackingID.Text = "";
                cbPayment.Text = "";
                cbStatus.Text = "";
                lblTotalAmount.Text = "";
                txtsearchcus1.Text = "";
                cbInvoicerName.Focus();
            
            
        }

        private void TxtSendCusID_KeyDown(object sender, KeyEventArgs e)
        {
           /* if (e.KeyCode == Keys.Enter)
            {
                con.Open();
                string getcus = "SELECT  CustomerID, CustomerName, Address, City,PhoneNumber FROM tbl_customers WHERE CustomerID = '" +(txtSendCusID.Text)+ "'";
                cmd = new OleDbCommand(getcus, con);
                cmd.Parameters.AddWithValue("txtSendCusID.Text", txtSendCusID.Text);
                OleDbDataReader reader1;
                reader1 = cmd.ExecuteReader();
                if (reader1.Read())
                {
                    txtSendCusName.Text = reader1["CustomerName"].ToString();
                    txtSendCusAddress.Text = reader1["Address"].ToString();
                    txtSendCusCity.Text = reader1["City"].ToString();
                    txtSendCusPhoneNum.Text = reader1["PhoneNumber"].ToString();
                }
                else
                {
                    MessageBox.Show("No Data Found");
                }
                con.Close();
            }*/
            
        }

        private void PictureBox9_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand getcus = new OleDbCommand("SELECT  CustomerID, CustomerName, Address, City,PhoneNumber FROM tbl_customers WHERE CustomerID = @parm1", con);
            getcus.Parameters.AddWithValue("@parm1", txtsearchRecCus.Text);
            OleDbDataReader reader1;
            reader1 = getcus.ExecuteReader();

            if (reader1.Read())
            {
                txtRecieveCusID.Text = reader1["CustomerID"].ToString();
                txtRecieveCusName.Text = reader1["CustomerName"].ToString();
                txtRecieveCusAddress.Text = reader1["Address"].ToString();
                txtRecieveCusCity.Text = reader1["City"].ToString();
                txtRecieveCusPhoneNum.Text = reader1["PhoneNumber"].ToString();
            }
            else
            {
                MessageBox.Show("No Data Found");
            }
            con.Close();
        }

        private void PictureBox10_Click(object sender, EventArgs e)
        {
           
        }

        private void Txtsearchcus1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearchCusSend.PerformClick();
                cbSendBranchCode.Focus();
            }
        }

        private void BtnSearchCusSend_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand getcus = new OleDbCommand("SELECT  CustomerID, CustomerName, Address, City,PhoneNumber FROM tbl_customers WHERE CustomerID = @parm1", con);
            getcus.Parameters.AddWithValue("@parm1", txtsearchcus1.Text);
            OleDbDataReader reader1;
            reader1 = getcus.ExecuteReader();
            if (reader1.Read())
            {
                txtSendCusID.Text = reader1["CustomerID"].ToString();
                txtSendCusName.Text = reader1["CustomerName"].ToString();
                txtSendCusAddress.Text = reader1["Address"].ToString();
                txtSendCusCity.Text = reader1["City"].ToString();
                txtSendCusPhoneNum.Text = reader1["PhoneNumber"].ToString();
            }
            else
            {
                MessageBox.Show("No Data Found");
            }
            con.Close();
        }

        private void BtnSearchCusReci_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand getcus = new OleDbCommand("SELECT  CustomerID, CustomerName, Address, City,PhoneNumber FROM tbl_customers WHERE CustomerID = @parm1", con);
            getcus.Parameters.AddWithValue("@parm1", txtsearchRecCus.Text);
            OleDbDataReader reader1;
            reader1 = getcus.ExecuteReader();
            if (reader1.Read())
            {
                txtRecieveCusID.Text = reader1["CustomerID"].ToString();
                txtRecieveCusName.Text = reader1["CustomerName"].ToString();
                txtRecieveCusAddress.Text = reader1["Address"].ToString();
                txtRecieveCusCity.Text = reader1["City"].ToString();
                txtRecieveCusPhoneNum.Text = reader1["PhoneNumber"].ToString();
            }
            else
            {
                MessageBox.Show("No Data Found");
            }
            con.Close();
        }

        private void TxtsearchRecCus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearchCusReci.PerformClick();
                cbRecieveBranchCode.Focus();

            }
        }

        private void CbSendBranchCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                 btnSearchCusReci.Focus();
            }
        }

        private void CbRecieveBranchCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cbPackType.Focus();
            }
        }

        private void Txtsearchcus1_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void LblTotalAmount_Click(object sender, EventArgs e)
        {

        }

        private void Label21_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void GroupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void Label20_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void GroupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void GroupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void GroupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TxtRecieve_Enter(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void CbDriver_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
