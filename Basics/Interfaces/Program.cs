﻿using System;

namespace Interfaces
{

    // An interface sets out rule for all classes inheriting the interface to folow 
    // it defines syntatically how the inheriting class should behave. 
    // interfaces define properties, methods and evenths. 
    // Abstract classes to some extent serve the same purpose, however, they are mostly 
    // used when only few methods are to be declared by the base class and the deriving class 
    // implements the functionalities



    public interface ITransactions {
        // interface members
        void showTransaction();
        double getAmount();
    }

    public class Transaction : ITransactions {
        private string tCode;
        private string date;
        private double amount; 

        public Transaction() {
            tCode = " ";
            date = " ";
            amount = 0.0;
        }
        public Transaction(string c, string d, double a) {
            tCode = c;
            date = d;
            amount = a;
        }
        public double getAmount() {
            return amount;
        }
        public void showTransaction() {
            Console.WriteLine("Transaction: {0}", tCode);
            Console.WriteLine("Date: {0}", date);
            Console.WriteLine("Amount: {0}", getAmount());
        }

    }





    class Program
    {

    
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Transaction t1 = new Transaction("001", "8/10/2012", 78900.00);
            Transaction t2 = new Transaction("002", "9/10/2012", 451900.00);

            t1.showTransaction();
            t2.showTransaction();
        }
    }
}
