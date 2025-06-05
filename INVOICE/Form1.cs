using System.Windows.Forms;

namespace INVOICE
{
    public partial class INVOICES : Form
    {
        public INVOICES()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void INVOICES_Load(object sender, EventArgs e)
        {
            textDate.Text = DateTime.Now.ToString("yyyy/MM/dd");

            txtname.Select();
        }
        private void CalculateInvoiceTotal()
        {
            decimal finalTotal = 0;

            foreach (DataGridViewRow row in dgvinvoice.Rows)
            {
                if (!row.IsNewRow && row.Cells[3].Value != null)
                {
                    decimal rowTotal = Convert.ToDecimal(row.Cells[3].Value);
                    finalTotal += rowTotal;
                }
            }

            txtTotal.Text = finalTotal.ToString("0.00");
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textDate_TextChanged(object sender, EventArgs e)
        {
        }

        private void INVOICES_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                textDate.ContextMenuStrip = new ContextMenuStrip();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {


        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                cbxitem.Focus();

            }

        }

        private void cbxitem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtqty.Focus();
                txtqty.SelectAll();

            }

        }

        private void txtqty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtprice.Focus();
                txtprice.SelectAll();

            }


        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            ((Form)printPreviewDialog1).WindowState = FormWindowState.Maximized;
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float margin = 40;
            Font f = new Font("Arial", 18, FontStyle.Bold);
            string strNo = "#NO: " + textnum.Text;
            string strDate = "Date: " + textDate.Text;
            string strName = "Customer name: " + txtname.Text;
            SizeF fontsizeNo = e.Graphics.MeasureString(strNo, f);
            SizeF fontsizeDate = e.Graphics.MeasureString(strDate, f);
            SizeF fontsizeName = e.Graphics.MeasureString(strName, f);
            e.Graphics.DrawString(strNo, f, Brushes.Black, (e.PageBounds.Width - fontsizeNo.Width) / 2, margin);
            e.Graphics.DrawString(strDate, f, Brushes.Black, margin, margin + fontsizeNo.Height);
            e.Graphics.DrawString(strName, f, Brushes.Black, margin, margin + fontsizeNo.Height + fontsizeDate.Height);
            float preheight = margin + fontsizeNo.Height + fontsizeName.Height + fontsizeDate.Height;
            /////////////////////////////////////////////////////////////
            e.Graphics.DrawRectangle(Pens.Black, margin, preheight, e.PageBounds.Width - margin * 2, e.PageBounds.Height - preheight - margin);
            float colheight = 60;
            float col1width = 300;
            float col2width = 125 + col1width;
            float col3width = 125 + col2width;
            float col4width = 125 + col3width;
            float tableHeight = e.PageBounds.Height - preheight - margin;


            e.Graphics.DrawLine(Pens.Black, margin, preheight + colheight, e.PageBounds.Width - margin, preheight + colheight);
            e.Graphics.DrawLine(Pens.Black, margin + col1width, preheight, margin + col1width, preheight + tableHeight); // ?? ??? ?????? 1
            e.Graphics.DrawLine(Pens.Black, margin + col2width, preheight, margin + col2width, preheight + tableHeight); // ?? ??? ?????? 2
            e.Graphics.DrawLine(Pens.Black, margin + col3width, preheight, margin + col3width, preheight + tableHeight); // ?? ??? ?????? 3


            float textMargin = 5;
            string col1Title = "Item";
            string col2Title = "Quantity";
            string col3Title = "Price";
            string col4Title = "Total";

            e.Graphics.DrawString(col1Title, f, Brushes.Black, margin + textMargin, preheight + 15);
            e.Graphics.DrawString(col2Title, f, Brushes.Black, margin + col1width + textMargin, preheight + 15);
            e.Graphics.DrawString(col3Title, f, Brushes.Black, margin + col2width + textMargin, preheight + 15);
            e.Graphics.DrawString(col4Title, f, Brushes.Black, margin + col3width + textMargin, preheight + 15);
            ////////////////////////////////////////////////////////////////////////

         
            float currentY = preheight + colheight + 10;
            Font rowFont = new Font("Arial", 14, FontStyle.Regular);

            foreach (DataGridViewRow row in dgvinvoice.Rows)
            {
                if (row.IsNewRow || row.Cells[0].Value == null || row.Cells[1].Value == null || row.Cells[2].Value == null || row.Cells[3].Value == null)
                    continue;

                string item = row.Cells[0].Value.ToString();
                string qty = row.Cells[1].Value.ToString();
                string price = row.Cells[2].Value.ToString();
                string total = row.Cells[3].Value.ToString();

             
                e.Graphics.DrawString(item, rowFont, Brushes.Black, margin + textMargin, currentY);
                e.Graphics.DrawString(qty, rowFont, Brushes.Black, margin + col1width + textMargin, currentY);
                e.Graphics.DrawString(price, rowFont, Brushes.Black, margin + col2width + textMargin, currentY);
                e.Graphics.DrawString(total, rowFont, Brushes.Black, margin + col3width + textMargin, currentY);

                currentY += rowFont.Height + 10;

             
                e.Graphics.DrawLine(Pens.Gray, margin, currentY, e.PageBounds.Width - margin, currentY);
            }
         
            currentY += 10;
            Font totalFont = new Font("Arial", 16, FontStyle.Bold);
            string finalTotal = ("Total:"+ txtTotal.Text);
            e.Graphics.DrawString(finalTotal, totalFont, Brushes.Black, margin + col3width + textMargin, currentY + 10);  

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (cbxitem.Text != "" && txtqty.Text != "" && txtprice.Text != "")
            {
                string item = cbxitem.Text;
                int quantity = int.Parse(txtqty.Text);
                decimal price = decimal.Parse(txtprice.Text);
                decimal total = quantity * price;

                dgvinvoice.Rows.Add(item, quantity, price, total);
                CalculateInvoiceTotal();

                // تنظيف الحقول
                cbxitem.Text = "";
                txtqty.Text = "";
                txtprice.Text = "";

                cbxitem.Focus();
            }
            else
            {
                MessageBox.Show("من فضلك أدخل كل البيانات");
            }
        }

        private void cbxitem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtprice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnAdd.PerformClick();
                txtqty.SelectAll();

            }
        }
    }
}
