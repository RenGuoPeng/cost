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
    public partial class table_Jt
    {
        public table_Jt()
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
        public string 包装人工 { get; set; }
        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string 耗材费用 { get; set; }
        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string 包装公摊 { get; set; }

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
        public string 头数 { get; set; }

    }
}
