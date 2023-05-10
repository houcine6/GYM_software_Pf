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
    public partial class NewClientForm : Form
    {
        
        public NewClientForm()
        {
            InitializeComponent();
        }
        dynamic c;
        
        private void clientsV1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            DateTime date = registration_DateDateTimePicker_NewClient.Value.Date;
            DateTime date2 = expiration_DateDateTimePicker.Value.Date;
            DateTime today = DateTime.Today;

            int daysDiff = ((TimeSpan)(date2 - date)).Days;
            int daysLeft = ((TimeSpan)(date2 - today)).Days;

            label4.Text = daysDiff.ToString();
            label6.Text = daysLeft.ToString();

            if(first_NameKryptonTextBox_NewClient.Text != "" && last_NameKryptonTextBox_NewClient.Text != "")
            {
                this.Validate();
                this.clientsV2BindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.clientsDBv2DataSet);

                MessageBox.Show("Données enregistrées avec succés", "Enregistré");
            }
            else
            {
                MessageBox.Show("Un champ important est vide", "Erreur");
            }
        }

        private void NewClientForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clientsDBv2DataSet.ClientsV2' table. You can move, or remove it, as needed.
            this.clientsV2TableAdapter.Fill(this.clientsDBv2DataSet.ClientsV2);

            timer1.Start();

            c = clientsV2KryptonDataGridView_NewClient.Rows.Count;
            c = c - 1;
        }

        private void ageKryptonTextBox_NewClient_TextChanged(object sender, EventArgs e)
        {

        }
        DateTime day = DateTime.Today;
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            first_NameKryptonTextBox_NewClient.Enabled = true;
            last_NameKryptonTextBox_NewClient.Enabled = true;
            ageKryptonTextBox_NewClient.Enabled = true;
            maleKryptonCheckBox_NewClient.Enabled = true;
            femaleKryptonCheckBox_NewClient.Enabled = true;
            phoneKryptonTextBox_NewClient.Enabled = true;
            registration_DateDateTimePicker_NewClient.Enabled = true;
            kryptonTextBox1.Enabled = true;
            kryptonTextBox2.Enabled = true;
            expiration_DateDateTimePicker.Enabled = true;

            label4.Text = "0";
            label6.Text = "0";

            registration_DateDateTimePicker_NewClient.Value = registration_DateDateTimePicker_NewClient.MinDate;
            registration_DateDateTimePicker_NewClient.Value = day;

            expiration_DateDateTimePicker.Value = expiration_DateDateTimePicker.MinDate;
            expiration_DateDateTimePicker.Value = day;
        }

        private void panel2_NewClient_Paint(object sender, PaintEventArgs e)
        {
            first_NameKryptonTextBox_NewClient.MaxLength = 49;
            last_NameKryptonTextBox_NewClient.MaxLength = 49;
            ageKryptonTextBox_NewClient.MaxLength = 3;
            kryptonTextBox2.MaxLength = 10;
        }

        private void first_NameKryptonTextBox_NewClient_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void first_NameKryptonTextBox_NewClient_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if ((!char.IsLetter(ch) && !char.IsWhiteSpace(ch)) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void last_NameKryptonTextBox_NewClient_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if ((!char.IsLetter(ch) && !char.IsWhiteSpace(ch)) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void ageKryptonTextBox_NewClient_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void phoneKryptonTextBox_NewClient_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void kryptonTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void maleKryptonCheckBox_NewClient_CheckedChanged(object sender, EventArgs e)
        {
            if (maleKryptonCheckBox_NewClient.CheckState == CheckState.Checked)
            {
                maleKryptonCheckBox_NewClient.Text = "Homme";
                femaleKryptonCheckBox_NewClient.Checked = false;
            }
        }

        private void femaleKryptonCheckBox_NewClient_CheckedChanged(object sender, EventArgs e)
        {
            if (femaleKryptonCheckBox_NewClient.CheckState == CheckState.Checked)
            {
                femaleKryptonCheckBox_NewClient.Text = "Femme";
                maleKryptonCheckBox_NewClient.Checked = false;
            }
        }

        private void clientsV2KryptonDataGridView_NewClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
                clientsV2KryptonDataGridView_NewClient.CurrentRow.Selected = true;

                DateTime date = registration_DateDateTimePicker_NewClient.Value.Date;
                DateTime date2 = expiration_DateDateTimePicker.Value.Date;
                DateTime today = DateTime.Today;

                int daysDiff = ((TimeSpan)(date2 - date)).Days;
                int daysLeft = ((TimeSpan)(date2 - today)).Days;

                label4.Text = daysDiff.ToString();
                label6.Text = daysLeft.ToString();

                first_NameKryptonTextBox_NewClient.Enabled = true;
                last_NameKryptonTextBox_NewClient.Enabled = true;
                ageKryptonTextBox_NewClient.Enabled = true;
                maleKryptonCheckBox_NewClient.Enabled = true;
                femaleKryptonCheckBox_NewClient.Enabled = true;
                phoneKryptonTextBox_NewClient.Enabled = true;
                registration_DateDateTimePicker_NewClient.Enabled = true;
                kryptonTextBox1.Enabled = true;
                kryptonTextBox2.Enabled = true;
                expiration_DateDateTimePicker.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label6_timer__NewClient.Text = DateTime.Now.ToString("T");
        }

        private void clientsV2KryptonDataGridView_NewClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void clientsV2KryptonDataGridView_NewClient_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

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

        private void searchKryptonTextBox__ClientList_TextChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in clientsV2KryptonDataGridView_NewClient.SelectedRows)
            {
                clientsV2KryptonDataGridView_NewClient.Rows.RemoveAt(row.Index);
            }

            this.Validate();
            this.clientsV2BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clientsDBv2DataSet);

            MessageBox.Show("Données enregistrées avec succés", "Enregistré");
        }

        private void first_NameKryptonTextBox_NewClient_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
