using kernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kernel
{
    public interface IKernel
    {

        void SetObject<Object>(Object _object);
        void GetObject<Object>(Object _object);
    }
}
