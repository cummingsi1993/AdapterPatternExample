using AdapterPatternExample.Interfaces;
using AdapterPatternExample.Processors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternExample.Builders
{
    public class FooProcessorBuilder : IFooProcessorBuilder
    {
        IFooProcessor processor;

        public FooProcessorBuilder()
        {

        }

        public IFooListProcessorAdapterBuilder AdaptForLists()
        {
            
            if (processor == null)
            {
                throw new InvalidOperationException("The adapter cannot be built without first selecting the processor");
            }

            return new FooListProcessorBuilder(processor);


        }

        public IFooProcessorBuilder ExceptionProcessor()
        {
            this.processor = new ExceptionFooProcessor();
            return this;
        }

        public IFooProcessor GetProcessor()
        {
            return processor;
        }

        public IFooProcessorBuilder StandardProcessor()
        {
            this.processor = new FooProcessor();
            return this;
        }
    }
}
