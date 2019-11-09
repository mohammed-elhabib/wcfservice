using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kernel
{
   public class TaypeObject<T> 
        where T :class,new()
    {
      private  T _obeject;

        public TaypeObject() { }
        public TaypeObject(T _object) {
            this._obeject = _object;

        }




    }
}
