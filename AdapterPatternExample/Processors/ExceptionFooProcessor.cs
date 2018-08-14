using AdapterPatternExample.Interfaces;
using AdapterPatternExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternExample.Processors
{
    public class ExceptionFooProcessor : IFooProcessor
    {
        public void Process(Foo foo)
        {
            throw new InvalidOperationException("This is an exception");
        }
    }
}
