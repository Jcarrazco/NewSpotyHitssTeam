using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects
{
    public class Albumt<T,R>
    {
        public R Year     { get; set; }

        public T OpResult { get; set; }

    }
}
