using AdapterPatternExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternExample.Interfaces
{
    public interface IFooProcessor
    {

        void Process(Foo foo);

    }
}
