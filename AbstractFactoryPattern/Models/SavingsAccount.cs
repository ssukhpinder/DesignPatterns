using AbstractFactoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Models
{
    public class SavingsAccount : ISavingAccount
    {
        public SavingsAccount( string message)
        {
            Console.WriteLine(message);
        }
    }
}
