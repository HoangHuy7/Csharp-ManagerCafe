
namespace ManagerCafe.GUI
{
    partial class frmOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrder));
            this.txtQuantity_Order = new System.Windows.Forms.TextBox();
            this.txtMoneyReceived_Order = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnADDOrder = new System.Windows.Forms.Button();
            this.btnRemoveOrder = new System.Windows.Forms.Button();
            this.dgvListProduct_Order = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblQuantity_Order = new System.Windows.Forms.Label();
            this.lblTypeProduct = new System.Windows.Forms.Label();
            this.lblProductDetail = new System.Windows.Forms.Label();
            this.lblSize_Order = new System.Windows.Forms.Label();
            this.lblTotalPrice_Order = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalMoney_ExcessCash_Order = new System.Windows.Forms.Label();
            this.lblMoneyReceived_Order = new System.Windows.Forms.Label();
            this.lblTotalMoney_Order = new System.Windows.Forms.Label();
            this.lblExcessCash_Order = new System.Windows.Forms.Label();
            this.cbbTypeOrder = new System.Windows.Forms.ComboBox();
            this.cbbProduct_Order = new System.Windows.Forms.ComboBox();
            this.btnPrintBillOrder = new System.Windows.Forms.Button();
            this.btnPayOrder = new System.Windows.Forms.Button();
            this.rdbSizeL = new System.Windows.Forms.RadioButton();
            this.rdbSizeS = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grbOrder = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblStaff3 = new System.Windows.Forms.Label();
            this.lblStaff2 = new System.Windows.Forms.Label();
            this.lblTimeStart = new System.Windows.Forms.Label();
            this.lblDayWorking = new System.Windows.Forms.Label();
            this.lblIDStaff = new System.Windows.Forms.Label();
            this.lblStaff1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListProduct_Order)).BeginInit();
            this.grbOrder.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtQuantity_Order
            // 
            this.txtQuantity_Order.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtQuantity_Order.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuantity_Order.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity_Order.Location = new System.Drawing.Point(467, 120);
            this.txtQuantity_Order.Name = "txtQuantity_Order";
            this.txtQuantity_Order.Size = new System.Drawing.Size(75, 27);
            this.txtQuantity_Order.TabIndex = 16;
            // 
            // txtMoneyReceived_Order
            // 
            this.txtMoneyReceived_Order.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtMoneyReceived_Order.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMoneyReceived_Order.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoneyReceived_Order.Location = new System.Drawing.Point(346, 498);
            this.txtMoneyReceived_Order.Name = "txtMoneyReceived_Order";
            this.txtMoneyReceived_Order.Size = new System.Drawing.Size(163, 27);
            this.txtMoneyReceived_Order.TabIndex = 16;
            this.txtMoneyReceived_Order.TextChanged += new System.EventHandler(this.txtMoneyReceived_Order_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(346, 526);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(163, 2);
            this.panel2.TabIndex = 21;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Black;
            this.panel8.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel8.Location = new System.Drawing.Point(467, 148);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(75, 2);
            this.panel8.TabIndex = 21;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Black;
            this.panel9.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel9.Location = new System.Drawing.Point(709, 459);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(2, 131);
            this.panel9.TabIndex = 21;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Black;
            this.panel10.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel10.Location = new System.Drawing.Point(709, 62);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(2, 131);
            this.panel10.TabIndex = 21;
            // 
            // btnADDOrder
            // 
            this.btnADDOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(188)))), ((int)(((byte)(190)))));
            this.btnADDOrder.FlatAppearance.BorderSize = 0;
            this.btnADDOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnADDOrder.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADDOrder.ForeColor = System.Drawing.Color.Black;
            this.btnADDOrder.Image = ((System.Drawing.Image)(resources.GetObject("btnADDOrder.Image")));
            this.btnADDOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnADDOrder.Location = new System.Drawing.Point(764, 69);
            this.btnADDOrder.Name = "btnADDOrder";
            this.btnADDOrder.Size = new System.Drawing.Size(108, 43);
            this.btnADDOrder.TabIndex = 14;
            this.btnADDOrder.Text = "ADD";
            this.btnADDOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnADDOrder.UseVisualStyleBackColor = false;
            this.btnADDOrder.Click += new System.EventHandler(this.btnADDOrder_Click);
            // 
            // btnRemoveOrder
            // 
            this.btnRemoveOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(188)))), ((int)(((byte)(190)))));
            this.btnRemoveOrder.FlatAppearance.BorderSize = 0;
            this.btnRemoveOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveOrder.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveOrder.ForeColor = System.Drawing.Color.Black;
            this.btnRemoveOrder.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveOrder.Image")));
            this.btnRemoveOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemoveOrder.Location = new System.Drawing.Point(764, 126);
            this.btnRemoveOrder.Name = "btnRemoveOrder";
            this.btnRemoveOrder.Size = new System.Drawing.Size(108, 43);
            this.btnRemoveOrder.TabIndex = 16;
            this.btnRemoveOrder.Text = "Delete";
            this.btnRemoveOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveOrder.UseVisualStyleBackColor = false;
            this.btnRemoveOrder.Click += new System.EventHandler(this.btnRemoveOrder_Click);
            // 
            // dgvListProduct_Order
            // 
            this.dgvListProduct_Order.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.dgvListProduct_Order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListProduct_Order.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvListProduct_Order.Location = new System.Drawing.Point(103, 201);
            this.dgvListProduct_Order.Name = "dgvListProduct_Order";
            this.dgvListProduct_Order.RowHeadersWidth = 51;
            this.dgvListProduct_Order.RowTemplate.Height = 24;
            this.dgvListProduct_Order.Size = new System.Drawing.Size(769, 219);
            this.dgvListProduct_Order.TabIndex = 33;
            this.dgvListProduct_Order.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListProduct_Order_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "IdPD";
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 120;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "NamePD";
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Size";
            this.Column3.HeaderText = "Size";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 70;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Quantity";
            this.Column4.HeaderText = "Quantity";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Price";
            this.Column5.HeaderText = "Price";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Type";
            this.Column6.HeaderText = "Type";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // lblQuantity_Order
            // 
            this.lblQuantity_Order.AutoSize = true;
            this.lblQuantity_Order.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity_Order.Location = new System.Drawing.Point(463, 80);
            this.lblQuantity_Order.Name = "lblQuantity_Order";
            this.lblQuantity_Order.Size = new System.Drawing.Size(94, 22);
            this.lblQuantity_Order.TabIndex = 34;
            this.lblQuantity_Order.Text = "Số lượng:";
            // 
            // lblTypeProduct
            // 
            this.lblTypeProduct.AutoSize = true;
            this.lblTypeProduct.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeProduct.Location = new System.Drawing.Point(99, 74);
            this.lblTypeProduct.Name = "lblTypeProduct";
            this.lblTypeProduct.Size = new System.Drawing.Size(128, 22);
            this.lblTypeProduct.TabIndex = 34;
            this.lblTypeProduct.Text = "Type Product:";
            // 
            // lblProductDetail
            // 
            this.lblProductDetail.AutoSize = true;
            this.lblProductDetail.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductDetail.Location = new System.Drawing.Point(99, 137);
            this.lblProductDetail.Name = "lblProductDetail";
            this.lblProductDetail.Size = new System.Drawing.Size(136, 22);
            this.lblProductDetail.TabIndex = 34;
            this.lblProductDetail.Text = "Name Product:";
            // 
            // lblSize_Order
            // 
            this.lblSize_Order.AutoSize = true;
            this.lblSize_Order.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize_Order.Location = new System.Drawing.Point(35, 15);
            this.lblSize_Order.Name = "lblSize_Order";
            this.lblSize_Order.Size = new System.Drawing.Size(52, 22);
            this.lblSize_Order.TabIndex = 34;
            this.lblSize_Order.Text = "Size:";
            // 
            // lblTotalPrice_Order
            // 
            this.lblTotalPrice_Order.AutoSize = true;
            this.lblTotalPrice_Order.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice_Order.Location = new System.Drawing.Point(99, 459);
            this.lblTotalPrice_Order.Name = "lblTotalPrice_Order";
            this.lblTotalPrice_Order.Size = new System.Drawing.Size(85, 22);
            this.lblTotalPrice_Order.TabIndex = 34;
            this.lblTotalPrice_Order.Text = "Total Bill:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(-222, 837);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "Giá:";
            // 
            // lblTotalMoney_ExcessCash_Order
            // 
            this.lblTotalMoney_ExcessCash_Order.AutoSize = true;
            this.lblTotalMoney_ExcessCash_Order.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalMoney_ExcessCash_Order.Location = new System.Drawing.Point(342, 548);
            this.lblTotalMoney_ExcessCash_Order.Name = "lblTotalMoney_ExcessCash_Order";
            this.lblTotalMoney_ExcessCash_Order.Size = new System.Drawing.Size(21, 22);
            this.lblTotalMoney_ExcessCash_Order.TabIndex = 34;
            this.lblTotalMoney_ExcessCash_Order.Text = "0";
            // 
            // lblMoneyReceived_Order
            // 
            this.lblMoneyReceived_Order.AutoSize = true;
            this.lblMoneyReceived_Order.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoneyReceived_Order.Location = new System.Drawing.Point(99, 506);
            this.lblMoneyReceived_Order.Name = "lblMoneyReceived_Order";
            this.lblMoneyReceived_Order.Size = new System.Drawing.Size(157, 22);
            this.lblMoneyReceived_Order.TabIndex = 34;
            this.lblMoneyReceived_Order.Text = "Money Received:";
            // 
            // lblTotalMoney_Order
            // 
            this.lblTotalMoney_Order.AutoSize = true;
            this.lblTotalMoney_Order.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalMoney_Order.Location = new System.Drawing.Point(342, 459);
            this.lblTotalMoney_Order.Name = "lblTotalMoney_Order";
            this.lblTotalMoney_Order.Size = new System.Drawing.Size(21, 22);
            this.lblTotalMoney_Order.TabIndex = 34;
            this.lblTotalMoney_Order.Text = "0";
            // 
            // lblExcessCash_Order
            // 
            this.lblExcessCash_Order.AutoSize = true;
            this.lblExcessCash_Order.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExcessCash_Order.Location = new System.Drawing.Point(99, 548);
            this.lblExcessCash_Order.Name = "lblExcessCash_Order";
            this.lblExcessCash_Order.Size = new System.Drawing.Size(160, 22);
            this.lblExcessCash_Order.TabIndex = 34;
            this.lblExcessCash_Order.Text = "Money Exchange:";
            // 
            // cbbTypeOrder
            // 
            this.cbbTypeOrder.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTypeOrder.FormattingEnabled = true;
            this.cbbTypeOrder.Location = new System.Drawing.Point(238, 70);
            this.cbbTypeOrder.Name = "cbbTypeOrder";
            this.cbbTypeOrder.Size = new System.Drawing.Size(200, 29);
            this.cbbTypeOrder.TabIndex = 35;
            this.cbbTypeOrder.SelectedIndexChanged += new System.EventHandler(this.cbbTypeOrder_SelectedIndexChanged);
            // 
            // cbbProduct_Order
            // 
            this.cbbProduct_Order.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbProduct_Order.FormattingEnabled = true;
            this.cbbProduct_Order.Location = new System.Drawing.Point(238, 133);
            this.cbbProduct_Order.Name = "cbbProduct_Order";
            this.cbbProduct_Order.Size = new System.Drawing.Size(200, 29);
            this.cbbProduct_Order.TabIndex = 35;
            this.cbbProduct_Order.SelectedIndexChanged += new System.EventHandler(this.cbbProduct_Order_SelectedIndexChanged);
            // 
            // btnPrintBillOrder
            // 
            this.btnPrintBillOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(188)))), ((int)(((byte)(190)))));
            this.btnPrintBillOrder.FlatAppearance.BorderSize = 0;
            this.btnPrintBillOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintBillOrder.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintBillOrder.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintBillOrder.Image")));
            this.btnPrintBillOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrintBillOrder.Location = new System.Drawing.Point(764, 537);
            this.btnPrintBillOrder.Name = "btnPrintBillOrder";
            this.btnPrintBillOrder.Size = new System.Drawing.Size(108, 43);
            this.btnPrintBillOrder.TabIndex = 36;
            this.btnPrintBillOrder.Text = "Bill";
            this.btnPrintBillOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrintBillOrder.UseVisualStyleBackColor = false;
            this.btnPrintBillOrder.Click += new System.EventHandler(this.btnDeletedgv_Click);
            // 
            // btnPayOrder
            // 
            this.btnPayOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(188)))), ((int)(((byte)(190)))));
            this.btnPayOrder.FlatAppearance.BorderSize = 0;
            this.btnPayOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayOrder.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayOrder.Image = ((System.Drawing.Image)(resources.GetObject("btnPayOrder.Image")));
            this.btnPayOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPayOrder.Location = new System.Drawing.Point(764, 462);
            this.btnPayOrder.Name = "btnPayOrder";
            this.btnPayOrder.Size = new System.Drawing.Size(108, 43);
            this.btnPayOrder.TabIndex = 36;
            this.btnPayOrder.Text = "Pay";
            this.btnPayOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayOrder.UseVisualStyleBackColor = false;
            this.btnPayOrder.Click += new System.EventHandler(this.btnPayOrder_Click);
            // 
            // rdbSizeL
            // 
            this.rdbSizeL.AutoSize = true;
            this.rdbSizeL.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbSizeL.Location = new System.Drawing.Point(72, 56);
            this.rdbSizeL.Name = "rdbSizeL";
            this.rdbSizeL.Size = new System.Drawing.Size(42, 26);
            this.rdbSizeL.TabIndex = 37;
            this.rdbSizeL.Text = "L";
            this.rdbSizeL.UseVisualStyleBackColor = true;
            // 
            // rdbSizeS
            // 
            this.rdbSizeS.AutoSize = true;
            this.rdbSizeS.Checked = true;
            this.rdbSizeS.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbSizeS.Location = new System.Drawing.Point(20, 56);
            this.rdbSizeS.Name = "rdbSizeS";
            this.rdbSizeS.Size = new System.Drawing.Size(44, 26);
            this.rdbSizeS.TabIndex = 37;
            this.rdbSizeS.TabStop = true;
            this.rdbSizeS.Text = "S";
            this.rdbSizeS.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(463, 551);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 22);
            this.label1.TabIndex = 38;
            this.label1.Text = "vnd";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(463, 462);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 22);
            this.label2.TabIndex = 38;
            this.label2.Text = "vnd";
            // 
            // grbOrder
            // 
            this.grbOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.grbOrder.Controls.Add(this.groupBox2);
            this.grbOrder.Controls.Add(this.groupBox1);
            this.grbOrder.Controls.Add(this.btnPrintBillOrder);
            this.grbOrder.Controls.Add(this.btnPayOrder);
            this.grbOrder.Controls.Add(this.btnRemoveOrder);
            this.grbOrder.Controls.Add(this.label2);
            this.grbOrder.Controls.Add(this.label1);
            this.grbOrder.Controls.Add(this.cbbProduct_Order);
            this.grbOrder.Controls.Add(this.cbbTypeOrder);
            this.grbOrder.Controls.Add(this.lblExcessCash_Order);
            this.grbOrder.Controls.Add(this.lblTotalMoney_Order);
            this.grbOrder.Controls.Add(this.lblMoneyReceived_Order);
            this.grbOrder.Controls.Add(this.lblTotalMoney_ExcessCash_Order);
            this.grbOrder.Controls.Add(this.label3);
            this.grbOrder.Controls.Add(this.lblTotalPrice_Order);
            this.grbOrder.Controls.Add(this.lblProductDetail);
            this.grbOrder.Controls.Add(this.lblTypeProduct);
            this.grbOrder.Controls.Add(this.lblQuantity_Order);
            this.grbOrder.Controls.Add(this.dgvListProduct_Order);
            this.grbOrder.Controls.Add(this.btnADDOrder);
            this.grbOrder.Controls.Add(this.panel10);
            this.grbOrder.Controls.Add(this.panel9);
            this.grbOrder.Controls.Add(this.panel8);
            this.grbOrder.Controls.Add(this.panel2);
            this.grbOrder.Controls.Add(this.txtMoneyReceived_Order);
            this.grbOrder.Controls.Add(this.txtQuantity_Order);
            this.grbOrder.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbOrder.Location = new System.Drawing.Point(27, 12);
            this.grbOrder.Name = "grbOrder";
            this.grbOrder.Size = new System.Drawing.Size(1347, 670);
            this.grbOrder.TabIndex = 37;
            this.grbOrder.TabStop = false;
            this.grbOrder.Text = "Order";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbSizeS);
            this.groupBox1.Controls.Add(this.rdbSizeL);
            this.groupBox1.Controls.Add(this.lblSize_Order);
            this.groupBox1.Location = new System.Drawing.Point(563, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(124, 97);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(35, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(35, 430);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(210, 2);
            this.panel5.TabIndex = 48;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(35, 329);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 2);
            this.panel1.TabIndex = 49;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(35, 243);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 2);
            this.panel3.TabIndex = 50;
            // 
            // lblStaff3
            // 
            this.lblStaff3.AutoSize = true;
            this.lblStaff3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaff3.Location = new System.Drawing.Point(29, 392);
            this.lblStaff3.Name = "lblStaff3";
            this.lblStaff3.Size = new System.Drawing.Size(251, 35);
            this.lblStaff3.TabIndex = 42;
            this.lblStaff3.Text = "Thời gian bắt đầu:";
            // 
            // lblStaff2
            // 
            this.lblStaff2.AutoSize = true;
            this.lblStaff2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaff2.Location = new System.Drawing.Point(29, 291);
            this.lblStaff2.Name = "lblStaff2";
            this.lblStaff2.Size = new System.Drawing.Size(202, 35);
            this.lblStaff2.TabIndex = 43;
            this.lblStaff2.Text = "Ngày làm việc:";
            // 
            // lblTimeStart
            // 
            this.lblTimeStart.AutoSize = true;
            this.lblTimeStart.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeStart.Location = new System.Drawing.Point(31, 446);
            this.lblTimeStart.Name = "lblTimeStart";
            this.lblTimeStart.Size = new System.Drawing.Size(154, 22);
            this.lblTimeStart.TabIndex = 45;
            this.lblTimeStart.Text = "Thời gian bắt đầu:";
            // 
            // lblDayWorking
            // 
            this.lblDayWorking.AutoSize = true;
            this.lblDayWorking.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDayWorking.Location = new System.Drawing.Point(31, 343);
            this.lblDayWorking.Name = "lblDayWorking";
            this.lblDayWorking.Size = new System.Drawing.Size(130, 22);
            this.lblDayWorking.TabIndex = 46;
            this.lblDayWorking.Text = "Ngày làm việc:";
            // 
            // lblIDStaff
            // 
            this.lblIDStaff.AutoSize = true;
            this.lblIDStaff.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDStaff.Location = new System.Drawing.Point(31, 257);
            this.lblIDStaff.Name = "lblIDStaff";
            this.lblIDStaff.Size = new System.Drawing.Size(30, 22);
            this.lblIDStaff.TabIndex = 47;
            this.lblIDStaff.Text = "ID";
            // 
            // lblStaff1
            // 
            this.lblStaff1.AutoSize = true;
            this.lblStaff1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaff1.Location = new System.Drawing.Point(29, 205);
            this.lblStaff1.Name = "lblStaff1";
            this.lblStaff1.Size = new System.Drawing.Size(189, 35);
            this.lblStaff1.TabIndex = 44;
            this.lblStaff1.Text = "ID nhân viên:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel5);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.lblStaff3);
            this.groupBox2.Controls.Add(this.lblStaff2);
            this.groupBox2.Controls.Add(this.lblTimeStart);
            this.groupBox2.Controls.Add(this.lblDayWorking);
            this.groupBox2.Controls.Add(this.lblIDStaff);
            this.groupBox2.Controls.Add(this.lblStaff1);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(939, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(333, 559);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Staff";
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(158)))), ((int)(((byte)(160)))));
            this.ClientSize = new System.Drawing.Size(1412, 733);
            this.Controls.Add(this.grbOrder);
            this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOrder";
            this.Text = "frmOrder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmOrder_FormClosing);
            this.Load += new System.EventHandler(this.frmOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListProduct_Order)).EndInit();
            this.grbOrder.ResumeLayout(false);
            this.grbOrder.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtQuantity_Order;
        private System.Windows.Forms.TextBox txtMoneyReceived_Order;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnADDOrder;
        private System.Windows.Forms.Button btnRemoveOrder;
        private System.Windows.Forms.DataGridView dgvListProduct_Order;
        private System.Windows.Forms.Label lblQuantity_Order;
        private System.Windows.Forms.Label lblTypeProduct;
        private System.Windows.Forms.Label lblProductDetail;
        private System.Windows.Forms.Label lblSize_Order;
        private System.Windows.Forms.Label lblTotalPrice_Order;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalMoney_ExcessCash_Order;
        private System.Windows.Forms.Label lblMoneyReceived_Order;
        private System.Windows.Forms.Label lblTotalMoney_Order;
        private System.Windows.Forms.Label lblExcessCash_Order;
        private System.Windows.Forms.ComboBox cbbTypeOrder;
        private System.Windows.Forms.ComboBox cbbProduct_Order;
        private System.Windows.Forms.Button btnPrintBillOrder;
        private System.Windows.Forms.Button btnPayOrder;
        private System.Windows.Forms.RadioButton rdbSizeL;
        private System.Windows.Forms.RadioButton rdbSizeS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grbOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblStaff3;
        private System.Windows.Forms.Label lblStaff2;
        private System.Windows.Forms.Label lblTimeStart;
        private System.Windows.Forms.Label lblDayWorking;
        private System.Windows.Forms.Label lblIDStaff;
        private System.Windows.Forms.Label lblStaff1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}