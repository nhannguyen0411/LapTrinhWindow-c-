namespace Lab04
{
    partial class frm
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
            this.gbDonHang = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateDen = new System.Windows.Forms.DateTimePicker();
            this.dateTu = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.chkBox = new System.Windows.Forms.CheckBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.clmSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDelivery = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.gbDonHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDonHang
            // 
            this.gbDonHang.Controls.Add(this.label2);
            this.gbDonHang.Controls.Add(this.dateDen);
            this.gbDonHang.Controls.Add(this.dateTu);
            this.gbDonHang.Controls.Add(this.label1);
            this.gbDonHang.Controls.Add(this.chkBox);
            this.gbDonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDonHang.Location = new System.Drawing.Point(12, 12);
            this.gbDonHang.Name = "gbDonHang";
            this.gbDonHang.Size = new System.Drawing.Size(734, 112);
            this.gbDonHang.TabIndex = 0;
            this.gbDonHang.TabStop = false;
            this.gbDonHang.Text = "Thông tin đơn hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(300, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "~";
            // 
            // dateDen
            // 
            this.dateDen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDen.Location = new System.Drawing.Point(324, 71);
            this.dateDen.Name = "dateDen";
            this.dateDen.Size = new System.Drawing.Size(117, 23);
            this.dateDen.TabIndex = 2;
            this.dateDen.ValueChanged += new System.EventHandler(this.DateDen_ValueChanged);
            // 
            // dateTu
            // 
            this.dateTu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTu.Location = new System.Drawing.Point(177, 71);
            this.dateTu.Name = "dateTu";
            this.dateTu.Size = new System.Drawing.Size(117, 23);
            this.dateTu.TabIndex = 2;
            this.dateTu.ValueChanged += new System.EventHandler(this.DateTu_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thời gian giao hàng";
            // 
            // chkBox
            // 
            this.chkBox.AutoSize = true;
            this.chkBox.Location = new System.Drawing.Point(40, 31);
            this.chkBox.Name = "chkBox";
            this.chkBox.Size = new System.Drawing.Size(171, 21);
            this.chkBox.TabIndex = 0;
            this.chkBox.Text = "Xem tất cả trong tháng";
            this.chkBox.UseVisualStyleBackColor = true;
            this.chkBox.CheckedChanged += new System.EventHandler(this.ChkBox_CheckedChanged);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmSTT,
            this.clmHD,
            this.clmDate,
            this.clmDelivery,
            this.clmTotal});
            this.dataGridView.Location = new System.Drawing.Point(13, 131);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(733, 307);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellValueChanged);
            // 
            // clmSTT
            // 
            this.clmSTT.HeaderText = "STT";
            this.clmSTT.Name = "clmSTT";
            // 
            // clmHD
            // 
            this.clmHD.HeaderText = "Số HĐ";
            this.clmHD.Name = "clmHD";
            this.clmHD.Width = 150;
            // 
            // clmDate
            // 
            this.clmDate.HeaderText = "Ngày đặt";
            this.clmDate.Name = "clmDate";
            this.clmDate.Width = 150;
            // 
            // clmDelivery
            // 
            this.clmDelivery.HeaderText = "Ngày giao hàng";
            this.clmDelivery.Name = "clmDelivery";
            this.clmDelivery.Width = 150;
            // 
            // clmTotal
            // 
            this.clmTotal.HeaderText = "Thành tiền";
            this.clmTotal.Name = "clmTotal";
            this.clmTotal.Width = 140;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(539, 451);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tổng cộng";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(622, 452);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(124, 20);
            this.txtTotalPrice.TabIndex = 2;
            // 
            // frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 484);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.gbDonHang);
            this.Controls.Add(this.label3);
            this.Name = "frm";
            this.Text = "Form";
            this.Load += new System.EventHandler(this.Frm_Load);
            this.gbDonHang.ResumeLayout(false);
            this.gbDonHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDonHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateDen;
        private System.Windows.Forms.DateTimePicker dateTu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkBox;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDelivery;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotalPrice;
    }
}

