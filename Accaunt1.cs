using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba9
{
    public enum TypeOfAccaunt
    {
        DEBIT,
        CREDIT,
        DEPOSIT
    }
    public class Accaunt1
    {
        protected int _number;
        protected decimal _balance;
        protected TypeOfAccaunt _typeAccaunt;
        protected string _info;

        public int InfoNumber()
        {
            return _number;
        }
        public decimal InfoBalance()
        {
            return _balance;
        }
        public TypeOfAccaunt InfoTypeAccaun()
        {
            return _typeAccaunt;
        }
        public void FillNumber(int number)
        {
            _number = number;
        }
        public void FillBalance(decimal balance)
        {
            _balance = balance;
        }
        public void FillTypeAccaunt(TypeOfAccaunt typeAccaunt)
        {
            _typeAccaunt = typeAccaunt;
        }
        public string FullInfo()
        {
            return _info;
        }
        public void FillInfo()
        {
            _info = $"Тип счёта: {_typeAccaunt} \nНомер счёта: {_number} \nБаланс: {_balance}\n\n";
        }

    }
}
