using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace test
{
    internal class Account
    {

        string _Number;
        string _Name;
        decimal _Balance;

        public Account(string number, string name, decimal balance)
        {
            _Number = number;
            _Name = name;
            _Balance = balance;
        }

        public string Number { get { return _Number; } }
        public string Name { get { return _Name; } }
        public decimal Balance { get { return _Balance; } }

        public string Number1 { get => _Number; set => _Number = value; }
        public string Name1 { get => _Name; set => _Name = value; }
        public decimal Balance1 { get => _Balance; set => _Balance = value; }

        public void Deposit( decimal amount)
        {
            //_Number = number;
            //_Name = name;
           
            if (amount > 0)
            {
                _Balance += amount;
               MessageBox.Show($" Your deposit Was Successful! Your new balance is  ${_Balance}");
            }
            else
            {
                MessageBox.Show("Invalid deposit amount. Please enter a positive number.");
            }
        }

        public void Withdraw( decimal amount)
        {
            
            
            if (amount > 0)
            {
                
            }
            else
            {
                MessageBox.Show("Invalid withdrawal amount. Please enter a positive number.");
            }
            if (_Balance >= amount)
            {
                _Balance -= amount;
                MessageBox.Show($" Your Withdrawal Was Successful! Your new balance is {_Balance}");
            }
            else
            {
                MessageBox.Show("Insufficient funds.");
            }
        }

        public override string ToString()
        {
            return $"{_Number} - {_Name} - Current Balance: {_Balance}";
        }
    }
}

