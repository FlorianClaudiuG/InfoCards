using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public class UniCard : IInfoCard
    {
        private string username = "";
        private string name = "";
        private string issueDate = "//";
        private string expires = "";
        private string barcode = "";
        private string category = "University Card";

        UniCardDisplay form = null;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Category
        {
            get
            {
                return category;
            }
        }
        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }
        public string IssueDate
        {
            get
            {
                return issueDate;
            }
            set
            {
                issueDate = value;
            }
        }
        public string Expires
        {
            get
            {
                return expires;
            }
            set
            {
                expires = value;
            }
        }
        public string Barcode
        {
            get
            {
                return barcode;
            }
            set
            {
                barcode = value;
            }
        }

        public string GetDataAsString()
        {
            return category + "|"
                 + username + "|"
                 + name + "|"
                 + issueDate + "|"
                 + expires + "|"
                 + barcode;
        }

        public UniCard()
        {

        }

        public UniCard(string data)
        {
            string[] temp = data.Split('|');
            username = temp[1];
            name = temp[2];
            issueDate = temp[3];
            expires = temp[4];
            barcode = temp[5];
        }

        public void DisplayData(Panel displayPanel)
        {
            form = new UniCardDisplay(this);

            form.TopLevel = false;
            form.AutoScroll = true;
            form.FormBorderStyle = FormBorderStyle.None;
            displayPanel.Controls.Add(form);
            form.Show();
        }

        public bool EditData()
        {
            UniCardEdit editForm = new UniCardEdit(this);
            editForm.ShowDialog();

            if (editForm.DialogResult == DialogResult.OK)
            {
                name = editForm.nameTextBox.Text;
                username = editForm.usernameTextBox.Text;

                issueDate = editForm.issueDayTextBox.Text + '/' 
                          + editForm.issueMonthComboBox.Text + '/' 
                          + editForm.issueYearTextBox.Text;

                expires = editForm.expiresTextBox.Text;
                barcode = editForm.barcodeTextBox.Text;
                return true;
            }
            else
            {
                return false;
            }         
        }

        public void CloseDisplay()
        {
            form.Close();
            form.Dispose();
        }
    }
}    
