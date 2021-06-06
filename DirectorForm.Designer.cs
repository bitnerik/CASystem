﻿
namespace CASystem
{
    partial class DirectorForm
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
            this.Insert = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.logOutButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.soldBox = new System.Windows.Forms.TextBox();
            this.boughtBox = new System.Windows.Forms.TextBox();
            this.incomeBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimeTillPicker = new System.Windows.Forms.DateTimePicker();
            this.dateTimeFromPicker = new System.Windows.Forms.DateTimePicker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.boughtRadioButton = new System.Windows.Forms.RadioButton();
            this.soldRadioButton = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.productTypeBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.cADBDataSet1 = new CASystem.CADBDataSet1();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productTypeBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.cADBDataSet = new CASystem.CADBDataSet();
            this.productTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTypeTableAdapter = new CASystem.CADBDataSetTableAdapters.ProductTypeTableAdapter();
            this.productTypeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productTypeTableAdapter1 = new CASystem.CADBDataSet1TableAdapters.ProductTypeTableAdapter();
            this.Insert.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cADBDataSet1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cADBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Insert
            // 
            this.Insert.Controls.Add(this.tabPage1);
            this.Insert.Controls.Add(this.tabPage2);
            this.Insert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Insert.Location = new System.Drawing.Point(0, 0);
            this.Insert.Name = "Insert";
            this.Insert.SelectedIndex = 0;
            this.Insert.Size = new System.Drawing.Size(967, 468);
            this.Insert.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.logOutButton);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.soldBox);
            this.tabPage1.Controls.Add(this.boughtBox);
            this.tabPage1.Controls.Add(this.incomeBox);
            this.tabPage1.Controls.Add(this.calculateButton);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dateTimeTillPicker);
            this.tabPage1.Controls.Add(this.dateTimeFromPicker);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(959, 442);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Count money";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // logOutButton
            // 
            this.logOutButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.logOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.logOutButton.Location = new System.Drawing.Point(807, 17);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(118, 41);
            this.logOutButton.TabIndex = 11;
            this.logOutButton.Text = "Log out";
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(326, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Bought";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(326, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sold";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Income";
            // 
            // soldBox
            // 
            this.soldBox.Location = new System.Drawing.Point(323, 294);
            this.soldBox.Name = "soldBox";
            this.soldBox.Size = new System.Drawing.Size(100, 20);
            this.soldBox.TabIndex = 7;
            // 
            // boughtBox
            // 
            this.boughtBox.Location = new System.Drawing.Point(323, 249);
            this.boughtBox.Name = "boughtBox";
            this.boughtBox.Size = new System.Drawing.Size(100, 20);
            this.boughtBox.TabIndex = 6;
            // 
            // incomeBox
            // 
            this.incomeBox.Location = new System.Drawing.Point(323, 205);
            this.incomeBox.Name = "incomeBox";
            this.incomeBox.Size = new System.Drawing.Size(100, 20);
            this.incomeBox.TabIndex = 5;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(323, 148);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date till";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Date from";
            // 
            // dateTimeTillPicker
            // 
            this.dateTimeTillPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeTillPicker.Location = new System.Drawing.Point(323, 106);
            this.dateTimeTillPicker.Name = "dateTimeTillPicker";
            this.dateTimeTillPicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimeTillPicker.TabIndex = 1;
            // 
            // dateTimeFromPicker
            // 
            this.dateTimeFromPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFromPicker.Location = new System.Drawing.Point(323, 61);
            this.dateTimeFromPicker.Name = "dateTimeFromPicker";
            this.dateTimeFromPicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimeFromPicker.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.boughtRadioButton);
            this.tabPage2.Controls.Add(this.soldRadioButton);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.textBox7);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(959, 442);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Count product";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // boughtRadioButton
            // 
            this.boughtRadioButton.AutoSize = true;
            this.boughtRadioButton.Location = new System.Drawing.Point(161, 407);
            this.boughtRadioButton.Name = "boughtRadioButton";
            this.boughtRadioButton.Size = new System.Drawing.Size(103, 17);
            this.boughtRadioButton.TabIndex = 8;
            this.boughtRadioButton.Text = "Bought products";
            this.boughtRadioButton.UseVisualStyleBackColor = true;
            this.boughtRadioButton.CheckedChanged += new System.EventHandler(this.boughtRadioButton_CheckedChanged);
            // 
            // soldRadioButton
            // 
            this.soldRadioButton.AutoSize = true;
            this.soldRadioButton.Checked = true;
            this.soldRadioButton.Location = new System.Drawing.Point(161, 388);
            this.soldRadioButton.Name = "soldRadioButton";
            this.soldRadioButton.Size = new System.Drawing.Size(90, 17);
            this.soldRadioButton.TabIndex = 7;
            this.soldRadioButton.TabStop = true;
            this.soldRadioButton.Text = "Sold products";
            this.soldRadioButton.UseVisualStyleBackColor = true;
            this.soldRadioButton.CheckedChanged += new System.EventHandler(this.soldRadioButton_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label8.Location = new System.Drawing.Point(417, 387);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Result";
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBox7.Location = new System.Drawing.Point(420, 403);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productTypeBindingSource2, "ProductTypeID", true));
            this.comboBox1.DataSource = this.productTypeBindingSource2;
            this.comboBox1.DisplayMember = "TypeName";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(8, 403);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.ValueMember = "ProductTypeID";
            // 
            // productTypeBindingSource2
            // 
            this.productTypeBindingSource2.DataMember = "ProductType";
            this.productTypeBindingSource2.DataSource = this.cADBDataSet1;
            // 
            // cADBDataSet1
            // 
            this.cADBDataSet1.DataSetName = "CADBDataSet1";
            this.cADBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label7.Location = new System.Drawing.Point(5, 387);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Type ID";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(303, 387);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 37);
            this.button2.TabIndex = 1;
            this.button2.Text = "Count";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button21_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(957, 371);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(951, 365);
            this.dataGridView1.TabIndex = 1;
            // 
            // productTypeBindingSource3
            // 
            this.productTypeBindingSource3.DataMember = "ProductType";
            this.productTypeBindingSource3.DataSource = this.cADBDataSet;
            // 
            // cADBDataSet
            // 
            this.cADBDataSet.DataSetName = "CADBDataSet";
            this.cADBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productTypeBindingSource
            // 
            this.productTypeBindingSource.DataMember = "ProductType";
            this.productTypeBindingSource.DataSource = this.cADBDataSet;
            // 
            // productTypeTableAdapter
            // 
            this.productTypeTableAdapter.ClearBeforeFill = true;
            // 
            // productTypeBindingSource1
            // 
            this.productTypeBindingSource1.DataMember = "ProductType";
            this.productTypeBindingSource1.DataSource = this.cADBDataSet;
            // 
            // productTypeTableAdapter1
            // 
            this.productTypeTableAdapter1.ClearBeforeFill = true;
            // 
            // DirectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 468);
            this.Controls.Add(this.Insert);
            this.Name = "DirectorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager";
            this.Load += new System.EventHandler(this.DirectorForm_Load);
            this.Insert.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cADBDataSet1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cADBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Insert;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private CADBDataSet cADBDataSet;
        private System.Windows.Forms.BindingSource productTypeBindingSource;
        private CADBDataSetTableAdapters.ProductTypeTableAdapter productTypeTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource productTypeBindingSource1;
        private CADBDataSet1 cADBDataSet1;
        private System.Windows.Forms.BindingSource productTypeBindingSource2;
        private CADBDataSet1TableAdapters.ProductTypeTableAdapter productTypeTableAdapter1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.BindingSource productTypeBindingSource3;
        private System.Windows.Forms.RadioButton boughtRadioButton;
        private System.Windows.Forms.RadioButton soldRadioButton;


        // Accountant
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