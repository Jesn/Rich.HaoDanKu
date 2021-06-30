using Rich.HaoDanKu.Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rich.HaoDanKu
{
    public class HaoDanKuOptions
    {
        public string AppKey { get; set; }

        public FormatEnum Format = FormatEnum.JSON;

        public string Charset = "utf-8";
    }
}
