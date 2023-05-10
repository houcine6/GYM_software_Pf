
namespace Gym_Management_System_2
{
    partial class ClientListForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientListForm));
            this.panel_ClientList = new System.Windows.Forms.Panel();
            this.kryptonButton2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonDataGridView1 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age_age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expirationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.e_mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount_paid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kryptonButton3 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.searchKryptonTextBox__ClientList = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonButton9_ClientList = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel3__ClientList = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2__ClientList = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1__ClientList = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.panel4_fel_ClientList = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6_timer_ClientList = new System.Windows.Forms.Label();
            this.clientsV2KryptonDataGridView_NewClient = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientsV2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsDBv2DataSet = new Gym_Management_System_2.ClientsDBv2DataSet();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.clientsV2TableAdapter = new Gym_Management_System_2.ClientsDBv2DataSetTableAdapters.ClientsV2TableAdapter();
            this.tableAdapterManager = new Gym_Management_System_2.ClientsDBv2DataSetTableAdapters.TableAdapterManager();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel_ClientList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).BeginInit();
            this.panel4_fel_ClientList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsV2KryptonDataGridView_NewClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsV2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsDBv2DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_ClientList
            // 
            this.panel_ClientList.BackColor = System.Drawing.Color.DarkGray;
            this.panel_ClientList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel_ClientList.Controls.Add(this.kryptonButton2);
            this.panel_ClientList.Controls.Add(this.kryptonDataGridView1);
            this.panel_ClientList.Controls.Add(this.kryptonButton3);
            this.panel_ClientList.Controls.Add(this.kryptonLabel1);
            this.panel_ClientList.Controls.Add(this.kryptonButton1);
            this.panel_ClientList.Controls.Add(this.searchKryptonTextBox__ClientList);
            this.panel_ClientList.Controls.Add(this.kryptonButton9_ClientList);
            this.panel_ClientList.Controls.Add(this.kryptonLabel3__ClientList);
            this.panel_ClientList.Controls.Add(this.kryptonLabel2__ClientList);
            this.panel_ClientList.Controls.Add(this.kryptonLabel1__ClientList);
            this.panel_ClientList.Controls.Add(this.panel4_fel_ClientList);
            this.panel_ClientList.Controls.Add(this.clientsV2KryptonDataGridView_NewClient);
            this.panel_ClientList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ClientList.Location = new System.Drawing.Point(0, 0);
            this.panel_ClientList.Name = "panel_ClientList";
            this.panel_ClientList.Size = new System.Drawing.Size(957, 625);
            this.panel_ClientList.TabIndex = 18;
            this.panel_ClientList.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_ClientList_Paint);
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.Enabled = false;
            this.kryptonButton2.Location = new System.Drawing.Point(877, 199);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kryptonButton2.OverrideDefault.Back.Color2 = System.Drawing.Color.Maroon;
            this.kryptonButton2.OverrideDefault.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonButton2.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton2.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton2.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kryptonButton2.OverrideFocus.Back.Color2 = System.Drawing.Color.Maroon;
            this.kryptonButton2.OverrideFocus.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonButton2.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton2.OverrideFocus.Border.Rounding = 20;
            this.kryptonButton2.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton2.Size = new System.Drawing.Size(68, 36);
            this.kryptonButton2.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kryptonButton2.StateCommon.Back.Color2 = System.Drawing.Color.Maroon;
            this.kryptonButton2.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonButton2.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton2.StateCommon.Border.Rounding = 20;
            this.kryptonButton2.StateCommon.Border.Width = 2;
            this.kryptonButton2.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton2.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton2.StateDisabled.Back.Color1 = System.Drawing.Color.Gray;
            this.kryptonButton2.StateDisabled.Back.Color2 = System.Drawing.Color.Gray;
            this.kryptonButton2.TabIndex = 63;
            this.kryptonButton2.Values.Text = "Retour";
            this.kryptonButton2.Click += new System.EventHandler(this.kryptonButton2_Click);
            // 
            // kryptonDataGridView1
            // 
            this.kryptonDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kryptonDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstname,
            this.lastname,
            this.age_age,
            this.expirationDate,
            this.phone,
            this.e_mail,
            this.amount_paid});
            this.kryptonDataGridView1.Location = new System.Drawing.Point(111, 260);
            this.kryptonDataGridView1.MultiSelect = false;
            this.kryptonDataGridView1.Name = "kryptonDataGridView1";
            this.kryptonDataGridView1.ReadOnly = true;
            this.kryptonDataGridView1.Size = new System.Drawing.Size(741, 353);
            this.kryptonDataGridView1.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kryptonDataGridView1.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.kryptonDataGridView1.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.White;
            this.kryptonDataGridView1.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonDataGridView1.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonDataGridView1.StateCommon.DataCell.Content.Color1 = System.Drawing.Color.Black;
            this.kryptonDataGridView1.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.Brown;
            this.kryptonDataGridView1.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.Gray;
            this.kryptonDataGridView1.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonDataGridView1.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonDataGridView1.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.Black;
            this.kryptonDataGridView1.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.kryptonDataGridView1.StateCommon.HeaderRow.Back.Color1 = System.Drawing.Color.White;
            this.kryptonDataGridView1.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.Gray;
            this.kryptonDataGridView1.StateSelected.DataCell.Back.Color2 = System.Drawing.Color.Gray;
            this.kryptonDataGridView1.StateSelected.DataCell.Content.Color1 = System.Drawing.Color.Black;
            this.kryptonDataGridView1.TabIndex = 36;
            // 
            // firstname
            // 
            this.firstname.HeaderText = "Nom";
            this.firstname.Name = "firstname";
            this.firstname.ReadOnly = true;
            // 
            // lastname
            // 
            this.lastname.HeaderText = "Prenom";
            this.lastname.Name = "lastname";
            this.lastname.ReadOnly = true;
            // 
            // age_age
            // 
            this.age_age.HeaderText = "Age";
            this.age_age.Name = "age_age";
            this.age_age.ReadOnly = true;
            // 
            // expirationDate
            // 
            this.expirationDate.HeaderText = "Date d\'expiration";
            this.expirationDate.Name = "expirationDate";
            this.expirationDate.ReadOnly = true;
            // 
            // phone
            // 
            this.phone.HeaderText = "Téléphone";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            // 
            // e_mail
            // 
            this.e_mail.HeaderText = "E-mail";
            this.e_mail.Name = "e_mail";
            this.e_mail.ReadOnly = true;
            // 
            // amount_paid
            // 
            this.amount_paid.HeaderText = "Montant payé";
            this.amount_paid.Name = "amount_paid";
            this.amount_paid.ReadOnly = true;
            // 
            // kryptonButton3
            // 
            this.kryptonButton3.Location = new System.Drawing.Point(625, 199);
            this.kryptonButton3.Name = "kryptonButton3";
            this.kryptonButton3.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kryptonButton3.OverrideDefault.Back.Color2 = System.Drawing.Color.Maroon;
            this.kryptonButton3.OverrideDefault.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonButton3.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton3.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton3.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kryptonButton3.OverrideFocus.Back.Color2 = System.Drawing.Color.Maroon;
            this.kryptonButton3.OverrideFocus.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonButton3.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton3.OverrideFocus.Border.Rounding = 20;
            this.kryptonButton3.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton3.Size = new System.Drawing.Size(125, 36);
            this.kryptonButton3.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kryptonButton3.StateCommon.Back.Color2 = System.Drawing.Color.Maroon;
            this.kryptonButton3.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonButton3.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton3.StateCommon.Border.Rounding = 20;
            this.kryptonButton3.StateCommon.Border.Width = 2;
            this.kryptonButton3.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton3.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton3.StateDisabled.Back.Color1 = System.Drawing.Color.Gray;
            this.kryptonButton3.TabIndex = 34;
            this.kryptonButton3.Values.Text = "imprimer une carte";
            this.kryptonButton3.Click += new System.EventHandler(this.kryptonButton3_Click);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(186, 207);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(21, 23);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.Red;
            this.kryptonLabel1.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 35;
            this.kryptonLabel1.Values.Text = "0";
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(764, 199);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kryptonButton1.OverrideDefault.Back.Color2 = System.Drawing.Color.Maroon;
            this.kryptonButton1.OverrideDefault.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonButton1.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kryptonButton1.OverrideFocus.Back.Color2 = System.Drawing.Color.Maroon;
            this.kryptonButton1.OverrideFocus.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonButton1.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.OverrideFocus.Border.Rounding = 20;
            this.kryptonButton1.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.Size = new System.Drawing.Size(102, 36);
            this.kryptonButton1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kryptonButton1.StateCommon.Back.Color2 = System.Drawing.Color.Maroon;
            this.kryptonButton1.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonButton1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateCommon.Border.Rounding = 20;
            this.kryptonButton1.StateCommon.Border.Width = 2;
            this.kryptonButton1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton1.TabIndex = 33;
            this.kryptonButton1.Values.Text = "Clients expirés";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // searchKryptonTextBox__ClientList
            // 
            this.searchKryptonTextBox__ClientList.Location = new System.Drawing.Point(342, 199);
            this.searchKryptonTextBox__ClientList.MaximumSize = new System.Drawing.Size(189, 35);
            this.searchKryptonTextBox__ClientList.MinimumSize = new System.Drawing.Size(189, 35);
            this.searchKryptonTextBox__ClientList.Name = "searchKryptonTextBox__ClientList";
            this.searchKryptonTextBox__ClientList.Size = new System.Drawing.Size(189, 35);
            this.searchKryptonTextBox__ClientList.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.searchKryptonTextBox__ClientList.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.searchKryptonTextBox__ClientList.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.searchKryptonTextBox__ClientList.StateCommon.Border.Rounding = 20;
            this.searchKryptonTextBox__ClientList.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.searchKryptonTextBox__ClientList.StateDisabled.Back.Color1 = System.Drawing.Color.Silver;
            this.searchKryptonTextBox__ClientList.StateDisabled.Border.Color1 = System.Drawing.Color.Silver;
            this.searchKryptonTextBox__ClientList.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.searchKryptonTextBox__ClientList.StateDisabled.Border.Rounding = 20;
            this.searchKryptonTextBox__ClientList.TabIndex = 9;
            this.searchKryptonTextBox__ClientList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchKryptonTextBox__ClientList_KeyDown);
            // 
            // kryptonButton9_ClientList
            // 
            this.kryptonButton9_ClientList.Location = new System.Drawing.Point(537, 199);
            this.kryptonButton9_ClientList.Name = "kryptonButton9_ClientList";
            this.kryptonButton9_ClientList.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kryptonButton9_ClientList.OverrideDefault.Back.Color2 = System.Drawing.Color.Maroon;
            this.kryptonButton9_ClientList.OverrideDefault.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonButton9_ClientList.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton9_ClientList.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton9_ClientList.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kryptonButton9_ClientList.OverrideFocus.Back.Color2 = System.Drawing.Color.Maroon;
            this.kryptonButton9_ClientList.OverrideFocus.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonButton9_ClientList.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton9_ClientList.OverrideFocus.Border.Rounding = 20;
            this.kryptonButton9_ClientList.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton9_ClientList.Size = new System.Drawing.Size(77, 36);
            this.kryptonButton9_ClientList.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kryptonButton9_ClientList.StateCommon.Back.Color2 = System.Drawing.Color.Maroon;
            this.kryptonButton9_ClientList.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonButton9_ClientList.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton9_ClientList.StateCommon.Border.Rounding = 20;
            this.kryptonButton9_ClientList.StateCommon.Border.Width = 2;
            this.kryptonButton9_ClientList.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton9_ClientList.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton9_ClientList.TabIndex = 7;
            this.kryptonButton9_ClientList.Values.Text = "Rafraichir";
            this.kryptonButton9_ClientList.Click += new System.EventHandler(this.kryptonButton9_ClientList_Click);
            // 
            // kryptonLabel3__ClientList
            // 
            this.kryptonLabel3__ClientList.Location = new System.Drawing.Point(235, 205);
            this.kryptonLabel3__ClientList.Name = "kryptonLabel3__ClientList";
            this.kryptonLabel3__ClientList.Size = new System.Drawing.Size(101, 21);
            this.kryptonLabel3__ClientList.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel3__ClientList.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonLabel3__ClientList.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.kryptonLabel3__ClientList.TabIndex = 8;
            this.kryptonLabel3__ClientList.Values.Text = "Rechercher :";
            // 
            // kryptonLabel2__ClientList
            // 
            this.kryptonLabel2__ClientList.Location = new System.Drawing.Point(186, 207);
            this.kryptonLabel2__ClientList.Name = "kryptonLabel2__ClientList";
            this.kryptonLabel2__ClientList.Size = new System.Drawing.Size(21, 23);
            this.kryptonLabel2__ClientList.StateCommon.ShortText.Color1 = System.Drawing.Color.Red;
            this.kryptonLabel2__ClientList.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonLabel2__ClientList.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2__ClientList.TabIndex = 4;
            this.kryptonLabel2__ClientList.Values.Text = "0";
            // 
            // kryptonLabel1__ClientList
            // 
            this.kryptonLabel1__ClientList.Location = new System.Drawing.Point(33, 207);
            this.kryptonLabel1__ClientList.Name = "kryptonLabel1__ClientList";
            this.kryptonLabel1__ClientList.Size = new System.Drawing.Size(138, 21);
            this.kryptonLabel1__ClientList.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel1__ClientList.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonLabel1__ClientList.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.kryptonLabel1__ClientList.TabIndex = 3;
            this.kryptonLabel1__ClientList.Values.Text = "Totale de Clients :";
            // 
            // panel4_fel_ClientList
            // 
            this.panel4_fel_ClientList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4_fel_ClientList.BackgroundImage")));
            this.panel4_fel_ClientList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4_fel_ClientList.Controls.Add(this.pictureBox1);
            this.panel4_fel_ClientList.Controls.Add(this.label2);
            this.panel4_fel_ClientList.Controls.Add(this.label6_timer_ClientList);
            this.panel4_fel_ClientList.Location = new System.Drawing.Point(0, 0);
            this.panel4_fel_ClientList.Margin = new System.Windows.Forms.Padding(0);
            this.panel4_fel_ClientList.Name = "panel4_fel_ClientList";
            this.panel4_fel_ClientList.Size = new System.Drawing.Size(957, 171);
            this.panel4_fel_ClientList.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkRed;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(333, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 28F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(646, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 44);
            this.label2.TabIndex = 19;
            this.label2.Text = "Liste des Clients";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label6_timer_ClientList
            // 
            this.label6_timer_ClientList.AutoSize = true;
            this.label6_timer_ClientList.BackColor = System.Drawing.Color.Transparent;
            this.label6_timer_ClientList.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6_timer_ClientList.ForeColor = System.Drawing.Color.White;
            this.label6_timer_ClientList.Location = new System.Drawing.Point(12, 122);
            this.label6_timer_ClientList.Name = "label6_timer_ClientList";
            this.label6_timer_ClientList.Size = new System.Drawing.Size(174, 46);
            this.label6_timer_ClientList.TabIndex = 18;
            this.label6_timer_ClientList.Text = "00:00:00";
            // 
            // clientsV2KryptonDataGridView_NewClient
            // 
            this.clientsV2KryptonDataGridView_NewClient.AutoGenerateColumns = false;
            this.clientsV2KryptonDataGridView_NewClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientsV2KryptonDataGridView_NewClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.clientsV2KryptonDataGridView_NewClient.DataSource = this.clientsV2BindingSource;
            this.clientsV2KryptonDataGridView_NewClient.Location = new System.Drawing.Point(20, 260);
            this.clientsV2KryptonDataGridView_NewClient.MultiSelect = false;
            this.clientsV2KryptonDataGridView_NewClient.Name = "clientsV2KryptonDataGridView_NewClient";
            this.clientsV2KryptonDataGridView_NewClient.ReadOnly = true;
            this.clientsV2KryptonDataGridView_NewClient.Size = new System.Drawing.Size(925, 353);
            this.clientsV2KryptonDataGridView_NewClient.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clientsV2KryptonDataGridView_NewClient.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.clientsV2KryptonDataGridView_NewClient.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.White;
            this.clientsV2KryptonDataGridView_NewClient.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.Black;
            this.clientsV2KryptonDataGridView_NewClient.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.clientsV2KryptonDataGridView_NewClient.StateCommon.DataCell.Content.Color1 = System.Drawing.Color.Black;
            this.clientsV2KryptonDataGridView_NewClient.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.Brown;
            this.clientsV2KryptonDataGridView_NewClient.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.Gray;
            this.clientsV2KryptonDataGridView_NewClient.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.Black;
            this.clientsV2KryptonDataGridView_NewClient.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.clientsV2KryptonDataGridView_NewClient.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.Black;
            this.clientsV2KryptonDataGridView_NewClient.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.clientsV2KryptonDataGridView_NewClient.StateCommon.HeaderRow.Back.Color1 = System.Drawing.Color.White;
            this.clientsV2KryptonDataGridView_NewClient.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.Gray;
            this.clientsV2KryptonDataGridView_NewClient.StateSelected.DataCell.Back.Color2 = System.Drawing.Color.Gray;
            this.clientsV2KryptonDataGridView_NewClient.StateSelected.DataCell.Content.Color1 = System.Drawing.Color.Black;
            this.clientsV2KryptonDataGridView_NewClient.TabIndex = 32;
            this.clientsV2KryptonDataGridView_NewClient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clientsV2KryptonDataGridView_NewClient_CellClick);
            this.clientsV2KryptonDataGridView_NewClient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clientsV2KryptonDataGridView_NewClient_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "First Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Last Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Prenom";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Age";
            this.dataGridViewTextBoxColumn4.HeaderText = "Age";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Male";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Homme";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "Female";
            this.dataGridViewCheckBoxColumn2.HeaderText = "Femme";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn5.HeaderText = "Téléphone";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "E-mail";
            this.dataGridViewTextBoxColumn6.HeaderText = "E-mail";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Registration Date";
            this.dataGridViewTextBoxColumn7.HeaderText = "Date d\'inscription";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Expiration Date";
            this.dataGridViewTextBoxColumn8.HeaderText = "Date d\'expiration";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Amount Paid";
            this.dataGridViewTextBoxColumn9.HeaderText = "Montant payé";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // clientsV2BindingSource
            // 
            this.clientsV2BindingSource.DataMember = "ClientsV2";
            this.clientsV2BindingSource.DataSource = this.clientsDBv2DataSet;
            // 
            // clientsDBv2DataSet
            // 
            this.clientsDBv2DataSet.DataSetName = "ClientsDBv2DataSet";
            this.clientsDBv2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // clientsV2TableAdapter
            // 
            this.clientsV2TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientsV2TableAdapter = this.clientsV2TableAdapter;
            this.tableAdapterManager.UpdateOrder = Gym_Management_System_2.ClientsDBv2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // ClientListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(957, 625);
            this.Controls.Add(this.panel_ClientList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(957, 625);
            this.MinimumSize = new System.Drawing.Size(957, 625);
            this.Name = "ClientListForm";
            this.Text = "ClientListForm";
            this.Load += new System.EventHandler(this.ClientListForm_Load);
            this.panel_ClientList.ResumeLayout(false);
            this.panel_ClientList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).EndInit();
            this.panel4_fel_ClientList.ResumeLayout(false);
            this.panel4_fel_ClientList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsV2KryptonDataGridView_NewClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsV2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsDBv2DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_ClientList;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox searchKryptonTextBox__ClientList;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton9_ClientList;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3__ClientList;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2__ClientList;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1__ClientList;
        private System.Windows.Forms.Panel panel4_fel_ClientList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6_timer_ClientList;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView clientsV2KryptonDataGridView_NewClient;
        private System.Windows.Forms.Timer timer1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn maleDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn femaleDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expirationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountPaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource clientsV2BindingSource;
        private ClientsDBv2DataSet clientsDBv2DataSet;
        private ClientsDBv2DataSetTableAdapters.ClientsV2TableAdapter clientsV2TableAdapter;
        private ClientsDBv2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton3;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn age_age;
        private System.Windows.Forms.DataGridViewTextBoxColumn expirationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn e_mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount_paid;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}