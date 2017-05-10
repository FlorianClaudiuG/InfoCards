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
    public partial class UniCardEdit : Form
    {
        public UniCardEdit(UniCard uni)
        {
            InitializeComponent();
            usernameTextBox.Text = uni.Username;
            nameTextBox.Text = uni.Name;

            string[] temp = uni.IssueDate.Split('/');
            issueDayTextBox.Text = temp[0];
            issueMonthComboBox.Text = temp[1];
            issueYearTextBox.Text = temp[2];

            expiresTextBox.Text = uni.Expires;
            barcodeTextBox.Text = uni.Barcode;
        }

        private void UniCardEdit_Load(object sender, EventArgs e)
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

        private void usernameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void nameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void issueDayTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void issueYearTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void expiresTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
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

        private void issueDayTextBox_TextChanged(object sender, EventArgs e)
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

        private void issueMonthComboBox_SelectedIndexChanged(object sender, EventArgs e)
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

        private void issueYearTextBox_TextChanged(object sender, EventArgs e)
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

        private void expiresTextBox_TextChanged(object sender, EventArgs e)
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

        private void barcodeTextBox_TextChanged(object sender, EventArgs e)
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

        private bool FieldsCompleted()
        {
            if (string.IsNullOrWhiteSpace(usernameTextBox.Text) ||
                string.IsNullOrWhiteSpace(nameTextBox.Text) ||
                string.IsNullOrWhiteSpace(issueDayTextBox.Text) ||
                string.IsNullOrWhiteSpace(issueMonthComboBox.Text) ||
                string.IsNullOrWhiteSpace(issueYearTextBox.Text) ||
                string.IsNullOrWhiteSpace(expiresTextBox.Text) ||
                string.IsNullOrWhiteSpace(barcodeTextBox.Text)
                )
            {
                return false;
            }
            else
                return true;
        }


    }
}