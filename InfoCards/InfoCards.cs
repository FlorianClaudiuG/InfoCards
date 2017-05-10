using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment
{
    public class InfoCards : List<IInfoCard>, IInfoCards
    {
        public bool Load(string fileName, GetFactory getFactory)
        {
            StreamReader readFile = new StreamReader(fileName);

            if (readFile == null)
            {
                return false;
            }
            else
            {
                string line;
                IInfoCard card;
                IInfoCardFactory factory;

                while ((line = readFile.ReadLine()) != null)
                {
                    string[] temp = line.Split('|');
                    string category = temp[0];
                    factory = getFactory.Invoke(category);
                    card = factory.CreateInfoCard(line);
                    Add(card);
                }
            }

            readFile.Close();  

            return true;
        }

        public void Save(string fileName)
        {
            StreamWriter writeFile = new StreamWriter(fileName, false);

            if (writeFile == null)
            {
                Console.WriteLine("There was an error saving the file.");
            }
            else
            {
                foreach (IInfoCard card in this)
                {
                    string temp = card.GetDataAsString();
                    writeFile.WriteLine(temp);
                }
            }

            writeFile.Close();
        }
    }
}