using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration4Affärssystem.Model
{
    public class Transaction
    {
        public int ID { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }  
        public int Amount { get; set; }

       

        public Transaction(int id, int month, int year, int amount)
        {
            ID = id;
            Month = month;
            Year = year;
            Amount = amount;
        }

        
    }
}
