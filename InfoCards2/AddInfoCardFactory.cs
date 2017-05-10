using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class AddInfoCardFactory : IInfoCardFactory 
    {
        string[] categoriesSupported = { "Credit Card", "University Card" };

        public IInfoCard CreateNewInfoCard(string category)
        {
            switch (category)
            {
                case "Credit Card":
                    return new CreditCard();
                case "University Card":
                    return new UniCard();
                default:
                    return null;
            }
        }

        public IInfoCard CreateInfoCard(string initialDetails)
        {
            string[] temp = initialDetails.Split('|');
            string category = temp[0];
            switch (category)
            {
                case "Credit Card":
                    return new CreditCard(initialDetails);
                case "University Card":
                    return new UniCard(initialDetails);
                default:
                    return null;
            }
        }

        public string[] CategoriesSupported
        {
            get
            {
                return categoriesSupported;
            }
        }

        public string GetDescription (string category)
        {
            switch (category)
            {
                case "Credit Card":
                    return "Store information of a Credit Card";
                case "University Card":
                    return "Store information of a University Card";
                default:
                    return null;
            }
        }
    }
}
