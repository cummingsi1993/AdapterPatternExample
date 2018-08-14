using AdapterPatternExample.Interfaces;
using AdapterPatternExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternExample.Processors
{
    public class FooListAdapter : IFooListProcessor
    {
        private IFooProcessor processor;
        public FooListAdapter(IFooProcessor processor)
        {
            this.processor = processor;
        }
        public void Process(IEnumerable<Foo> foos)
        {
            foreach (Foo foo in foos)
            {
                this.processor.Process(foo);
            }
        }
    }
}
