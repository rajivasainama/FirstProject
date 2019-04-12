using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Program
    {
        static void Main(string[] args)
        {
                double bal = 1000, i = 0;
                while (bal <= 1000000)
                {
                
                    bal = bal + (bal * 0.05);
                    Console.WriteLine(i + " year" + bal);
                i++;
                }
                }
        }
    }
