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
    public partial class table_optical
    {
        public table_optical()
        {

            optical_code = "";
            optical_name = "";
            optical_type = "";
            price_no_tax = "";
            vendor_name = "";
        }


        /// <summary>
        /// Desc:光纤物料编号
        /// Default:
        /// Nullable:True
        /// </summary>        
        /// 
        [SugarColumn(IsPrimaryKey = true)]
        public string optical_code { get; set; }

        /// <summary>
        /// Desc:光纤名称
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string optical_name { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string optical_type { get; set; }

        /// <summary>
        /// Desc:不含税价格
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string price_no_tax { get; set; }

        /// <summary>
        /// Desc:供应商名称
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string vendor_name { get; set; }

        /// <summary>
        /// Desc:products_code
        /// Default:
        /// Nullable:True
        /// </summary>       
        /// 
        [Navigate(typeof(products_optical), nameof(products_optical.optical_code), nameof(products_optical.products_code))]//注意顺序
        public List<table_fa> products_code { get; set; }

       /// <summary>
       /// 
       /// </summary>
        [Navigate(typeof(products_optical), nameof(products_optical.optical_code), nameof(products_optical.products_code)), SugarColumn(ColumnName = "products_code")]//注意顺序
        public List<table_dan> products_code_dan { get; set; }
    }
}
