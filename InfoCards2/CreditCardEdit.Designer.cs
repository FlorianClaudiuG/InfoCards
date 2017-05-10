namespace Assignment
{
    partial class CreditCardEdit
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameOnCardTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.startMonthTextBox = new System.Windows.Forms.TextBox();
            this.startYearTextBox = new System.Windows.Forms.TextBox();
            this.expiryMonthTextBox = new System.Windows.Forms.TextBox();
            this.expiryYearTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.cvcTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(147, 26);
            this.nameTextBox.MaxLength = 50;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(232, 22);
            this.nameTextBox.TabIndex = 6;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // nameOnCardTextBox
            // 
            this.nameOnCardTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nameOnCardTextBox.Location = new System.Drawing.Point(147, 192);
            this.nameOnCardTextBox.MaxLength = 50;
            this.nameOnCardTextBox.Name = "nameOnCardTextBox";
            this.nameOnCardTextBox.Size = new System.Drawing.Size(232, 22);
            this.nameOnCardTextBox.TabIndex = 7;
            this.nameOnCardTextBox.TextChanged += new System.EventHandler(this.nameOnCardTextBox_TextChanged);
            this.nameOnCardTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameOnCardTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Card Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Card Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Start Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Expiry Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Name On Card:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "CVC:";
            // 
            // startMonthTextBox
            // 
            this.startMonthTextBox.Location = new System.Drawing.Point(147, 107);
            this.startMonthTextBox.MaxLength = 2;
            this.startMonthTextBox.Name = "startMonthTextBox";
            this.startMonthTextBox.Size = new System.Drawing.Size(55, 22);
            this.startMonthTextBox.TabIndex = 14;
            this.startMonthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.startMonthTextBox_KeyPress);
            // 
            // startYearTextBox
            // 
            this.startYearTextBox.Location = new System.Drawing.Point(226, 107);
            this.startYearTextBox.MaxLength = 4;
            this.startYearTextBox.Name = "startYearTextBox";
            this.startYearTextBox.Size = new System.Drawing.Size(88, 22);
            this.startYearTextBox.TabIndex = 15;
            this.startYearTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.startYearTextBox_KeyPress);
            // 
            // expiryMonthTextBox
            // 
            this.expiryMonthTextBox.Location = new System.Drawing.Point(147, 148);
            this.expiryMonthTextBox.MaxLength = 2;
            this.expiryMonthTextBox.Name = "expiryMonthTextBox";
            this.expiryMonthTextBox.Size = new System.Drawing.Size(55, 22);
            this.expiryMonthTextBox.TabIndex = 16;
            this.expiryMonthTextBox.TextChanged += new System.EventHandler(this.expiryMonthTextBox_TextChanged);
            this.expiryMonthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.expiryMonthTextBox_KeyPress);
            // 
            // expiryYearTextBox
            // 
            this.expiryYearTextBox.Location = new System.Drawing.Point(226, 148);
            this.expiryYearTextBox.MaxLength = 4;
            this.expiryYearTextBox.Name = "expiryYearTextBox";
            this.expiryYearTextBox.Size = new System.Drawing.Size(88, 22);
            this.expiryYearTextBox.TabIndex = 17;
            this.expiryYearTextBox.TextChanged += new System.EventHandler(this.expiryYearTextBox_TextChanged);
            this.expiryYearTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.expiryYearTextBox_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(208, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "/";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(208, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "/";
            // 
            // saveButton
            // 
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(78, 299);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(107, 39);
            this.saveButton.TabIndex = 20;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(242, 299);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(107, 39);
            this.cancelButton.TabIndex = 21;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // numberTextBox
            // 
            this.numberTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.numberTextBox.Location = new System.Drawing.Point(147, 68);
            this.numberTextBox.MaxLength = 16;
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(232, 22);
            this.numberTextBox.TabIndex = 22;
            this.numberTextBox.TextChanged += new System.EventHandler(this.numberTextBox_TextChanged);
            this.numberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberTextBox_KeyPress);
            // 
            // cvcTextBox
            // 
            this.cvcTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cvcTextBox.Location = new System.Drawing.Point(147, 229);
            this.cvcTextBox.MaxLength = 3;
            this.cvcTextBox.Name = "cvcTextBox";
            this.cvcTextBox.Size = new System.Drawing.Size(55, 22);
            this.cvcTextBox.TabIndex = 23;
            this.cvcTextBox.TextChanged += new System.EventHandler(this.cvcTextBox_TextChanged);
            this.cvcTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cvcTextBox_KeyPress);
            // 
            // CreditCardEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 367);
            this.Controls.Add(this.cvcTextBox);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.expiryYearTextBox);
            this.Controls.Add(this.expiryMonthTextBox);
            this.Controls.Add(this.startYearTextBox);
            this.Controls.Add(this.startMonthTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameOnCardTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Name = "CreditCardEdit";
            this.Text = "Edit Credit Card Data";
            this.Load += new System.EventHandler(this.CreditCardEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        public System.Windows.Forms.TextBox nameTextBox;
        public System.Windows.Forms.TextBox nameOnCardTextBox;
        public System.Windows.Forms.TextBox startMonthTextBox;
        public System.Windows.Forms.TextBox startYearTextBox;
        public System.Windows.Forms.TextBox expiryMonthTextBox;
        public System.Windows.Forms.TextBox expiryYearTextBox;
        public System.Windows.Forms.TextBox numberTextBox;
        public System.Windows.Forms.TextBox cvcTextBox;
    }
}