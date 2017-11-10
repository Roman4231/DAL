namespace shop_UI
{
    partial class Profile
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("orders", System.Windows.Forms.HorizontalAlignment.Left);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginLbl = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this.ordersLV = new System.Windows.Forms.ListView();
            this.item_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.totalPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 26);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.label2.Size = new System.Drawing.Size(35, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email:";
            // 
            // loginLbl
            // 
            this.loginLbl.AutoSize = true;
            this.loginLbl.Location = new System.Drawing.Point(61, 13);
            this.loginLbl.Name = "loginLbl";
            this.loginLbl.Size = new System.Drawing.Size(35, 13);
            this.loginLbl.TabIndex = 2;
            this.loginLbl.Text = "label3";
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Location = new System.Drawing.Point(61, 41);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(35, 13);
            this.emailLbl.TabIndex = 3;
            this.emailLbl.Text = "label3";
            // 
            // ordersLV
            // 
            this.ordersLV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ordersLV.BackColor = System.Drawing.SystemColors.Control;
            this.ordersLV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ordersLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.item_name,
            this.price,
            this.quantity,
            this.totalPrice});
            listViewGroup1.Header = "orders";
            listViewGroup1.Name = "listViewGroup1";
            this.ordersLV.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.ordersLV.Location = new System.Drawing.Point(14, 57);
            this.ordersLV.Name = "ordersLV";
            this.ordersLV.Size = new System.Drawing.Size(628, 368);
            this.ordersLV.TabIndex = 4;
            this.ordersLV.UseCompatibleStateImageBehavior = false;
            this.ordersLV.View = System.Windows.Forms.View.Details;
            // 
            // item_name
            // 
            this.item_name.Text = "Name";
            this.item_name.Width = 132;
            // 
            // price
            // 
            this.price.Text = "Price";
            this.price.Width = 129;
            // 
            // quantity
            // 
            this.quantity.Text = "Quantity";
            this.quantity.Width = 150;
            // 
            // totalPrice
            // 
            this.totalPrice.Text = "Total Price";
            this.totalPrice.Width = 216;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 437);
            this.Controls.Add(this.ordersLV);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.loginLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Profile";
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.Profile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label loginLbl;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.ListView ordersLV;
        private System.Windows.Forms.ColumnHeader item_name;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.ColumnHeader quantity;
        private System.Windows.Forms.ColumnHeader totalPrice;
    }
}