using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Management_System_2
{
    public partial class ItemsListForm : Form
    {
        public ItemsListForm()
        {
            InitializeComponent();
        }

        private void panel_ProductsList_Paint(object sender, PaintEventArgs e)
        {
            dynamic d = prdouctsV2KryptonDataGridView_NewProduct.Rows.Count;
            d = d - 1;
            kryptonLabel2_ProductsList.Text = "" + d + "";
        }

        private void searchproductKryptonTextBox_ProductsList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(searchproductKryptonTextBox_ProductsList.Text))
                {
                    itemsV1BindingSource.Filter = string.Format("[Item Name] LIKE '%" + searchproductKryptonTextBox_ProductsList.Text + "%'");
                }
                else
                {
                    itemsV1BindingSource.Filter = string.Empty;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3_ProductsList.Text = DateTime.Now.ToString("T");
        }

        private void ItemsListForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'itemsDBv1DataSet.ItemsV1' table. You can move, or remove it, as needed.
            this.itemsV1TableAdapter.Fill(this.itemsDBv1DataSet.ItemsV1);

            timer1.Start();
        }

        private void kryptonButton9_panel5_ProductsList_Click(object sender, EventArgs e)
        {
            searchproductKryptonTextBox_ProductsList.Text = "";
            itemsV1BindingSource.Filter = string.Format("[Item Name] LIKE '%" + searchproductKryptonTextBox_ProductsList.Text + "%'");
        }
    }
}
