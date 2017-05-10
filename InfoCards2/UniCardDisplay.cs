using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class UniCardDisplay : Form
    {
        public UniCardDisplay(UniCard uni)
        {
            InitializeComponent();

            usernameLabel.Text = uni.Username;
            nameLabel.Text = uni.Name;
            issueDateLabel.Text = uni.IssueDate;
            expiresLabel.Text = uni.Expires;
            barcodeLabel.Text = uni.Barcode;
        }
    }
}
