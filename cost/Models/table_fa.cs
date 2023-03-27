
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
    public partial class table_fa
    {
        public table_fa()
        {
            //products_code = table_Fa.products_code;
            //products_name = table_Fa.products_name;
            //盖板 = table_Fa.盖板;
            //带纤数量 = table_Fa.带纤数量;
            //计件人工成本 = table_Fa.计件人工成本;
            //费用公摊 = table_Fa.费用公摊;
            //包装人工 = table_Fa.包装人工;
            //包材 = table_Fa.包材;
            //包装均摊 = table_Fa.包装均摊;
            //光纤长度 = table_Fa.光纤长度;
            //头胶 = table_Fa.头胶;
            //自用良率 = table_Fa.自用良率;
            //optical_code = table_Fa.optical_code;
        }


        /// <summary>
        /// Desc:产品编号
        /// Default:
        /// Nullable:True
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
        public string 盖板 { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        /// 

        public string 头胶辅料 { get; set; }

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
        /// Desc:products_code
        /// Default:
        /// Nullable:True
        /// </summary>   
        ///
        [Navigate(typeof(products_optical), nameof(products_optical.products_code), nameof(products_optical.optical_code))]//注意顺序
        public List<table_optical> optical_code { get; set; }

        [SugarColumn(IsIgnore=true)]
        public string 光纤长度 { get; set; }
        [SugarColumn(IsIgnore = true)]
        //public string 头胶 { get; set; }
        //[SugarColumn(IsIgnore = true)]
        public string 自用良率 { get; set; }

    }
}
