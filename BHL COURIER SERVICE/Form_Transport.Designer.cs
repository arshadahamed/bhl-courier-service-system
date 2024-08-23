namespace BHL_COURIER_SERVICE
{
    partial class Form_Transport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbVehiType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDeleteCus = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCLear = new System.Windows.Forms.Button();
            this.dgvVehicle = new System.Windows.Forms.DataGridView();
            this.txtVehiNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblVehicle = new System.Windows.Forms.Label();
            this.btnEditCus = new System.Windows.Forms.Button();
            this.btnAddSup = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblVehiID = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbVehiType
            // 
            this.cbVehiType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.cbVehiType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbVehiType.Font = new System.Drawing.Font("Nirmala UI", 14.25F);
            this.cbVehiType.FormattingEnabled = true;
            this.cbVehiType.Items.AddRange(new object[] {
            "Lorry",
            "Van",
            "Bike"});
            this.cbVehiType.Location = new System.Drawing.Point(231, 235);
            this.cbVehiType.Name = "cbVehiType";
            this.cbVehiType.Size = new System.Drawing.Size(301, 33);
            this.cbVehiType.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 13F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(740, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 101;
            this.label1.Text = "Vehicle List";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 13F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(65)))), ((int)(((byte)(66)))));
            this.label3.Location = new System.Drawing.Point(65, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 25);
            this.label3.TabIndex = 100;
            this.label3.Text = "Vehicle Number";
            // 
            // btnDeleteCus
            // 
            this.btnDeleteCus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.btnDeleteCus.FlatAppearance.BorderSize = 0;
            this.btnDeleteCus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCus.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnDeleteCus.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCus.Location = new System.Drawing.Point(418, 399);
            this.btnDeleteCus.Name = "btnDeleteCus";
            this.btnDeleteCus.Size = new System.Drawing.Size(156, 32);
            this.btnDeleteCus.TabIndex = 5;
            this.btnDeleteCus.Text = "Delete Vehicle";
            this.btnDeleteCus.UseVisualStyleBackColor = false;
            this.btnDeleteCus.Click += new System.EventHandler(this.BtnDeleteCus_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.btnCancel.Location = new System.Drawing.Point(322, 465);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(156, 33);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnCLear
            // 
            this.btnCLear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.btnCLear.FlatAppearance.BorderSize = 0;
            this.btnCLear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCLear.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnCLear.ForeColor = System.Drawing.Color.White;
            this.btnCLear.Location = new System.Drawing.Point(149, 465);
            this.btnCLear.Name = "btnCLear";
            this.btnCLear.Size = new System.Drawing.Size(156, 32);
            this.btnCLear.TabIndex = 6;
            this.btnCLear.Text = "Clear";
            this.btnCLear.UseVisualStyleBackColor = false;
            this.btnCLear.Click += new System.EventHandler(this.BtnCLear_Click);
            // 
            // dgvVehicle
            // 
            this.dgvVehicle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvVehicle.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvVehicle.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(91)))));
            this.dgvVehicle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVehicle.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvVehicle.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVehicle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVehicle.ColumnHeadersHeight = 50;
            this.dgvVehicle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvVehicle.EnableHeadersVisualStyles = false;
            this.dgvVehicle.Location = new System.Drawing.Point(606, 135);
            this.dgvVehicle.Name = "dgvVehicle";
            this.dgvVehicle.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVehicle.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvVehicle.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVehicle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVehicle.Size = new System.Drawing.Size(389, 439);
            this.dgvVehicle.TabIndex = 95;
            this.dgvVehicle.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvVehicle_CellClick);
            // 
            // txtVehiNumber
            // 
            this.txtVehiNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtVehiNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVehiNumber.Font = new System.Drawing.Font("Nirmala UI", 14.25F);
            this.txtVehiNumber.Location = new System.Drawing.Point(231, 290);
            this.txtVehiNumber.Multiline = true;
            this.txtVehiNumber.Name = "txtVehiNumber";
            this.txtVehiNumber.Size = new System.Drawing.Size(301, 27);
            this.txtVehiNumber.TabIndex = 2;
            this.txtVehiNumber.Validating += new System.ComponentModel.CancelEventHandler(this.TxtVehiNumber_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 13F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(65)))), ((int)(((byte)(66)))));
            this.label2.Location = new System.Drawing.Point(65, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 98;
            this.label2.Text = "Vehicle Type";
            // 
            // lblVehicle
            // 
            this.lblVehicle.AutoSize = true;
            this.lblVehicle.Font = new System.Drawing.Font("Nirmala UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblVehicle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(65)))), ((int)(((byte)(66)))));
            this.lblVehicle.Location = new System.Drawing.Point(65, 188);
            this.lblVehicle.Name = "lblVehicle";
            this.lblVehicle.Size = new System.Drawing.Size(74, 25);
            this.lblVehicle.TabIndex = 97;
            this.lblVehicle.Text = "User ID";
            // 
            // btnEditCus
            // 
            this.btnEditCus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.btnEditCus.FlatAppearance.BorderSize = 0;
            this.btnEditCus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCus.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnEditCus.ForeColor = System.Drawing.Color.White;
            this.btnEditCus.Location = new System.Drawing.Point(244, 399);
            this.btnEditCus.Name = "btnEditCus";
            this.btnEditCus.Size = new System.Drawing.Size(156, 32);
            this.btnEditCus.TabIndex = 4;
            this.btnEditCus.Text = "Edit Vehcile Detail";
            this.btnEditCus.UseVisualStyleBackColor = false;
            this.btnEditCus.Click += new System.EventHandler(this.BtnEditCus_Click);
            // 
            // btnAddSup
            // 
            this.btnAddSup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.btnAddSup.FlatAppearance.BorderSize = 0;
            this.btnAddSup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSup.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddSup.ForeColor = System.Drawing.Color.White;
            this.btnAddSup.Location = new System.Drawing.Point(70, 399);
            this.btnAddSup.Name = "btnAddSup";
            this.btnAddSup.Size = new System.Drawing.Size(156, 32);
            this.btnAddSup.TabIndex = 3;
            this.btnAddSup.Text = "Add a Vehicle";
            this.btnAddSup.UseVisualStyleBackColor = false;
            this.btnAddSup.Click += new System.EventHandler(this.BtnAddSup_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(354, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(267, 56);
            this.label7.TabIndex = 96;
            this.label7.Text = "Vehicle Details";
            // 
            // lblVehiID
            // 
            this.lblVehiID.AutoSize = true;
            this.lblVehiID.Font = new System.Drawing.Font("Nirmala UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblVehiID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.lblVehiID.Location = new System.Drawing.Point(231, 188);
            this.lblVehiID.Name = "lblVehiID";
            this.lblVehiID.Size = new System.Drawing.Size(97, 25);
            this.lblVehiID.TabIndex = 104;
            this.lblVehiID.Text = "Vehicle ID";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form_Transport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1022, 595);
            this.Controls.Add(this.lblVehiID);
            this.Controls.Add(this.cbVehiType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDeleteCus);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCLear);
            this.Controls.Add(this.dgvVehicle);
            this.Controls.Add(this.txtVehiNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblVehicle);
            this.Controls.Add(this.btnEditCus);
            this.Controls.Add(this.btnAddSup);
            this.Controls.Add(this.label7);
            this.Name = "Form_Transport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transport";
            this.Load += new System.EventHandler(this.Form_Transport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbVehiType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDeleteCus;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCLear;
        private System.Windows.Forms.DataGridView dgvVehicle;
        private System.Windows.Forms.TextBox txtVehiNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblVehicle;
        private System.Windows.Forms.Button btnEditCus;
        private System.Windows.Forms.Button btnAddSup;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblVehiID;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}