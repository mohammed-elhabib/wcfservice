using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wcfservice.Lib.Pagination
{
    public class PagedResult<T> : PagedBase where T : class
    {
        public IList<T> Results { get; set; }

        public PagedResult()
        {
            Results = new List<T>();
        }
    }
}
