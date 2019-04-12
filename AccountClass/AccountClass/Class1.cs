using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountClass
{
    public class Account
    {
        private void Deposit(int amount);
        private void withdraw(int amount);
        public string DoTransaction(int amount, int choice);
        public double ShowBalance();
    }
}
