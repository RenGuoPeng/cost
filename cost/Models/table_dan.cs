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
    public partial class table_dan
    {
        public table_dan()
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
        public string 毛细管 { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string 带纤数量 { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string 计件人工成本 { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string 费用公摊 { get; set; }

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
        public string 包材 { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string 包装均摊 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Navigate(typeof(products_optical), nameof(products_optical.products_code), nameof(products_optical.optical_code))]//注意顺序
        public List<table_optical> optical_code { get; set; }

    }
}
