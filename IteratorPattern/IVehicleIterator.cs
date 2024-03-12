using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public interface IVehicleIterator
    {
        void First();
        bool IsDone();
        string Next();
        string Current();
    }
}
