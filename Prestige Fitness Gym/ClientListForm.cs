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
    public partial class ClientListForm : Form
    {
        dynamic c;
        String Nom, Prenom, Telephone;
        public ClientListForm()
        {
            InitializeComponent();
        }

        private void clientsV2KryptonDataGridView_NewClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            clientsV2KryptonDataGridView_NewClient.CurrentRow.Selected = true;

            Nom = clientsV2KryptonDataGridView_NewClient.CurrentRow.Cells[1].Value.ToString();
            Prenom = clientsV2KryptonDataGridView_NewClient.CurrentRow.Cells[2].Value.ToString();
            Telephone = clientsV2KryptonDataGridView_NewClient.CurrentRow.Cells[6].Value.ToString();

            Console.WriteLine("n=" + Nom);
            Console.WriteLine("P=" + Prenom);
            Console.WriteLine("T=" + Telephone);
        }

        private void ClientListForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clientsDBv2DataSet.ClientsV2' table. You can move, or remove it, as needed.
            this.clientsV2TableAdapter.Fill(this.clientsDBv2DataSet.ClientsV2);

            timer1.Start();

            clientsV2KryptonDataGridView_NewClient.Visible = true;
            kryptonDataGridView1.Visible = false;
            kryptonLabel1.Visible = false;
            kryptonLabel2__ClientList.Visible = true;

            
        }
        
        private void panel_ClientList_Paint(object sender, PaintEventArgs e)
        {
            c = clientsV2KryptonDataGridView_NewClient.Rows.Count;
            c = c - 1;
            kryptonLabel2__ClientList.Text = "" + c + "";

            E = kryptonDataGridView1.Rows.Count;
            E = E - 1;
            kryptonLabel1.Text = "" + E + "";
        }

        private void searchKryptonTextBox__ClientList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(searchKryptonTextBox__ClientList.Text))
                {
                    clientsV2BindingSource.Filter = string.Format("[First Name] LIKE '%" + searchKryptonTextBox__ClientList.Text + "%' OR [Last Name] LIKE '%" + searchKryptonTextBox__ClientList.Text + "%'");
                }
                else
                {
                    clientsV2BindingSource.Filter = string.Empty;
                }
            }
        }

        private void kryptonButton9_ClientList_Click(object sender, EventArgs e)
        {
            searchKryptonTextBox__ClientList.Text = "";
            clientsV2BindingSource.Filter = string.Format("[First Name] LIKE '%" + searchKryptonTextBox__ClientList.Text + "%' OR [Last Name] LIKE '%" + searchKryptonTextBox__ClientList.Text + "%'");

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label6_timer_ClientList.Text = DateTime.Now.ToString("T");

        }

        DateTime today = DateTime.Today;
         
        int i = 0;
        String d,dd;
        String Fname;
        String Lname;
        String age;
        String tlfn;
        String email;
        String MP;
        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            for(i=0 ; i < clientsV2KryptonDataGridView_NewClient.Rows.Count -1 ; i++)
            {
                d = clientsV2KryptonDataGridView_NewClient.Rows[i].Cells[9].Value.ToString();
                d = Convert.ToDateTime(d).ToString("dd/MM/yyyy");
                dd = d;
                DateTime Exdate = Convert.ToDateTime(d);

                int daysDiff = ((TimeSpan)(Exdate - today)).Days;

                if (daysDiff <= 0)
                {
                    Fname = clientsV2KryptonDataGridView_NewClient.Rows[i].Cells[1].Value.ToString();
                    Lname = clientsV2KryptonDataGridView_NewClient.Rows[i].Cells[2].Value.ToString();
                    age = clientsV2KryptonDataGridView_NewClient.Rows[i].Cells[3].Value.ToString();
                    tlfn = clientsV2KryptonDataGridView_NewClient.Rows[i].Cells[6].Value.ToString();
                    email = clientsV2KryptonDataGridView_NewClient.Rows[i].Cells[7].Value.ToString();
                    d = clientsV2KryptonDataGridView_NewClient.Rows[i].Cells[9].Value.ToString();
                    MP = clientsV2KryptonDataGridView_NewClient.Rows[i].Cells[10].Value.ToString();

                    if (Fname != "" && Lname != "" /* && d != ""*/)
                    {
                        d = Convert.ToDateTime(d).ToString("dd/MM/yyyy");
                        dd = d;

                        /*Console.WriteLine("fn :" + Fname);
                        Console.WriteLine("ln : " + Lname);
                        Console.WriteLine("age : " + age);
                        Console.WriteLine("tlfn : " + tlfn);
                        Console.WriteLine("email : " + email);
                        Console.WriteLine("mp : " + MP);*/

                        kryptonDataGridView1.Rows.Add(Fname, Lname, age, dd, tlfn, email, MP);
                    }
                    else
                    {
                        //Console.WriteLine("vide ");
                    }
                }
            }

            clientsV2KryptonDataGridView_NewClient.Visible = false;
            kryptonDataGridView1.Visible = true;
            kryptonLabel1.Visible = true;
            kryptonLabel2__ClientList.Visible = false;

            kryptonButton2.Enabled = true;
            kryptonButton1.Enabled = false;
            /*panel_ClientList.SendToBack();
            panel_ClientList.Hide();
            panel1.BringToFront();
            panel1.Show();*/

        }

        dynamic E;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        
        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            /*printPreviewDialog1.Document = printDocument1;

            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);

            printPreviewDialog1.ShowDialog();*/

            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            pictureBox1.Width = 400;
            pictureBox1.Height = 220;
            Bitmap bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.DrawToBitmap(bm, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
            e.Graphics.DrawImage(bm, 4, 7);
            bm.Dispose();

            e.Graphics.DrawString(Nom, new Font("Abeezee", 11), Brushes.White, new Point(219, 100));

            e.Graphics.DrawString(Prenom, new Font("Abeezee", 11), Brushes.White, new Point(235, 135));

            e.Graphics.DrawString("0" + Telephone, new Font("Abeezee", 11), Brushes.White, new Point(250, 170));

            /*
            // frame de la carte
            e.Graphics.DrawString("____________________________", new Font("Abeezee", 15, FontStyle.Bold), Brushes.Black, new Point(2, -15));
            e.Graphics.DrawString("|                                                          |", new Font("Abeezee", 15, FontStyle.Bold), Brushes.Black, new Point(0, 5));
            e.Graphics.DrawString("|                                                          |", new Font("Abeezee", 15, FontStyle.Bold), Brushes.Black, new Point(0, 15));
            e.Graphics.DrawString("|                                                          |", new Font("Abeezee", 15, FontStyle.Bold), Brushes.Black, new Point(0, 30));
            e.Graphics.DrawString("|                                                          |", new Font("Abeezee", 15, FontStyle.Bold), Brushes.Black, new Point(0, 40));
            e.Graphics.DrawString("|                                                          |", new Font("Abeezee", 15, FontStyle.Bold), Brushes.Black, new Point(0, 50));
            e.Graphics.DrawString("|                                                          |", new Font("Abeezee", 15, FontStyle.Bold), Brushes.Black, new Point(0, 60));
            e.Graphics.DrawString("|                                                          |", new Font("Abeezee", 15, FontStyle.Bold), Brushes.Black, new Point(0, 70));
            e.Graphics.DrawString("|                                                          |", new Font("Abeezee", 15, FontStyle.Bold), Brushes.Black, new Point(0, 80));
            e.Graphics.DrawString("|                                                          |", new Font("Abeezee", 15, FontStyle.Bold), Brushes.Black, new Point(0, 90));
            e.Graphics.DrawString("|                                                          |", new Font("Abeezee", 15, FontStyle.Bold), Brushes.Black, new Point(0, 100));
            e.Graphics.DrawString("|                                                          |", new Font("Abeezee", 15, FontStyle.Bold), Brushes.Black, new Point(0, 110));
            e.Graphics.DrawString("|                                                          |", new Font("Abeezee", 15, FontStyle.Bold), Brushes.Black, new Point(0, 120));
            e.Graphics.DrawString("|                                                          |", new Font("Abeezee", 15, FontStyle.Bold), Brushes.Black, new Point(0, 130));
            e.Graphics.DrawString("|                                                          |", new Font("Abeezee", 15, FontStyle.Bold), Brushes.Black, new Point(0, 145));
            e.Graphics.DrawString("____________________________", new Font("Abeezee", 15, FontStyle.Bold), Brushes.Black, new Point(0, 148));

            // content
            e.Graphics.DrawString("====== Prestige Fitness ======", new Font("Abeezee", 15, FontStyle.Bold), Brushes.Black, new Point(5, 15));

            e.Graphics.DrawString("Nom : " + Nom, new Font("Abeezee", 15), Brushes.Black, new Point(10, 50));

            e.Graphics.DrawString("Prenom : " + Prenom, new Font("Abeezee", 15), Brushes.Black, new Point(10, 85));

            e.Graphics.DrawString("Téléphone : 0" + Telephone, new Font("Abeezee", 15), Brushes.Black, new Point(10, 120));

            e.Graphics.DrawString("===========================", new Font("Abeezee", 15), Brushes.Black, new Point(8, 145));

            //cadre de photo
            e.Graphics.DrawString("______", new Font("Abeezee", 15), Brushes.Black, new Point(245, 43));
            e.Graphics.DrawString("|             |", new Font("Abeezee", 15), Brushes.Black, new Point(243, 60));
            e.Graphics.DrawString("|             |", new Font("Abeezee", 15), Brushes.Black, new Point(243, 75));
            e.Graphics.DrawString("|             |", new Font("Abeezee", 15), Brushes.Black, new Point(243, 90));
            e.Graphics.DrawString("|             |", new Font("Abeezee", 15), Brushes.Black, new Point(243, 105));
            e.Graphics.DrawString("|             |", new Font("Abeezee", 15), Brushes.Black, new Point(243, 115));
            e.Graphics.DrawString("______", new Font("Abeezee", 15), Brushes.Black, new Point(245, 118));
            */
        }

        private void clientsV2KryptonDataGridView_NewClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            kryptonDataGridView1.Rows.Clear();

            clientsV2KryptonDataGridView_NewClient.Visible = true;
            kryptonDataGridView1.Visible = false;
            kryptonLabel1.Visible = false;
            kryptonLabel2__ClientList.Visible = true;

            kryptonButton2.Enabled = false;
            kryptonButton1.Enabled = true;
        }
    }
}
