using SqlSugar;
using System;
using System.Linq;
using System.Text;

namespace cost.Models
{
    ///<summary>
    ///
    ///</summary>
    public partial class products_optical
    {
           public products_optical(){


           }
        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>         
        /// 
        [SugarColumn(IsPrimaryKey = true)]//中间表可以不是主键
        public string products_code {get;set;}

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>  
        /// 
        [SugarColumn(IsPrimaryKey = true)]//中间表可以不是主键
        public string optical_code {get;set;}

    }
}
