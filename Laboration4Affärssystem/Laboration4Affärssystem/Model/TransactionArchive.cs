using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboration4Affärssystem.Model
{
    public class TransactionArchive
    {
        public BindingList<Transaction> transactions = new BindingList<Transaction>();

        public void addTransaction(int id, int month, int year, int amount)
        {
            transactions.Add(new Transaction(id, month, year, amount));
        }

        public void importTransactions()
        {
            try
            {
                string fileName = "transactions.csv";

                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);

                if (File.Exists(filePath))
                {
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        //the first line is not saved
                        reader.ReadLine();
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            line = String.Join(" ", line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
                            string[] data = line.Split(',');

                            int id = int.Parse(data[0]);
                            int month = int.Parse(data[1]);
                            int year = int.Parse(data[2]);
                            int amount = int.Parse(data[3]);

                            addTransaction(id, month, year, amount);
                        }
                    }
                }

                else
                {
                    throw new Exception("File not found");
                }
            }

            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

    }
}
