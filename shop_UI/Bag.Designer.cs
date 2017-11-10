namespace shop_UI
{
    partial class Bag
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
            this.order_items_grid = new System.Windows.Forms.DataGridView();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.payBtn = new System.Windows.Forms.Button();
            this.totalSumLbl = new System.Windows.Forms.Label();
            this.item_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.del = new System.Windows.Forms.DataGridViewImageColumn();
            this.order_item_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.order_items_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // order_items_grid
            // 
            this.order_items_grid.AllowUserToOrderColumns = true;
            this.order_items_grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.order_items_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.order_items_grid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.order_items_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.order_items_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.order_items_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.item_name,
            this.price,
            this.quantity,
            this.del,
            this.order_item_id,
            this.product_id});
            this.order_items_grid.Location = new System.Drawing.Point(9, 9);
            this.order_items_grid.Margin = new System.Windows.Forms.Padding(0);
            this.order_items_grid.Name = "order_items_grid";
            this.order_items_grid.Size = new System.Drawing.Size(371, 322);
            this.order_items_grid.TabIndex = 0;
            this.order_items_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.order_items_grid_CellContentClick);
            this.order_items_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.order_items_grid_CellContentClick);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancelBtn.Location = new System.Drawing.Point(12, 393);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(90, 23);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // payBtn
            // 
            this.payBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.payBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.payBtn.Location = new System.Drawing.Point(287, 393);
            this.payBtn.Name = "payBtn";
            this.payBtn.Size = new System.Drawing.Size(90, 23);
            this.payBtn.TabIndex = 2;
            this.payBtn.Text = "Pay";
            this.payBtn.UseVisualStyleBackColor = true;
            this.payBtn.Click += new System.EventHandler(this.payBtn_Click);
            // 
            // totalSumLbl
            // 
            this.totalSumLbl.AutoSize = true;
            this.totalSumLbl.Location = new System.Drawing.Point(12, 348);
            this.totalSumLbl.Name = "totalSumLbl";
            this.totalSumLbl.Padding = new System.Windows.Forms.Padding(10, 15, 3, 0);
            this.totalSumLbl.Size = new System.Drawing.Size(48, 28);
            this.totalSumLbl.TabIndex = 3;
            this.totalSumLbl.Text = "label1";
            this.totalSumLbl.Click += new System.EventHandler(this.totalSumLbl_Click);
            // 
            // item_name
            // 
            this.item_name.HeaderText = "Name";
            this.item_name.Name = "item_name";
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            // 
            // del
            // 
            this.del.HeaderText = "";
            this.del.Name = "del";
            this.del.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // order_item_id
            // 
            this.order_item_id.HeaderText = "order_item_id";
            this.order_item_id.Name = "order_item_id";
            this.order_item_id.Visible = false;
            // 
            // product_id
            // 
            this.product_id.HeaderText = "product_id";
            this.product_id.Name = "product_id";
            this.product_id.Visible = false;
            // 
            // Bag
            // 
            this.AcceptButton = this.payBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 428);
            this.Controls.Add(this.totalSumLbl);
            this.Controls.Add(this.payBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.order_items_grid);
            this.Name = "Bag";
            this.Text = "Bag";
            this.Load += new System.EventHandler(this.Bag_Load);
            ((System.ComponentModel.ISupportInitialize)(this.order_items_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView order_items_grid;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button payBtn;
        private System.Windows.Forms.Label totalSumLbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewImageColumn del;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_item_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_id;
    }
}