using Kernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kernel
{
    class Kernel : IKernel
    {
        public IDictionary<object, object> Container;
        public void GetObject<Object>(Object _object)
        {
        }

        public void SetObject<Object>(Object _object)
        {
            throw new NotImplementedException();
        }
    }
}
