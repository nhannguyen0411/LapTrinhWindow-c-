using Lab04.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04
{
    public partial class frm : System.Windows.Forms.Form
    {
        public frm()
        {
            InitializeComponent();
        }

        DBProduct context = new DBProduct();
        private void Frm_Load(object sender, EventArgs e)
        {
            try
            {
                SetGridViewStyle(dataGridView);
                List<Invoice> listInvoice = context.Invoices.ToList();
                List<Order> listOrder = context.Orders.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void SetGridViewStyle(DataGridView dgview)
        {
            dgview.BorderStyle = BorderStyle.None;
            dgview.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgview.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgview.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgview.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgview.BackgroundColor = Color.White;
            dgview.EnableHeadersVisualStyles = false;
            dgview.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgview.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgview.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgview.AllowUserToDeleteRows = false;
            dgview.AllowUserToAddRows = false;
            dgview.AllowUserToOrderColumns = true;
            dgview.MultiSelect = false;
            dgview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void BindGrid(List<Invoice> listInvoice, List<Order> listOrder)
        {
            try
            {
                dataGridView.Rows.Clear();
                var JoinResult = (from p in listInvoice.AsEnumerable()
                                  join t in listOrder.AsEnumerable()
                                  on p.InvoiceNo equals t.InvoiceNo
                                  select new
                                  {
                                      InvoiceNo = p.InvoiceNo,
                                      OrderDate = p.OrderDate,
                                      DeliveryDate = p.DeliveryDate,
                                      Quantity = t.Quantity,
                                      Price = t.Price
                                  }).ToList();

                var obj = from s in JoinResult
                          group s by new { s.InvoiceNo, s.OrderDate, s.DeliveryDate } into g
                          select new { g.Key.InvoiceNo, g.Key.OrderDate, g.Key.DeliveryDate, Sum = g.Sum(s => s.Price*s.Quantity) };
                var count = 1;

                foreach (var item in obj)
                {
                    int index = dataGridView.Rows.Add();
                    dataGridView.Rows[index].Cells[0].Value = count;
                    dataGridView.Rows[index].Cells[1].Value = item.InvoiceNo;
                    dataGridView.Rows[index].Cells[2].Value = item.OrderDate.ToShortDateString();
                    dataGridView.Rows[index].Cells[3].Value = item.DeliveryDate.ToShortDateString();
                    dataGridView.Rows[index].Cells[4].Value = item.Sum;
                    count++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DateTu_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (dateTu.Value > dateDen.Value)
                {
                    throw new Exception("THỜI GIAN BỊ SAI!!!");
                }

                List<Invoice> listInvoice = context.Invoices.ToList();
                List<Order> listOrder = context.Orders.ToList();
                List<Invoice> newList = new List<Invoice>();

                foreach (var item in listInvoice)
                {
                    if (item.DeliveryDate.Date <= dateDen.Value.Date && item.DeliveryDate.Date >= dateTu.Value.Date)
                    {
                        newList.Add(item);
                    }
                }

                BindGrid(newList, listOrder);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DateDen_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (dateDen.Value < dateTu.Value)
                {
                    throw new Exception("THỜI GIAN BỊ SAI!!!");
                }

                List<Invoice> listInvoice = context.Invoices.ToList();
                List<Order> listOrder = context.Orders.ToList();
                List<Invoice> newList = new List<Invoice>();

                foreach (var item in listInvoice)
                {
                    if (item.DeliveryDate.Date <= dateDen.Value.Date && item.DeliveryDate.Date >= dateTu.Value.Date)
                    {
                        newList.Add(item);
                    }
                }

                BindGrid(newList, listOrder);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ChkBox_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chkBox.CheckState == CheckState.Checked)
                {
                    var time = DateTime.Today;

                    List<Invoice> listInvoice = context.Invoices.ToList();
                    List<Order> listOrder = context.Orders.ToList();
                    List<Invoice> newList = new List<Invoice>();

                    foreach (var item in listInvoice)
                    {
                        if (item.DeliveryDate.Date.Month == time.Month)
                        {
                            newList.Add(item);
                        }
                    }

                    dateTu.Value = new DateTime(time.Year, time.Month, 1);
                    dateDen.Value = dateTu.Value.AddMonths(1).AddDays(-1);
                    BindGrid(newList, listOrder);
                    dateTu.Enabled = false;
                    dateDen.Enabled = false;
                }
                else
                {
                    dateTu.Enabled = true;
                    dateDen.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int sum = 0;

                for (int i = 0; i < dataGridView.Rows.Count; ++i)
                {
                    sum += Convert.ToInt32(dataGridView.Rows[i].Cells[4].Value);
                }

                txtTotalPrice.Text = sum.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
