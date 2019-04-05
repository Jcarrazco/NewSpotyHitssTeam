using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotyHitss.Data.Objects
{
    public class OperationResult<T>
    {
        public int OpStatus { get; set; }
        public string OpMesssage { get; set; }
        public T OpResult { get; set; }
    }
}
