
namespace ManagerCafe.GUI
{
    partial class frmRevenue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRevenue));
            this.tabPageRevenueMonths = new System.Windows.Forms.TabPage();
            this.btnOK = new System.Windows.Forms.Button();
            this.dtpTabMonthChoice = new System.Windows.Forms.DateTimePicker();
            this.lblTotalMoney = new System.Windows.Forms.Label();
            this.lblNameTotal = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvRevenueDay_Month = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbbFinding = new System.Windows.Forms.ComboBox();
            this.cbbChoiceFind = new System.Windows.Forms.ComboBox();
            this.tabControlRevenue = new System.Windows.Forms.TabControl();
            this.btnLoad = new System.Windows.Forms.Button();
            this.tabPageRevenueMonths.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevenueDay_Month)).BeginInit();
            this.tabControlRevenue.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageRevenueMonths
            // 
            this.tabPageRevenueMonths.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(158)))), ((int)(((byte)(160)))));
            this.tabPageRevenueMonths.Controls.Add(this.btnLoad);
            this.tabPageRevenueMonths.Controls.Add(this.btnOK);
            this.tabPageRevenueMonths.Controls.Add(this.dtpTabMonthChoice);
            this.tabPageRevenueMonths.Controls.Add(this.lblTotalMoney);
            this.tabPageRevenueMonths.Controls.Add(this.lblNameTotal);
            this.tabPageRevenueMonths.Controls.Add(this.txtSearch);
            this.tabPageRevenueMonths.Controls.Add(this.btnSearch);
            this.tabPageRevenueMonths.Controls.Add(this.dgvRevenueDay_Month);
            this.tabPageRevenueMonths.Controls.Add(this.cbbFinding);
            this.tabPageRevenueMonths.Controls.Add(this.cbbChoiceFind);
            this.tabPageRevenueMonths.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageRevenueMonths.Location = new System.Drawing.Point(4, 32);
            this.tabPageRevenueMonths.Name = "tabPageRevenueMonths";
            this.tabPageRevenueMonths.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRevenueMonths.Size = new System.Drawing.Size(1020, 650);
            this.tabPageRevenueMonths.TabIndex = 0;
            this.tabPageRevenueMonths.Text = "Months";
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Location = new System.Drawing.Point(369, 7);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(63, 27);
            this.btnOK.TabIndex = 14;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // dtpTabMonthChoice
            // 
            this.dtpTabMonthChoice.CalendarFont = new System.Drawing.Font("Arial", 13F);
            this.dtpTabMonthChoice.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTabMonthChoice.Location = new System.Drawing.Point(0, 6);
            this.dtpTabMonthChoice.Name = "dtpTabMonthChoice";
            this.dtpTabMonthChoice.Size = new System.Drawing.Size(236, 30);
            this.dtpTabMonthChoice.TabIndex = 13;
            // 
            // lblTotalMoney
            // 
            this.lblTotalMoney.AutoSize = true;
            this.lblTotalMoney.Location = new System.Drawing.Point(205, 65);
            this.lblTotalMoney.Name = "lblTotalMoney";
            this.lblTotalMoney.Size = new System.Drawing.Size(21, 23);
            this.lblTotalMoney.TabIndex = 12;
            this.lblTotalMoney.Text = "0";
            // 
            // lblNameTotal
            // 
            this.lblNameTotal.AutoSize = true;
            this.lblNameTotal.Location = new System.Drawing.Point(2, 65);
            this.lblNameTotal.Name = "lblNameTotal";
            this.lblNameTotal.Size = new System.Drawing.Size(187, 23);
            this.lblNameTotal.TabIndex = 12;
            this.lblNameTotal.Text = "Total Revenue Day: ";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(6, 118);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(404, 30);
            this.txtSearch.TabIndex = 11;
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(415, 115);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(41, 32);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvRevenueDay_Month
            // 
            this.dgvRevenueDay_Month.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.dgvRevenueDay_Month.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRevenueDay_Month.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column8,
            this.Column6,
            this.Column7});
            this.dgvRevenueDay_Month.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvRevenueDay_Month.Location = new System.Drawing.Point(3, 154);
            this.dgvRevenueDay_Month.Name = "dgvRevenueDay_Month";
            this.dgvRevenueDay_Month.RowHeadersWidth = 51;
            this.dgvRevenueDay_Month.RowTemplate.Height = 24;
            this.dgvRevenueDay_Month.Size = new System.Drawing.Size(1014, 493);
            this.dgvRevenueDay_Month.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "IdStaff";
            this.Column1.HeaderText = "IdStaff";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "IdProduct";
            this.Column2.HeaderText = "IdProduct";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "NameProduct";
            this.Column3.HeaderText = "Name";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Size";
            this.Column4.HeaderText = "Size";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 70;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Quantity";
            this.Column5.HeaderText = "Quantity";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 90;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Type";
            this.Column8.HeaderText = "Type";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Price";
            this.Column6.HeaderText = "Price";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "DayOrder";
            this.Column7.HeaderText = "DayOrder";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 165;
            // 
            // cbbFinding
            // 
            this.cbbFinding.FormattingEnabled = true;
            this.cbbFinding.Items.AddRange(new object[] {
            "ID"});
            this.cbbFinding.Location = new System.Drawing.Point(462, 116);
            this.cbbFinding.Name = "cbbFinding";
            this.cbbFinding.Size = new System.Drawing.Size(121, 31);
            this.cbbFinding.TabIndex = 1;
            this.cbbFinding.Text = "ID";
            this.cbbFinding.SelectedIndexChanged += new System.EventHandler(this.cbbFinding_SelectedIndexChanged);
            // 
            // cbbChoiceFind
            // 
            this.cbbChoiceFind.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbChoiceFind.FormattingEnabled = true;
            this.cbbChoiceFind.Items.AddRange(new object[] {
            "Oneday",
            "Month",
            "Year"});
            this.cbbChoiceFind.Location = new System.Drawing.Point(242, 6);
            this.cbbChoiceFind.Name = "cbbChoiceFind";
            this.cbbChoiceFind.Size = new System.Drawing.Size(121, 33);
            this.cbbChoiceFind.TabIndex = 1;
            this.cbbChoiceFind.Text = "Oneday";
            this.cbbChoiceFind.SelectedIndexChanged += new System.EventHandler(this.cbbChoiceFind_SelectedIndexChanged);
            // 
            // tabControlRevenue
            // 
            this.tabControlRevenue.Controls.Add(this.tabPageRevenueMonths);
            this.tabControlRevenue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlRevenue.Location = new System.Drawing.Point(0, 12);
            this.tabControlRevenue.Name = "tabControlRevenue";
            this.tabControlRevenue.SelectedIndex = 0;
            this.tabControlRevenue.Size = new System.Drawing.Size(1028, 686);
            this.tabControlRevenue.TabIndex = 0;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.btnLoad.FlatAppearance.BorderSize = 0;
            this.btnLoad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Location = new System.Drawing.Point(445, 7);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(63, 27);
            this.btnLoad.TabIndex = 14;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // frmRevenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 698);
            this.Controls.Add(this.tabControlRevenue);
            this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmRevenue";
            this.Text = "frmRevenue";
            this.Load += new System.EventHandler(this.frmRevenue_Load);
            this.tabPageRevenueMonths.ResumeLayout(false);
            this.tabPageRevenueMonths.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevenueDay_Month)).EndInit();
            this.tabControlRevenue.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPageRevenueMonths;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DateTimePicker dtpTabMonthChoice;
        private System.Windows.Forms.Label lblTotalMoney;
        private System.Windows.Forms.Label lblNameTotal;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvRevenueDay_Month;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.ComboBox cbbFinding;
        private System.Windows.Forms.ComboBox cbbChoiceFind;
        private System.Windows.Forms.TabControl tabControlRevenue;
        private System.Windows.Forms.Button btnLoad;
    }
}