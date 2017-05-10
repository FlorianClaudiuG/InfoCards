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
    public partial class CreditCardDisplay : Form
    {
        public CreditCardDisplay(CreditCard credit)
        {
            InitializeComponent();

            nameLabel.Text = credit.Name;
            numberLabel.Text = credit.Number;
            startDateLabel.Text = credit.StartDate;
            expiryDateLabel.Text = credit.ExpiryDate;
            nameOnCardLabel.Text = credit.NameOnCard;
            cvcLabel.Text = credit.CVC;
        }
    }
}
