namespace INVOICE
{
    partial class INVOICES
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(INVOICES));
            label1 = new Label();
            label2 = new Label();
            textnum = new TextBox();
            textDate = new TextBox();
            label3 = new Label();
            txtname = new TextBox();
            label4 = new Label();
            label5 = new Label();
            cbxitem = new ComboBox();
            txtprice = new TextBox();
            label6 = new Label();
            txtqty = new TextBox();
            label7 = new Label();
            dgvinvoice = new DataGridView();
            colitem = new DataGridViewTextBoxColumn();
            colqty = new DataGridViewTextBoxColumn();
            colprice = new DataGridViewTextBoxColumn();
            coltotal = new DataGridViewTextBoxColumn();
            txtTotal = new TextBox();
            label8 = new Label();
            btnAdd = new Button();
            btnPrint = new Button();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)dgvinvoice).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(265, 28);
            label1.Name = "label1";
            label1.Size = new Size(243, 35);
            label1.TabIndex = 0;
            label1.Text = "Invoice System";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(29, 95);
            label2.Name = "label2";
            label2.Size = new Size(135, 21);
            label2.TabIndex = 1;
            label2.Text = "Invoice number:";
            label2.Click += label2_Click;
            // 
            // textnum
            // 
            textnum.Location = new Point(170, 91);
            textnum.Name = "textnum";
            textnum.Size = new Size(239, 25);
            textnum.TabIndex = 2;
            textnum.Text = "000123";
            textnum.TextChanged += textBox1_TextChanged;
            // 
            // textDate
            // 
            textDate.BackColor = SystemColors.ButtonHighlight;
            textDate.Location = new Point(522, 91);
            textDate.Name = "textDate";
            textDate.ReadOnly = true;
            textDate.Size = new Size(243, 25);
            textDate.TabIndex = 4;
            textDate.TextChanged += textDate_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(466, 95);
            label3.Name = "label3";
            label3.Size = new Size(50, 21);
            label3.TabIndex = 3;
            label3.Text = "Date:";
            // 
            // txtname
            // 
            txtname.Location = new Point(169, 136);
            txtname.Name = "txtname";
            txtname.Size = new Size(596, 25);
            txtname.TabIndex = 6;
            txtname.TextChanged += txtname_TextChanged;
            txtname.KeyDown += txtname_KeyDown;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(29, 136);
            label4.Name = "label4";
            label4.Size = new Size(134, 21);
            label4.TabIndex = 5;
            label4.Text = "Customer name:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(29, 185);
            label5.Name = "label5";
            label5.Size = new Size(49, 21);
            label5.TabIndex = 7;
            label5.Text = "Item:";
            // 
            // cbxitem
            // 
            cbxitem.FormattingEnabled = true;
            cbxitem.Location = new Point(170, 181);
            cbxitem.Name = "cbxitem";
            cbxitem.Size = new Size(239, 25);
            cbxitem.TabIndex = 8;
            cbxitem.SelectedIndexChanged += cbxitem_SelectedIndexChanged;
            cbxitem.KeyDown += cbxitem_KeyDown;
            // 
            // txtprice
            // 
            txtprice.Location = new Point(170, 222);
            txtprice.Name = "txtprice";
            txtprice.Size = new Size(239, 25);
            txtprice.TabIndex = 10;
            txtprice.KeyDown += txtprice_KeyDown;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(29, 226);
            label6.Name = "label6";
            label6.Size = new Size(52, 21);
            label6.TabIndex = 9;
            label6.Text = "Price:";
            // 
            // txtqty
            // 
            txtqty.Location = new Point(549, 185);
            txtqty.Name = "txtqty";
            txtqty.Size = new Size(216, 25);
            txtqty.TabIndex = 12;
            txtqty.KeyDown += txtqty_KeyDown;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(462, 185);
            label7.Name = "label7";
            label7.Size = new Size(81, 21);
            label7.TabIndex = 11;
            label7.Text = "Quantity:";
            // 
            // dgvinvoice
            // 
            dgvinvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvinvoice.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvinvoice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvinvoice.Columns.AddRange(new DataGridViewColumn[] { colitem, colqty, colprice, coltotal });
            dgvinvoice.Location = new Point(3, 302);
            dgvinvoice.Name = "dgvinvoice";
            dgvinvoice.Size = new Size(796, 205);
            dgvinvoice.TabIndex = 13;
            dgvinvoice.CellContentClick += dataGridView1_CellContentClick;
            // 
            // colitem
            // 
            colitem.HeaderText = "Item";
            colitem.Name = "colitem";
            // 
            // colqty
            // 
            colqty.HeaderText = "Quantity";
            colqty.Name = "colqty";
            // 
            // colprice
            // 
            colprice.HeaderText = "Price";
            colprice.Name = "colprice";
            // 
            // coltotal
            // 
            coltotal.HeaderText = "Total";
            coltotal.Name = "coltotal";
            // 
            // txtTotal
            // 
            txtTotal.BackColor = SystemColors.ButtonHighlight;
            txtTotal.Location = new Point(462, 251);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(81, 25);
            txtTotal.TabIndex = 15;
            txtTotal.TextChanged += textBox5_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(476, 222);
            label8.Name = "label8";
            label8.Size = new Size(56, 21);
            label8.TabIndex = 14;
            label8.Text = "TOTAL";
            // 
            // btnAdd
            // 
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.Location = new Point(574, 243);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 39);
            btnAdd.TabIndex = 16;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnPrint
            // 
            btnPrint.Cursor = Cursors.Hand;
            btnPrint.FlatStyle = FlatStyle.Popup;
            btnPrint.Location = new Point(664, 243);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(75, 39);
            btnPrint.TabIndex = 17;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            printPreviewDialog1.Load += printPreviewDialog1_Load;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // INVOICES
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 509);
            Controls.Add(btnPrint);
            Controls.Add(btnAdd);
            Controls.Add(txtTotal);
            Controls.Add(label8);
            Controls.Add(dgvinvoice);
            Controls.Add(txtqty);
            Controls.Add(label7);
            Controls.Add(txtprice);
            Controls.Add(label6);
            Controls.Add(cbxitem);
            Controls.Add(label5);
            Controls.Add(txtname);
            Controls.Add(label4);
            Controls.Add(textDate);
            Controls.Add(label3);
            Controls.Add(textnum);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "INVOICES";
            Text = "INVOICE FORM";
            Load += INVOICES_Load;
            MouseDown += INVOICES_MouseDown;
            ((System.ComponentModel.ISupportInitialize)dgvinvoice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textnum;
        private TextBox textDate;
        private Label label3;
        private TextBox txtname;
        private Label label4;
        private Label label5;
        private ComboBox cbxitem;
        private TextBox txtprice;
        private Label label6;
        private TextBox txtqty;
        private Label label7;
        private DataGridView dgvinvoice;
        private DataGridViewTextBoxColumn colitem;
        private DataGridViewTextBoxColumn colqty;
        private DataGridViewTextBoxColumn colprice;
        private DataGridViewTextBoxColumn coltotal;
        private TextBox txtTotal;
        private Label label8;
        private Button btnAdd;
        private Button btnPrint;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}
