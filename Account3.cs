using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba9
{
    public class Account3:Accaunt2
    {
        public Account3()
        {
            _number = Increase();
        }

        public Account3(decimal balance)
        {
            _balance = balance;
            _number = Increase();

        }
        public Account3(TypeOfAccaunt typeAccount)
        {
            _typeAccaunt = typeAccount;
            _number = Increase();

        }

        public Account3(decimal balance, TypeOfAccaunt typeAccount)
        {
            _balance = balance;
            _typeAccaunt = typeAccount;
            _number = Increase();

        }
        public int Number
        {
            get
            {
                return _number;
            }
            set
            {
                if (value.GetType().ToString() == "System.Int32")
                {
                    _number = value;
                }
            }

        }


        public decimal Balance
        {
            get
            {
                return _balance;
            }
            set
            {
                if (value.GetType().ToString() == "System.Decimal")
                {
                    _balance = value;
                }
            }

        }
        
        public TypeOfAccaunt TypeAccount
        {
            get
            {
                return _typeAccaunt;
            }
            set
            {
                if (value.GetType().ToString() == "GB_04_02BankAccount04.TypeOfBankAccount")
                {
                    _typeAccaunt = value;
                }
            }
        }
    }
}
