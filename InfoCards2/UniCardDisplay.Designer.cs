namespace Assignment
{
    partial class UniCardDisplay
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
            this.usernameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.issueDateLabel = new System.Windows.Forms.Label();
            this.expiresLabel = new System.Windows.Forms.Label();
            this.barcodeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.usernameLabel.Location = new System.Drawing.Point(31, 9);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(144, 31);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "000000000";
            this.usernameLabel.UseMnemonic = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Issue Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Expires:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Barcode:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(214, 54);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(78, 17);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = "John Smith";
            // 
            // issueDateLabel
            // 
            this.issueDateLabel.AutoSize = true;
            this.issueDateLabel.Location = new System.Drawing.Point(214, 82);
            this.issueDateLabel.Name = "issueDateLabel";
            this.issueDateLabel.Size = new System.Drawing.Size(91, 17);
            this.issueDateLabel.TabIndex = 8;
            this.issueDateLabel.Text = "15/SEP/2016";
            // 
            // expiresLabel
            // 
            this.expiresLabel.AutoSize = true;
            this.expiresLabel.Location = new System.Drawing.Point(214, 109);
            this.expiresLabel.Name = "expiresLabel";
            this.expiresLabel.Size = new System.Drawing.Size(40, 17);
            this.expiresLabel.TabIndex = 9;
            this.expiresLabel.Text = "2018";
            // 
            // barcodeLabel
            // 
            this.barcodeLabel.AutoSize = true;
            this.barcodeLabel.Location = new System.Drawing.Point(214, 137);
            this.barcodeLabel.Name = "barcodeLabel";
            this.barcodeLabel.Size = new System.Drawing.Size(81, 17);
            this.barcodeLabel.TabIndex = 10;
            this.barcodeLabel.Text = "P12345678";
            // 
            // UniCardDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 315);
            this.Controls.Add(this.barcodeLabel);
            this.Controls.Add(this.expiresLabel);
            this.Controls.Add(this.issueDateLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usernameLabel);
            this.Name = "UniCardDisplay";
            this.Text = "UniCardDisplay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label nameLabel;
        public System.Windows.Forms.Label issueDateLabel;
        public System.Windows.Forms.Label expiresLabel;
        public System.Windows.Forms.Label barcodeLabel;
    }
}