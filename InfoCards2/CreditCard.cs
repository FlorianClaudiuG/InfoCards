using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Assignment
{
    public class CreditCard : IInfoCard
    {
        private string category = "Credit Card";

        //Initialising everything to the empty string and "/" respectively to avoid unwanted exceptions.
        private string name = "";
        private string number = "";
        private string startDate = "/";
        private string expiryDate = "/";
        private string nameOnCard = "";
        private string cvc = "";

        //Global declaration required so the form in the DisplayData and CloseDisplay methods is the same one.
        CreditCardDisplay form = null;

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
        public string Number
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
            }
        }
        public string StartDate
        {
            get
            {
                return startDate;
            }
            set
            {
                startDate = value;
            }
        }
        public string ExpiryDate
        {
            get
            {
                return expiryDate;
            }
            set
            {
                expiryDate = value;
            }
        }
        public string NameOnCard
        {
            get
            {
                return nameOnCard;
            }
            set
            {
                nameOnCard = value;
            }
        }
        public string CVC
        {
            get
            {
                return cvc;
            }
            set
            {
                cvc = value;
            }
        }

        public CreditCard()
        {

        }

        public CreditCard(string data)
        {
            string[] temp = data.Split('|');
            name = temp[1];
            number = temp[2];
            startDate = temp[3];
            expiryDate = temp[4]; 
            nameOnCard = temp[5];
            cvc = temp[6];
        }

        public string GetDataAsString()
        {
            return category + "|"
                 + name + "|"
                 + number + "|"
                 + startDate + "|"
                 + expiryDate + "|"
                 + nameOnCard + "|"
                 + cvc;
        }

        public void DisplayData(Panel displayPanel)
        {
            form = new CreditCardDisplay(this); 
             
            //This is for the form to display inside the panel.
            form.TopLevel = false;
            form.AutoScroll = true;
            form.FormBorderStyle = FormBorderStyle.None; 
            displayPanel.Controls.Add(form);
            form.Show();
        }
        
        public void CloseDisplay()
        {
            form.Close();
            form.Dispose();
        }

        public bool EditData()
        {
            //Loading the edit form as a modal dialog box.
            CreditCardEdit editForm = new CreditCardEdit(this);
            editForm.ShowDialog();

            if (editForm.DialogResult == DialogResult.OK)
            {
                name = editForm.nameTextBox.Text;
                number = editForm.numberTextBox.Text;
                startDate = editForm.startMonthTextBox.Text + '/' + editForm.startYearTextBox.Text;
                expiryDate = editForm.expiryMonthTextBox.Text + '/' + editForm.expiryYearTextBox.Text;
                nameOnCard = editForm.nameOnCardTextBox.Text;
                cvc = editForm.cvcTextBox.Text;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
