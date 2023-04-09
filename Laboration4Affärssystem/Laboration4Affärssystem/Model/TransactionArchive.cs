using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration4Affärssystem.Model
{
    public class TransactionArchive
    {
        public BindingList<Transaction> transactions = new BindingList<Transaction>();

        public void addTransaction(int id, int month, int year, int amount)
        {
            transactions.Add(new Transaction(id, month, year, amount));
        }
    }
}
