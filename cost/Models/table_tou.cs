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
    public partial class table_tou
    {
        public table_tou()
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
        public string 散件 { get; set; }
        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string 插芯 { get; set; }
        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string 辅料 { get; set; }
        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string 人工 { get; set; }
        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string 测试 { get; set; }
        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string 公摊 { get; set; }


    }
}
