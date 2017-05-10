namespace Assignment
{
    partial class UniCardEdit
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.issueDayTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.issueYearTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.issueMonthComboBox = new System.Windows.Forms.ComboBox();
            this.expiresTextBox = new System.Windows.Forms.TextBox();
            this.barcodeTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 99);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Issue Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Expires(Year):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 180);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Barcode:";
            // 
            // saveButton
            // 
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(40, 232);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(80, 32);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(188, 232);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(80, 32);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(101, 58);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nameTextBox.MaxLength = 50;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(175, 20);
            this.nameTextBox.TabIndex = 7;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            this.nameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameTextBox_KeyPress);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(101, 20);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.usernameTextBox.MaxLength = 9;
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(175, 20);
            this.usernameTextBox.TabIndex = 8;
            this.usernameTextBox.TextChanged += new System.EventHandler(this.usernameTextBox_TextChanged);
            this.usernameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.usernameTextBox_KeyPress);
            // 
            // issueDayTextBox
            // 
            this.issueDayTextBox.Location = new System.Drawing.Point(101, 97);
            this.issueDayTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.issueDayTextBox.MaxLength = 2;
            this.issueDayTextBox.Name = "issueDayTextBox";
            this.issueDayTextBox.Size = new System.Drawing.Size(31, 20);
            this.issueDayTextBox.TabIndex = 9;
            this.issueDayTextBox.TextChanged += new System.EventHandler(this.issueDayTextBox_TextChanged);
            this.issueDayTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.issueDayTextBox_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(136, 99);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "/";
            // 
            // issueYearTextBox
            // 
            this.issueYearTextBox.Location = new System.Drawing.Point(218, 97);
            this.issueYearTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.issueYearTextBox.MaxLength = 4;
            this.issueYearTextBox.Name = "issueYearTextBox";
            this.issueYearTextBox.Size = new System.Drawing.Size(59, 20);
            this.issueYearTextBox.TabIndex = 11;
            this.issueYearTextBox.TextChanged += new System.EventHandler(this.issueYearTextBox_TextChanged);
            this.issueYearTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.issueYearTextBox_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(204, 99);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "/";
            // 
            // issueMonthComboBox
            // 
            this.issueMonthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.issueMonthComboBox.FormattingEnabled = true;
            this.issueMonthComboBox.Items.AddRange(new object[] {
            "JAN",
            "FEB",
            "MAR",
            "APR",
            "MAY",
            "JUN",
            "JUL",
            "AUG",
            "SEP",
            "OCT",
            "NOV",
            "DEC"});
            this.issueMonthComboBox.Location = new System.Drawing.Point(149, 97);
            this.issueMonthComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.issueMonthComboBox.Name = "issueMonthComboBox";
            this.issueMonthComboBox.Size = new System.Drawing.Size(51, 21);
            this.issueMonthComboBox.TabIndex = 13;
            this.issueMonthComboBox.SelectedIndexChanged += new System.EventHandler(this.issueMonthComboBox_SelectedIndexChanged);
            // 
            // expiresTextBox
            // 
            this.expiresTextBox.Location = new System.Drawing.Point(101, 137);
            this.expiresTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.expiresTextBox.MaxLength = 4;
            this.expiresTextBox.Name = "expiresTextBox";
            this.expiresTextBox.Size = new System.Drawing.Size(59, 20);
            this.expiresTextBox.TabIndex = 14;
            this.expiresTextBox.TextChanged += new System.EventHandler(this.expiresTextBox_TextChanged);
            this.expiresTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.expiresTextBox_KeyPress);
            // 
            // barcodeTextBox
            // 
            this.barcodeTextBox.Location = new System.Drawing.Point(101, 178);
            this.barcodeTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.barcodeTextBox.MaxLength = 9;
            this.barcodeTextBox.Name = "barcodeTextBox";
            this.barcodeTextBox.Size = new System.Drawing.Size(175, 20);
            this.barcodeTextBox.TabIndex = 15;
            this.barcodeTextBox.TextChanged += new System.EventHandler(this.barcodeTextBox_TextChanged);
            // 
            // UniCardEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 298);
            this.Controls.Add(this.barcodeTextBox);
            this.Controls.Add(this.expiresTextBox);
            this.Controls.Add(this.issueMonthComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.issueYearTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.issueDayTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UniCardEdit";
            this.Text = "Edit Uni Card Data";
            this.Load += new System.EventHandler(this.UniCardEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        public System.Windows.Forms.TextBox nameTextBox;
        public System.Windows.Forms.TextBox usernameTextBox;
        public System.Windows.Forms.TextBox issueDayTextBox;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox issueYearTextBox;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox expiresTextBox;
        public System.Windows.Forms.TextBox barcodeTextBox;
        public System.Windows.Forms.ComboBox issueMonthComboBox;
    }
}