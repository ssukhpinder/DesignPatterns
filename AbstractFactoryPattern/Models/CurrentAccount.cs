using AbstractFactoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Models
{
    public class CurrentAccount : ICurrentAccount
    {
        public CurrentAccount(string message)
        {
            Console.WriteLine(message);
        }
    }
}
