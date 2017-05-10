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
    public partial class CreditCardEdit : Form
    {
        public CreditCardEdit(CreditCard credit)
        {
            InitializeComponent();

            nameTextBox.Text = credit.Name;
            numberTextBox.Text = credit.Number;

            //Making sure the information stays tidy inside the date textboxes.
            string[] temp1 = credit.StartDate.Split('/');
            startMonthTextBox.Text = temp1[0];
            startYearTextBox.Text = temp1[1];
            string[] temp2 = credit.ExpiryDate.Split('/');
            expiryMonthTextBox.Text = temp2[0];
            expiryYearTextBox.Text = temp2[1];

            nameOnCardTextBox.Text = credit.NameOnCard;
            cvcTextBox.Text = credit.CVC;
        }

        private void CreditCardEdit_Load(object sender, EventArgs e)
        {
            if (FieldsCompleted())
            {
                saveButton.Enabled = true;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void nameOnCardTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void numberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void startMonthTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void startYearTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void expiryMonthTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void expiryYearTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cvcTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (FieldsCompleted())
            {
                saveButton.Enabled = true;
            }
            else
            {
                saveButton.Enabled = false;
            }
        }

        private void numberTextBox_TextChanged(object sender, EventArgs e)
        {
            if (FieldsCompleted())
            {
                saveButton.Enabled = true;
            }
            else
            {
                saveButton.Enabled = false;
            }
        }

        private void expiryMonthTextBox_TextChanged(object sender, EventArgs e)
        {
            if (FieldsCompleted())
            {
                saveButton.Enabled = true;
            }
            else
            {
                saveButton.Enabled = false;
            }
        }

        private void expiryYearTextBox_TextChanged(object sender, EventArgs e)
        {
            if (FieldsCompleted())
            {
                saveButton.Enabled = true;
            }
            else
            {
                saveButton.Enabled = false;
            }
        }

        private void nameOnCardTextBox_TextChanged(object sender, EventArgs e)
        {
            if (FieldsCompleted())
            {
                saveButton.Enabled = true;
            }
            else
            {
                saveButton.Enabled = false;
            }
        }

        private void cvcTextBox_TextChanged(object sender, EventArgs e) 
        {
            if (FieldsCompleted())
            {
                saveButton.Enabled = true;
            }
            else
            {
                saveButton.Enabled = false;
            }
        }
        //
        //Checking to see if the form's textboxes are properly filled.
        //
        private bool FieldsCompleted()
        {
            //Not all credit cards have a start date, so the textboxes' 
            //completion is not mandatory.
            if (string.IsNullOrWhiteSpace(nameTextBox.Text) ||
                string.IsNullOrWhiteSpace(numberTextBox.Text) ||
                string.IsNullOrWhiteSpace(expiryMonthTextBox.Text) ||
                string.IsNullOrWhiteSpace(expiryYearTextBox.Text) ||
                string.IsNullOrWhiteSpace(nameOnCardTextBox.Text) ||
                string.IsNullOrWhiteSpace(cvcTextBox.Text)
                )
            {
                return false;
            }
            else
                return true;
        }
    }
}
