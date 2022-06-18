using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zybooksInterface
{
    interface IWorker : IPerson
    {
        void Work(string position);
    }
}
