namespace shop_UI
{
    partial class Home
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemsDataGrid = new System.Windows.Forms.DataGridView();
            this.Product_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.profileToolStripMenuItem,
            this.outToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(988, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.homeToolStripMenuItem.Text = "Bag";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.profileToolStripMenuItem.Text = "Profile";
            this.profileToolStripMenuItem.Click += new System.EventHandler(this.profileToolStripMenuItem_Click);
            // 
            // outToolStripMenuItem
            // 
            this.outToolStripMenuItem.Name = "outToolStripMenuItem";
            this.outToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.outToolStripMenuItem.Text = "Out";
            this.outToolStripMenuItem.Click += new System.EventHandler(this.outToolStripMenuItem_Click);
            // 
            // ItemsDataGrid
            // 
            this.ItemsDataGrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ItemsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ItemsDataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ItemsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product_Name,
            this.Price,
            this.Category,
            this.ItemID,
            this.Description});
            this.ItemsDataGrid.Location = new System.Drawing.Point(0, 27);
            this.ItemsDataGrid.MultiSelect = false;
            this.ItemsDataGrid.Name = "ItemsDataGrid";
            this.ItemsDataGrid.Size = new System.Drawing.Size(988, 556);
            this.ItemsDataGrid.TabIndex = 1;
            this.ItemsDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemsDataGrid_CellClick);
            this.ItemsDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemsDataGrid_CellContentClick);
            // 
            // Product_Name
            // 
            this.Product_Name.HeaderText = "Name";
            this.Product_Name.Name = "Product_Name";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            // 
            // ItemID
            // 
            this.ItemID.HeaderText = "ID";
            this.ItemID.Name = "ItemID";
            this.ItemID.Visible = false;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.Visible = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 581);
            this.Controls.Add(this.ItemsDataGrid);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outToolStripMenuItem;
        private System.Windows.Forms.DataGridView ItemsDataGrid;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
    }
}