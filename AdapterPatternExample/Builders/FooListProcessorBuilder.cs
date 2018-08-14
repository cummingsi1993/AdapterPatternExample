using AdapterPatternExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternExample.Builders
{
    public class FooListProcessorBuilder : IFooListProcessorAdapterBuilder
    {
        IFooProcessor processor;
        public FooListProcessorBuilder(IFooProcessor processor)
        {
            this.processor = processor;
        }

        public IFooListProcessor GetProcessor()
        {
            return new Processors.FooListAdapter(processor);
        }
    }
}
