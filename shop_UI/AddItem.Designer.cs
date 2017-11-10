namespace shop_UI
{
    partial class AddItem
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
            this.itemName = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.amountPicker = new System.Windows.Forms.NumericUpDown();
            this.submit = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.amountPicker)).BeginInit();
            this.SuspendLayout();
            // 
            // itemName
            // 
            this.itemName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.itemName.AutoSize = true;
            this.itemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.itemName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.itemName.Location = new System.Drawing.Point(73, 60);
            this.itemName.Name = "itemName";
            this.itemName.Size = new System.Drawing.Size(103, 37);
            this.itemName.TabIndex = 0;
            this.itemName.Text = "Name";
            // 
            // priceLabel
            // 
            this.priceLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceLabel.Location = new System.Drawing.Point(347, 62);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(49, 36);
            this.priceLabel.TabIndex = 1;
            this.priceLabel.Text = "33";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionLabel.Location = new System.Drawing.Point(75, 98);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(234, 168);
            this.descriptionLabel.TabIndex = 3;
            this.descriptionLabel.Text = "some text (description) about product";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(349, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Choose amount";
            // 
            // amountPicker
            // 
            this.amountPicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.amountPicker.Location = new System.Drawing.Point(353, 121);
            this.amountPicker.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.amountPicker.Name = "amountPicker";
            this.amountPicker.Size = new System.Drawing.Size(118, 20);
            this.amountPicker.TabIndex = 5;
            this.amountPicker.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.amountPicker.ValueChanged += new System.EventHandler(this.amountPicker_ValueChanged);
            // 
            // submit
            // 
            this.submit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.submit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.submit.Location = new System.Drawing.Point(391, 269);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(80, 23);
            this.submit.TabIndex = 6;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // cancel
            // 
            this.cancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel.Location = new System.Drawing.Point(79, 269);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(80, 23);
            this.cancel.TabIndex = 7;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // AddItem
            // 
            this.AcceptButton = this.submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 364);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.amountPicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.itemName);
            this.Name = "AddItem";
            this.Text = "AddItem";
            this.Load += new System.EventHandler(this.AddItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.amountPicker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label itemName;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown amountPicker;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button cancel;
    }
}