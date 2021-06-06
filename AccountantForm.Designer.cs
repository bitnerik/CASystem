
namespace CASystem
{
    partial class AccountantForm
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
            this.dateTimeFromPicker = new System.Windows.Forms.DateTimePicker();
            this.dateTimeTillPicker = new System.Windows.Forms.DateTimePicker();
            this.logOutButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.incomeBox = new System.Windows.Forms.TextBox();
            this.boughtBox = new System.Windows.Forms.TextBox();
            this.soldBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimeFromPicker
            // 
            this.dateTimeFromPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFromPicker.Location = new System.Drawing.Point(130, 71);
            this.dateTimeFromPicker.Name = "dateTimeFromPicker";
            this.dateTimeFromPicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimeFromPicker.TabIndex = 0;
            // 
            // dateTimeTillPicker
            // 
            this.dateTimeTillPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeTillPicker.Location = new System.Drawing.Point(130, 116);
            this.dateTimeTillPicker.Name = "dateTimeTillPicker";
            this.dateTimeTillPicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimeTillPicker.TabIndex = 1;
            // 
            // logOutButton
            // 
            this.logOutButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.logOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.logOutButton.Location = new System.Drawing.Point(212, 369);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(118, 41);
            this.logOutButton.TabIndex = 11;
            this.logOutButton.Text = "Log out";
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Date from";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date till";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(130, 158);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // incomeBox
            // 
            this.incomeBox.Location = new System.Drawing.Point(130, 215);
            this.incomeBox.Name = "incomeBox";
            this.incomeBox.Size = new System.Drawing.Size(100, 20);
            this.incomeBox.TabIndex = 5;
            // 
            // boughtBox
            // 
            this.boughtBox.Location = new System.Drawing.Point(130, 259);
            this.boughtBox.Name = "boughtBox";
            this.boughtBox.Size = new System.Drawing.Size(100, 20);
            this.boughtBox.TabIndex = 6;
            // 
            // soldBox
            // 
            this.soldBox.Location = new System.Drawing.Point(130, 304);
            this.soldBox.Name = "soldBox";
            this.soldBox.Size = new System.Drawing.Size(100, 20);
            this.soldBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Income";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sold";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(130, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Bought";
            // 
            // AccountantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.soldBox);
            this.Controls.Add(this.boughtBox);
            this.Controls.Add(this.incomeBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimeTillPicker);
            this.Controls.Add(this.dateTimeFromPicker);
            this.Name = "AccountantForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccountantForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimeFromPicker;
        private System.Windows.Forms.DateTimePicker dateTimeTillPicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox incomeBox;
        private System.Windows.Forms.TextBox boughtBox;
        private System.Windows.Forms.TextBox soldBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button logOutButton;
    }
}