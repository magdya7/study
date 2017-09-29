using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostsManagement
{
    class Operation
    {
        private DateTime _date;
        private Account _account;
        private Category _category;
        private int _sum;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Acc">Account</param>
        /// <param name="Ctg">Operation type</param>
        /// <param name="Sum">Transaction amount</param>
        public Operation(Account Acc, Category Ctg, int Sum)
        {
            _date = DateTime.Now;
            _account = Acc;
            _category = Ctg;
            _sum = Sum;
            if (Ctg.Type)
                _account.Balance = Acc.Balance + Sum;
            else
                _account.Balance = Acc.Balance - Sum;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Date">Operation date</param>
        /// <param name="Acc">Account</param>
        /// <param name="Ctg">Operation type</param>
        /// <param name="Sum">Transaction amount</param>
        public Operation(DateTime Date, Account Acc, Category Ctg, int Sum)
        {
            _date = Date;
            _account = Acc;
            _category = Ctg;
            _sum = Sum;
            if (Ctg.Type)
                _account.Balance = Acc.Balance + Sum;
            else
                _account.Balance = Acc.Balance - Sum;
        }

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public Account Account
        {
            get { return _account; }
            set { _account = value; }
        }

        public Category OperationType
        {
            get { return _category; }
            set
            {
                if (value.Type && !_category.Type)
                    _account.Balance += 2 * _sum;
                else
                    if(!value.Type && _category.Type)
                        _account.Balance -= 2 * _sum;

                _category = value;
            }
        }

        public int Sum
        {
            get { return _sum; }
            set
            {
                if (_category.Type)
                    _account.Balance = _account.Balance - _sum + value;
                else
                    _account.Balance = _account.Balance + _sum - value;

                _sum = value;
            }
        }
    }
}
