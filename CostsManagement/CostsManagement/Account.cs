using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostsManagement
{
    class Account
    {
        private string _name; // Account name
        private int _balance; // Acconut balance
        private static int counter = 0;
        
        /// <summary>
        /// Standart constructor
        /// </summary>
        public Account()
        {
            _name = "New account";

            if (counter != 0)
                _name += " #" + counter.ToString();
            counter++;

            _balance = 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">Account name</param>
        /// <param name="balance">Start balance</param>
        public Account(string name, int balance)
        {
            _name = name;
            _balance = balance;
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (value == "")
                    throw new Exception("Name cannot be empty");
                else
                    _name = value;
            }
        }

        public int Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }
    }
}
