
namespace Gym_Management_System_2
{
    partial class ItemsListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemsListForm));
            this.panel_ProductsList = new System.Windows.Forms.Panel();
            this.prdouctsV2KryptonDataGridView_NewProduct = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aboutItemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplementsDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.equipmentDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemsV1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsDBv1DataSet = new Gym_Management_System_2.ItemsDBv1DataSet();
            this.kryptonButton9_panel5_ProductsList = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.searchproductKryptonTextBox_ProductsList = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel3_ProductsList = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2_ProductsList = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1_ProductsList = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.panel3_fel_ProductsList = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3_ProductsList = new System.Windows.Forms.Label();
            this.itemsV1TableAdapter = new Gym_Management_System_2.ItemsDBv1DataSetTableAdapters.ItemsV1TableAdapter();
            this.tableAdapterManager = new Gym_Management_System_2.ItemsDBv1DataSetTableAdapters.TableAdapterManager();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel_ProductsList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prdouctsV2KryptonDataGridView_NewProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsV1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDBv1DataSet)).BeginInit();
            this.panel3_fel_ProductsList.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_ProductsList
            // 
            this.panel_ProductsList.BackColor = System.Drawing.Color.DarkGray;
            this.panel_ProductsList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_ProductsList.Controls.Add(this.prdouctsV2KryptonDataGridView_NewProduct);
            this.panel_ProductsList.Controls.Add(this.kryptonButton9_panel5_ProductsList);
            this.panel_ProductsList.Controls.Add(this.searchproductKryptonTextBox_ProductsList);
            this.panel_ProductsList.Controls.Add(this.kryptonLabel3_ProductsList);
            this.panel_ProductsList.Controls.Add(this.kryptonLabel2_ProductsList);
            this.panel_ProductsList.Controls.Add(this.kryptonLabel1_ProductsList);
            this.panel_ProductsList.Controls.Add(this.panel3_fel_ProductsList);
            this.panel_ProductsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ProductsList.Location = new System.Drawing.Point(0, 0);
            this.panel_ProductsList.Name = "panel_ProductsList";
            this.panel_ProductsList.Size = new System.Drawing.Size(971, 602);
            this.panel_ProductsList.TabIndex = 9;
            this.panel_ProductsList.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_ProductsList_Paint);
            // 
            // prdouctsV2KryptonDataGridView_NewProduct
            // 
            this.prdouctsV2KryptonDataGridView_NewProduct.AutoGenerateColumns = false;
            this.prdouctsV2KryptonDataGridView_NewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prdouctsV2KryptonDataGridView_NewProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.itemNameDataGridViewTextBoxColumn,
            this.aboutItemDataGridViewTextBoxColumn,
            this.supplementsDataGridViewCheckBoxColumn,
            this.equipmentDataGridViewCheckBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.prdouctsV2KryptonDataGridView_NewProduct.DataSource = this.itemsV1BindingSource;
            this.prdouctsV2KryptonDataGridView_NewProduct.Location = new System.Drawing.Point(101, 267);
            this.prdouctsV2KryptonDataGridView_NewProduct.Name = "prdouctsV2KryptonDataGridView_NewProduct";
            this.prdouctsV2KryptonDataGridView_NewProduct.Size = new System.Drawing.Size(741, 323);
            this.prdouctsV2KryptonDataGridView_NewProduct.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.prdouctsV2KryptonDataGridView_NewProduct.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.prdouctsV2KryptonDataGridView_NewProduct.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.White;
            this.prdouctsV2KryptonDataGridView_NewProduct.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.Black;
            this.prdouctsV2KryptonDataGridView_NewProduct.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.prdouctsV2KryptonDataGridView_NewProduct.StateCommon.DataCell.Content.Color1 = System.Drawing.Color.Black;
            this.prdouctsV2KryptonDataGridView_NewProduct.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.Brown;
            this.prdouctsV2KryptonDataGridView_NewProduct.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.Silver;
            this.prdouctsV2KryptonDataGridView_NewProduct.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.Black;
            this.prdouctsV2KryptonDataGridView_NewProduct.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.prdouctsV2KryptonDataGridView_NewProduct.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.Black;
            this.prdouctsV2KryptonDataGridView_NewProduct.StateCommon.HeaderRow.Back.Color1 = System.Drawing.Color.White;
            this.prdouctsV2KryptonDataGridView_NewProduct.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.Gray;
            this.prdouctsV2KryptonDataGridView_NewProduct.StateSelected.DataCell.Back.Color2 = System.Drawing.Color.Gray;
            this.prdouctsV2KryptonDataGridView_NewProduct.StateSelected.DataCell.Content.Color1 = System.Drawing.Color.Black;
            this.prdouctsV2KryptonDataGridView_NewProduct.TabIndex = 18;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "Item Name";
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "Item Name";
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            // 
            // aboutItemDataGridViewTextBoxColumn
            // 
            this.aboutItemDataGridViewTextBoxColumn.DataPropertyName = "About Item";
            this.aboutItemDataGridViewTextBoxColumn.HeaderText = "About Item";
            this.aboutItemDataGridViewTextBoxColumn.Name = "aboutItemDataGridViewTextBoxColumn";
            // 
            // supplementsDataGridViewCheckBoxColumn
            // 
            this.supplementsDataGridViewCheckBoxColumn.DataPropertyName = "Supplements";
            this.supplementsDataGridViewCheckBoxColumn.HeaderText = "Supplements";
            this.supplementsDataGridViewCheckBoxColumn.Name = "supplementsDataGridViewCheckBoxColumn";
            // 
            // equipmentDataGridViewCheckBoxColumn
            // 
            this.equipmentDataGridViewCheckBoxColumn.DataPropertyName = "Equipment";
            this.equipmentDataGridViewCheckBoxColumn.HeaderText = "Equipment";
            this.equipmentDataGridViewCheckBoxColumn.Name = "equipmentDataGridViewCheckBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // itemsV1BindingSource
            // 
            this.itemsV1BindingSource.DataMember = "ItemsV1";
            this.itemsV1BindingSource.DataSource = this.itemsDBv1DataSet;
            // 
            // itemsDBv1DataSet
            // 
            this.itemsDBv1DataSet.DataSetName = "ItemsDBv1DataSet";
            this.itemsDBv1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kryptonButton9_panel5_ProductsList
            // 
            this.kryptonButton9_panel5_ProductsList.Location = new System.Drawing.Point(816, 211);
            this.kryptonButton9_panel5_ProductsList.Name = "kryptonButton9_panel5_ProductsList";
            this.kryptonButton9_panel5_ProductsList.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.kryptonButton9_panel5_ProductsList.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.kryptonButton9_panel5_ProductsList.Size = new System.Drawing.Size(65, 36);
            this.kryptonButton9_panel5_ProductsList.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.kryptonButton9_panel5_ProductsList.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.kryptonButton9_panel5_ProductsList.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonButton9_panel5_ProductsList.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton9_panel5_ProductsList.StateCommon.Border.Rounding = 20;
            this.kryptonButton9_panel5_ProductsList.StateCommon.Border.Width = 2;
            this.kryptonButton9_panel5_ProductsList.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton9_panel5_ProductsList.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton9_panel5_ProductsList.TabIndex = 12;
            this.kryptonButton9_panel5_ProductsList.Values.Text = "Refrech";
            this.kryptonButton9_panel5_ProductsList.Click += new System.EventHandler(this.kryptonButton9_panel5_ProductsList_Click);
            // 
            // searchproductKryptonTextBox_ProductsList
            // 
            this.searchproductKryptonTextBox_ProductsList.Location = new System.Drawing.Point(418, 211);
            this.searchproductKryptonTextBox_ProductsList.Name = "searchproductKryptonTextBox_ProductsList";
            this.searchproductKryptonTextBox_ProductsList.Size = new System.Drawing.Size(254, 35);
            this.searchproductKryptonTextBox_ProductsList.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.searchproductKryptonTextBox_ProductsList.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.searchproductKryptonTextBox_ProductsList.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.searchproductKryptonTextBox_ProductsList.StateCommon.Border.Rounding = 20;
            this.searchproductKryptonTextBox_ProductsList.StateDisabled.Back.Color1 = System.Drawing.Color.Silver;
            this.searchproductKryptonTextBox_ProductsList.StateDisabled.Border.Color1 = System.Drawing.Color.Silver;
            this.searchproductKryptonTextBox_ProductsList.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.searchproductKryptonTextBox_ProductsList.StateDisabled.Border.Rounding = 20;
            this.searchproductKryptonTextBox_ProductsList.TabIndex = 10;
            this.searchproductKryptonTextBox_ProductsList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchproductKryptonTextBox_ProductsList_KeyDown);
            // 
            // kryptonLabel3_ProductsList
            // 
            this.kryptonLabel3_ProductsList.Location = new System.Drawing.Point(300, 217);
            this.kryptonLabel3_ProductsList.Name = "kryptonLabel3_ProductsList";
            this.kryptonLabel3_ProductsList.Size = new System.Drawing.Size(112, 19);
            this.kryptonLabel3_ProductsList.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel3_ProductsList.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.kryptonLabel3_ProductsList.TabIndex = 4;
            this.kryptonLabel3_ProductsList.Values.Text = "Search product :";
            // 
            // kryptonLabel2_ProductsList
            // 
            this.kryptonLabel2_ProductsList.Location = new System.Drawing.Point(168, 219);
            this.kryptonLabel2_ProductsList.Name = "kryptonLabel2_ProductsList";
            this.kryptonLabel2_ProductsList.Size = new System.Drawing.Size(58, 19);
            this.kryptonLabel2_ProductsList.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kryptonLabel2_ProductsList.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.kryptonLabel2_ProductsList.TabIndex = 3;
            this.kryptonLabel2_ProductsList.Values.Text = "number";
            // 
            // kryptonLabel1_ProductsList
            // 
            this.kryptonLabel1_ProductsList.Location = new System.Drawing.Point(54, 219);
            this.kryptonLabel1_ProductsList.Name = "kryptonLabel1_ProductsList";
            this.kryptonLabel1_ProductsList.Size = new System.Drawing.Size(108, 19);
            this.kryptonLabel1_ProductsList.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel1_ProductsList.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.kryptonLabel1_ProductsList.TabIndex = 2;
            this.kryptonLabel1_ProductsList.Values.Text = "Total Products :";
            // 
            // panel3_fel_ProductsList
            // 
            this.panel3_fel_ProductsList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3_fel_ProductsList.BackgroundImage")));
            this.panel3_fel_ProductsList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3_fel_ProductsList.Controls.Add(this.label1);
            this.panel3_fel_ProductsList.Controls.Add(this.label3_ProductsList);
            this.panel3_fel_ProductsList.Location = new System.Drawing.Point(0, 0);
            this.panel3_fel_ProductsList.Name = "panel3_fel_ProductsList";
            this.panel3_fel_ProductsList.Size = new System.Drawing.Size(971, 174);
            this.panel3_fel_ProductsList.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(760, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 47);
            this.label1.TabIndex = 20;
            this.label1.Text = "Items List";
            // 
            // label3_ProductsList
            // 
            this.label3_ProductsList.AutoSize = true;
            this.label3_ProductsList.BackColor = System.Drawing.Color.Transparent;
            this.label3_ProductsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3_ProductsList.ForeColor = System.Drawing.Color.White;
            this.label3_ProductsList.Location = new System.Drawing.Point(3, 9);
            this.label3_ProductsList.Name = "label3_ProductsList";
            this.label3_ProductsList.Size = new System.Drawing.Size(149, 39);
            this.label3_ProductsList.TabIndex = 17;
            this.label3_ProductsList.Text = "00:00:00";
            // 
            // itemsV1TableAdapter
            // 
            this.itemsV1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ItemsV1TableAdapter = this.itemsV1TableAdapter;
            this.tableAdapterManager.UpdateOrder = Gym_Management_System_2.ItemsDBv1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ItemsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 602);
            this.Controls.Add(this.panel_ProductsList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ItemsListForm";
            this.Text = "ItemsListForm";
            this.Load += new System.EventHandler(this.ItemsListForm_Load);
            this.panel_ProductsList.ResumeLayout(false);
            this.panel_ProductsList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prdouctsV2KryptonDataGridView_NewProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsV1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDBv1DataSet)).EndInit();
            this.panel3_fel_ProductsList.ResumeLayout(false);
            this.panel3_fel_ProductsList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_ProductsList;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton9_panel5_ProductsList;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox searchproductKryptonTextBox_ProductsList;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3_ProductsList;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2_ProductsList;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1_ProductsList;
        private System.Windows.Forms.Panel panel3_fel_ProductsList;
        private System.Windows.Forms.Label label3_ProductsList;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView prdouctsV2KryptonDataGridView_NewProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aboutItemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn supplementsDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn equipmentDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource itemsV1BindingSource;
        private ItemsDBv1DataSet itemsDBv1DataSet;
        private ItemsDBv1DataSetTableAdapters.ItemsV1TableAdapter itemsV1TableAdapter;
        private ItemsDBv1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}