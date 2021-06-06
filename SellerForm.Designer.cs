
namespace CASystem
{
    partial class SellerForm
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
            this.productListBox = new System.Windows.Forms.CheckedListBox();
            this.checkProductButton = new System.Windows.Forms.Button();
            this.brandTextBox = new System.Windows.Forms.TextBox();
            this.logOutButton = new System.Windows.Forms.Button();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.brandHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.modelHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sellPriceHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.availableHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.showOnlyAvailableCheckBox = new System.Windows.Forms.CheckBox();
            this.sellButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // productListBox
            // 
            this.productListBox.FormattingEnabled = true;
            this.productListBox.Location = new System.Drawing.Point(61, 95);
            this.productListBox.Name = "productListBox";
            this.productListBox.Size = new System.Drawing.Size(18, 244);
            this.productListBox.TabIndex = 0;
            // 
            // checkProductButton
            // 
            this.checkProductButton.Location = new System.Drawing.Point(488, 38);
            this.checkProductButton.Name = "checkProductButton";
            this.checkProductButton.Size = new System.Drawing.Size(129, 23);
            this.checkProductButton.TabIndex = 1;
            this.checkProductButton.Text = "Check product";
            this.checkProductButton.UseVisualStyleBackColor = true;
            this.checkProductButton.Click += new System.EventHandler(this.checkProductButton_Click);
            // 
            // brandTextBox
            // 
            this.brandTextBox.Location = new System.Drawing.Point(58, 41);
            this.brandTextBox.Name = "brandTextBox";
            this.brandTextBox.Size = new System.Drawing.Size(203, 20);
            this.brandTextBox.TabIndex = 2;
            // 
            // logOutButton
            // 
            this.logOutButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.logOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.logOutButton.Location = new System.Drawing.Point(499, 346);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(118, 41);
            this.logOutButton.TabIndex = 11;
            this.logOutButton.Text = "Log out";
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // modelTextBox
            // 
            this.modelTextBox.Location = new System.Drawing.Point(267, 40);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(201, 20);
            this.modelTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Brand";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Model";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.brandHeader,
            this.modelHeader,
            this.sellPriceHeader,
            this.availableHeader});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(78, 70);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(539, 269);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // brandHeader
            // 
            this.brandHeader.Text = "Brand";
            this.brandHeader.Width = 216;
            // 
            // modelHeader
            // 
            this.modelHeader.Text = "Model";
            this.modelHeader.Width = 172;
            // 
            // sellPriceHeader
            // 
            this.sellPriceHeader.Text = "Price";
            this.sellPriceHeader.Width = 65;
            // 
            // availableHeader
            // 
            this.availableHeader.Text = "Is Available";
            this.availableHeader.Width = 75;
            // 
            // showOnlyAvailableCheckBox
            // 
            this.showOnlyAvailableCheckBox.AutoSize = true;
            this.showOnlyAvailableCheckBox.Checked = true;
            this.showOnlyAvailableCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showOnlyAvailableCheckBox.Location = new System.Drawing.Point(488, 21);
            this.showOnlyAvailableCheckBox.Name = "showOnlyAvailableCheckBox";
            this.showOnlyAvailableCheckBox.Size = new System.Drawing.Size(120, 17);
            this.showOnlyAvailableCheckBox.TabIndex = 7;
            this.showOnlyAvailableCheckBox.Text = "Show only available";
            this.showOnlyAvailableCheckBox.UseVisualStyleBackColor = true;
            // 
            // sellButton
            // 
            this.sellButton.Location = new System.Drawing.Point(61, 346);
            this.sellButton.Name = "sellButton";
            this.sellButton.Size = new System.Drawing.Size(75, 23);
            this.sellButton.TabIndex = 8;
            this.sellButton.Text = "Sell";
            this.sellButton.UseVisualStyleBackColor = true;
            this.sellButton.Click += new System.EventHandler(this.sellButton_Click);
            // 
            // SellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 450);
            this.Controls.Add(this.sellButton);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.showOnlyAvailableCheckBox);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(this.brandTextBox);
            this.Controls.Add(this.checkProductButton);
            this.Controls.Add(this.productListBox);
            this.Name = "SellerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox productListBox;
        private System.Windows.Forms.Button checkProductButton;
        private System.Windows.Forms.TextBox brandTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader brandHeader;
        private System.Windows.Forms.ColumnHeader modelHeader;
        private System.Windows.Forms.ColumnHeader sellPriceHeader;
        private System.Windows.Forms.ColumnHeader availableHeader;
        private System.Windows.Forms.CheckBox showOnlyAvailableCheckBox;
        private System.Windows.Forms.Button sellButton;
        private System.Windows.Forms.Button logOutButton;
    }
}