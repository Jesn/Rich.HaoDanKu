using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rich.HaoDanKu.Parser
{
    public enum FormatEnum
    {
        /// <summary>
        /// Json
        /// </summary>
        [Description("Json")]
        JSON = 0,

        /// <summary>
        /// form-data
        /// </summary>
        [Description("form-data")]
        FormData = 1
    }
}
