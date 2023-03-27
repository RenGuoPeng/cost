using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cost.Models
{
    ///<summary>
    ///
    ///</summary>
    public partial class table_tao
    {
        public table_tao()
        {


        }
        /// <summary>
        /// Desc:产品编号
        /// Default:
        /// Nullable:False
        /// </summary>       
        /// 
        [SugarColumn(IsPrimaryKey = true)]
        public string products_code { get; set; }

        /// <summary>
        /// Desc:产品名称
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string products_name { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string 单价 { get; set; }
        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string 数量 { get; set; }
        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string 输入根数 { get; set; }
    }
}
