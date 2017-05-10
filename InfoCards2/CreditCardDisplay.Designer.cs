namespace Assignment
{
    partial class CreditCardDisplay
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numberLabel = new System.Windows.Forms.Label();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.expiryDateLabel = new System.Windows.Forms.Label();
            this.nameOnCardLabel = new System.Windows.Forms.Label();
            this.cvcLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameLabel.Location = new System.Drawing.Point(20, 7);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(108, 25);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Card Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Start Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Expiry Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 111);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Name On Card:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 132);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "CVC:";
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Location = new System.Drawing.Point(155, 43);
            this.numberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(103, 13);
            this.numberLabel.TabIndex = 6;
            this.numberLabel.Text = "1234123412341234";
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(155, 67);
            this.startDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(48, 13);
            this.startDateLabel.TabIndex = 7;
            this.startDateLabel.Text = "10/2016";
            // 
            // expiryDateLabel
            // 
            this.expiryDateLabel.AutoSize = true;
            this.expiryDateLabel.Location = new System.Drawing.Point(155, 89);
            this.expiryDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.expiryDateLabel.Name = "expiryDateLabel";
            this.expiryDateLabel.Size = new System.Drawing.Size(48, 13);
            this.expiryDateLabel.TabIndex = 8;
            this.expiryDateLabel.Text = "10/2017";
            // 
            // nameOnCardLabel
            // 
            this.nameOnCardLabel.AutoSize = true;
            this.nameOnCardLabel.Location = new System.Drawing.Point(155, 111);
            this.nameOnCardLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameOnCardLabel.Name = "nameOnCardLabel";
            this.nameOnCardLabel.Size = new System.Drawing.Size(59, 13);
            this.nameOnCardLabel.TabIndex = 9;
            this.nameOnCardLabel.Text = "John Smith";
            // 
            // cvcLabel
            // 
            this.cvcLabel.AutoSize = true;
            this.cvcLabel.Location = new System.Drawing.Point(155, 132);
            this.cvcLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cvcLabel.Name = "cvcLabel";
            this.cvcLabel.Size = new System.Drawing.Size(25, 13);
            this.cvcLabel.TabIndex = 10;
            this.cvcLabel.Text = "123";
            // 
            // CreditCardDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 256);
            this.Controls.Add(this.cvcLabel);
            this.Controls.Add(this.nameOnCardLabel);
            this.Controls.Add(this.expiryDateLabel);
            this.Controls.Add(this.startDateLabel);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreditCardDisplay";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Credit Card Data Display";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label nameLabel;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label numberLabel;
        public System.Windows.Forms.Label startDateLabel;
        public System.Windows.Forms.Label expiryDateLabel;
        public System.Windows.Forms.Label nameOnCardLabel;
        public System.Windows.Forms.Label cvcLabel;
    }
}