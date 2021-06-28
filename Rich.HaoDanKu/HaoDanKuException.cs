using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rich.HaoDanKu
{
    public class HaoDanKuException:Exception
    {
        public HaoDanKuException()
        {
        
        }

        public HaoDanKuException(string messages) : base(messages)
        {
        }

        public HaoDanKuException(string message, Exception innerException) : base(message, innerException)
        {
        }

    }
}
