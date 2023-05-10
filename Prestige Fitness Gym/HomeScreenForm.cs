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
    public partial class HomeScreenForm : Form
    {
        public HomeScreenForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3_Clock1_HomeScreen.Text = DateTime.Now.ToString("d");
            label1.Text = DateTime.Now.ToString("T");
        }

        private void HomeScreenForm_Load(object sender, EventArgs e)
        {

            timer1.Start();
        }

        private void panel1_HomeScreen_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
