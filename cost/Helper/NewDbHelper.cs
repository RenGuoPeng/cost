using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cost.Models;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace cost.Helper
{
    internal class NewDbHelper
    {
        public SqlSugarScope db;
        public NewDbHelper()
        {
            //加载配置文件
            ConfigurationBuilder configurationBuilder = new ConfigurationBuilder();
            db = new SqlSugarScope(new ConnectionConfig()
            {
                ConnectionString = Properties.Settings.Default.host,//GetSettings("ConnectionStrings:host"),//"Server=127.0.0.1;Database=shijia_costing;uid=root;password=root!@#;port=3307",//连接符字串
                DbType = DbType.MySql,//数据库类型
                IsAutoCloseConnection = true,//不设成true要手动close
                InitKeyType = InitKeyType.Attribute  //从实体特性中读取主键自增列信息
            }) ;
            db.Aop.OnLogExecuting = (sql, pars) =>
            {
                Console.WriteLine(sql + "\r\n" +
                    db.Utilities.SerializeObject(pars.ToDictionary(it => it.ParameterName, it => it.Value)));
                Console.WriteLine();
            };
        }

        public static string GetSettings(string key)
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            IConfigurationRoot configuration = builder.Build();
            return configuration[key];
        }

        public void CreadtOneClass()
        {
            //指定表名生成实体
            db.DbFirst.Where("table_tao").CreateClassFile(@"D:\项目文件\vs2022项目\cost\cost\Models", "cost.Models");
        }
        public void Getsql()
        {
            var list = db.Queryable<Models.微型不加头成本表>().ToList();
        }
        public void text()
        {
            var list3 = db.Queryable<table_fa>().Includes(x => x.optical_code).ToList();
        }


    }
}
