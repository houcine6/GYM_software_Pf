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
    public partial class Form1 : Form
    {
        public bool isCollapsed;
        public Form1()
        {
            InitializeComponent();
        }

        public void loadForm(object Form)
        {
            if(this.mainPanel.Controls.Count > 0)
            {
                this.mainPanel.Controls.RemoveAt(0);
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag = f;
            f.Show();
        }

        private void button_exit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clientsDBv1DataSet.ClientsV1' table. You can move, or remove it, as needed.
            this.clientsV2TableAdapter.Fill(this.clientsDBv2DataSet.ClientsV2);
            
            loadForm(new HomeScreenForm());
            timer1.Start();
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        /*
        private void button4_Click(object sender, EventArgs e)
        {
            loadForm(new NewItemForm());
        }
        */
        private void button3_Click(object sender, EventArgs e)
        {
            loadForm(new HomeScreenForm());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadForm(new NewClientForm());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            loadForm(new ClientListForm());
        }
        /*
        private void button6_Click(object sender, EventArgs e)
        {
            loadForm(new NewStaffForm());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            loadForm(new SalesForm());
        }
        */
        private void panel_MENU_Paint(object sender, PaintEventArgs e)
        {
            // TODO: This line of code loads data into the 'clientsDBv1DataSet.ClientsV1' table. You can move, or remove it, as needed.
            this.clientsV2TableAdapter.Fill(this.clientsDBv2DataSet.ClientsV2);

        }
        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            //Console.WriteLine("i= : " + i);
            if(i == 60)
            {
                // TODO: This line of code loads data into the 'clientsDBv1DataSet.ClientsV1' table. You can move, or remove it, as needed.
                this.clientsV2TableAdapter.Fill(this.clientsDBv2DataSet.ClientsV2);

                i = 0;
            }
        }
    }
}
