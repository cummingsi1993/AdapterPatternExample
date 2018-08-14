using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternExample.Interfaces
{
    public interface IFooProcessorBuilder
    {

        IFooProcessorBuilder StandardProcessor();
        IFooProcessorBuilder ExceptionProcessor();
        IFooProcessor GetProcessor();

        IFooListProcessorAdapterBuilder AdaptForLists();

    }
}
