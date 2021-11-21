using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba9
{
    public class Accaunt2 : Accaunt1
    {
        static int _counter = -3;

        public Accaunt2()
        {
            _number = Increase();
        }
        public int Increase()
        {
            return _counter++;
        }
    }
}
