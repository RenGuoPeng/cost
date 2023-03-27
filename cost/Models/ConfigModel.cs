using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cost.Models
{
    internal class ConfigModel
    {
        public ConfigModel()
        {

        }

        /// <summary>
        /// Desc:host
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string Host { get; set; }

        /// <summary>
        /// Desc:Num
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string Num { get; set; }
    }
}
