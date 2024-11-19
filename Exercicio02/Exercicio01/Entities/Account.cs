using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercicio01.Entities.Exceptions;

namespace Exercicio01.Entities
{
    internal class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithDrawLimit { get; set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance, double withDrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withDrawLimit;
        }
        public void WithDraw(double withDraw)
        {
            if(withDraw > WithDrawLimit)
            {
                throw new DomainException("The amount exceeds withdraw limit!");
            }
            if(withDraw > Balance)
            {
                throw new DomainException("Not enoght balance!");
            }
            Balance -= withDraw;
        }
    }
}
