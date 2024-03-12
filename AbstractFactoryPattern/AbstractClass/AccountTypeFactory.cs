using AbstractFactoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.AbstractClass
{
    public abstract class AccountTypeFactory
    {
        public abstract ISavingAccount SavingAccountFactory(string message);
        public abstract ICurrentAccount CurrentAccountFactory(string message);
    }
}
