using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BubbleTea.WinForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Fill data into adapter
            this.customersTableAdapter.Fill(this.customersDataSet.Customers);

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void RightClickCustomercontextMenuStrip_Opening(object sender, CancelEventArgs e)
        {

        }

        /// <summary>
        /// Grid view click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Handle right clicks
            if (e.Button == MouseButtons.Right)
            {
                //Identify row, col
                var row = e.RowIndex;
                var col = e.ColumnIndex;

                //Show context menu
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddCustomer form = new FormAddCustomer();
            form.ShowDialog();
        }
    }
}
