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
                        //skip first line
                        reader.ReadLine();
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            line = String.Join(" ", line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));

                            //split string into array
                            string[] data = line.Split(',');

                            //save data
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

        public (BindingSource, int total) filter(string queryMonth, string queryYear)
        {
            //Transaction list needs to be filtered twice 
            BindingList<Transaction> temporary = new BindingList<Transaction>();
            BindingList<Transaction> filterList = new BindingList<Transaction>();

            //check transactions for query, add to temporary list if found
            foreach (Transaction transaction in transactions)
            {
                if (transaction.Month.ToString() == queryMonth)
                {
                    temporary.Add(transaction);
                }
            }

            //check temporary for query, add to resultlist if found
            foreach (Transaction transaction in temporary)
            {
                if (transaction.Year.ToString() == queryYear)
                {
                    filterList.Add(transaction);
                }
            }

            //calculate all transaction amounts to get total
            int total = 0;
            foreach (Transaction transaction in filterList)
            {
                total += transaction.Amount;
            }

            //set binding source
            BindingSource filterSource = new BindingSource();
            filterSource.DataSource = filterList;

            //return filterSource and total as a tuple
            return (filterSource, total);
        }


        public BindingSource getTop10(string query)
        {
            BindingList<Transaction> filterList = new BindingList<Transaction>();

            //filter for correct year
            foreach (Transaction transaction in transactions)
            {
                if (transaction.Year.ToString() == query)
                {
                    filterList.Add(transaction);
                }
            }

            

            //group filteredList by ID and calculate total amount 
            var groupedTransactions = filterList.GroupBy(t => new { t.ID }, (key, g) => new { ID = key.ID, Amount = g.Sum(t => t.Amount) });

            //order list and get the first 10 items
            var orderedList = groupedTransactions.OrderByDescending(t => t.Amount).Take(10);

            //save result in temporary object list because month and year is not needed
            BindingList<object> mergedList = new BindingList<object>();
            foreach (var group in orderedList)
            {
                var obj = new { ID = group.ID, Amount = group.Amount };
                mergedList.Add(obj);
            }

            //return source
            BindingSource filterSource = new BindingSource();
            filterSource.DataSource = mergedList;
            return filterSource;
        }

    }
}
