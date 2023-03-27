using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cost.Helper
{
    internal class DataRepository
    {
        public static string NewGuid()
        {
            return Guid.NewGuid().ToString("N");
        }
        /// <summary>
        /// 获取返回的列表
        /// </summary>
        /// <typeparam name="U"></typeparam>
        /// <param name="sql"></param>
        /// <param name="orderby"></param>
        /// <returns></returns>
        public static List<U> GetListBySql<U>(string sql, string orderby = "")
            where U : class, new()
        {
            NewDbHelper sugar = new NewDbHelper();
            List<U> result = null;
            using (var db = sugar.db)
            {
                if (string.IsNullOrEmpty(orderby))
                {
                    result = db.SqlQueryable<U>(sql).ToList();
                }
                else
                {
                    result = db.SqlQueryable<U>(sql).OrderBy(orderby).ToList();
                }
            }
            return result;
        }
        /// <summary>
        /// 获取返回的列表-参数化
        /// </summary>
        /// <typeparam name="U"></typeparam>
        /// <param name="sql"></param>
        /// <param name="where"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public static List<U> GetListBySql<U>(string sql, string where, object parameters)
            where U : class, new()
        {
            NewDbHelper sugar = new NewDbHelper();
            List<U> result = null;
            using (var db = sugar.db)
            {
                result = db.SqlQueryable<U>(sql).Where(where, parameters).ToList();
            }
            return result;
        }

        /// <summary>
        /// 获取DbSet 第一行
        /// </summary>
        /// <typeparam name="U"></typeparam>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static U GetOneBySql<U>(string sql)
            where U : class, new()
        {
            NewDbHelper sugar = new NewDbHelper();
            U result = null;
            using (var db = sugar.db)
            {
                result = db.SqlQueryable<U>(sql).First();
            }
            return result;
        }
        /// <summary>
        /// 获取第一行第一列的值 并转化为Int
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static int GetInt(string sql)
        {
            NewDbHelper sugar = new NewDbHelper();
            using (var db = sugar.db)
            {
                return db.Ado.GetInt(sql);
            }
        }
        /// <summary>
        /// 获取第一行第一列的值 并转化为Double
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static double GetDouble(string sql)
        {
            NewDbHelper sugar = new NewDbHelper();
            using (var db = sugar.db)
            {
                return db.Ado.GetDouble(sql);
            }
        }
        /// <summary>
        /// 执行Sql 查询单个实体
        /// </summary>
        /// <typeparam name="E"></typeparam>
        /// <typeparam name="U"></typeparam>
        /// <param name="sql"></param>
        /// <param name="OrderBy"></param>
        /// <param name="u"></param>
        /// <returns></returns>
        public static E PageOne<E>(string sql)
            where E : class, new()
        {
            NewDbHelper sugar = new NewDbHelper();
            var db = sugar.db;
            var one = db.SqlQueryable<E>(sql).ToList().FirstOrDefault();
            return one;
        }

        /// <summary>
        /// 查询结果List的第一条记录
        /// </summary>
        /// <typeparam name="E"></typeparam>
        /// <param name="sql"></param>
        /// <param name="where"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public static E PageOne<E>(string sql, string where, object parameters)
           where E : class, new()
        {
            NewDbHelper sugar = new NewDbHelper();
            if (parameters == null)
            {
                return PageOne<E>(sql);
            }

            var db = sugar.db;
            var one = db.SqlQueryable<E>(sql).Where(where, parameters).ToList().FirstOrDefault();
            return one;
        }


        /// <summary>
        /// 第一行第一列
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public static object ExecuteScalar(string sql, object parameters = null)
        {
            NewDbHelper sugar = new NewDbHelper();
            using (var db = sugar.db)
            {
                return db.Ado.GetScalar(sql, parameters);
            }
        }

        /// <summary>
        /// 执行Update insert 等操作
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public static int ExecuteCommand(string sql, object parameters = null)
        {
            NewDbHelper sugar = new NewDbHelper();
            using (var db = sugar.db)
            {
                return db.Ado.ExecuteCommand(sql, parameters);
            }
        }

        /// <summary>
        /// 第一行第一列
        /// </summary>
        public static object ExecuteScalar(string sql)
        {
            NewDbHelper sugar = new NewDbHelper();
            using (var db = sugar.db)
            {
                return db.Ado.GetScalar(sql);
            }
        }
        /// <summary>
        /// 第一行第一列    -    异步
        /// </summary>
        public static async Task<object> ExecuteScalarAsync(string sql, object parameters = null)
        {
            NewDbHelper sugar = new NewDbHelper();
            using (var db = sugar.db)
            {
                return await db.Ado.GetScalarAsync(sql, parameters);
            }
        }
        /// <summary>
        /// 第一行第一列    -    异步
        /// </summary>
        public static async Task<object> ExecuteScalarAsync(string sql)
        {
            NewDbHelper sugar = new NewDbHelper();
            using (var db = sugar.db)
            {
                return await db.Ado.GetScalarAsync(sql);
            }
        }

        public static E GetOneBySql<E>(string sql, object parameters = null)
            where E : class
        {
            NewDbHelper sugar = new NewDbHelper();
            using (var db = sugar.db)
            {
                return db.Ado.SqlQuerySingle<E>(sql, parameters);
            }

        }
        /// <summary>
        /// 第一行第一列    -    异步
        /// </summary>
        public static async Task<E> GetOneBySqlAsync<E>(string sql, object parameters = null)
          where E : class
        {
            NewDbHelper sugar = new NewDbHelper();
            using (var db = sugar.db)
            {
                return await db.Ado.SqlQuerySingleAsync<E>(sql, parameters);
            }

        }

        public static List<E> GetBySql<E>(string sql, object parameters = null)
            where E : class
        {
            NewDbHelper sugar = new NewDbHelper();
            using (var db = sugar.db)
            {
                return db.Ado.SqlQuery<E>(sql, parameters);
            }

        }

        public static async Task<List<E>> GetBySqlAsync<E>(string sql, object parameters = null)
            where E : class
        {
            NewDbHelper sugar = new NewDbHelper();
            using (var db = sugar.db)
            {
                return await db.Ado.SqlQueryAsync<E>(sql, parameters);
            }
        }

        /// <summary>
        /// 执行事务
        /// </summary>
        /// <param name="sqls"></param>
        public static void ExecTransaction(List<string> sqls)
        {
            NewDbHelper sugar = new NewDbHelper();
            using (var db = sugar.db)
            {
                try
                {
                    db.Ado.BeginTran();
                    foreach (var item in sqls)
                    {
                        db.Ado.ExecuteCommand(item);
                    }
                    db.Ado.CommitTran();

                }
                catch (Exception ex)
                {
                    db.Ado.RollbackTran();
                    throw ex;
                }
            }
        }

        /// <summary>
        /// 根据list直接更新
        /// 执行Update insert 等操作
        /// </summary>
        /// <param name="rules_Tables"></param>
        //public static int ExecuteCommand(List<rules_table> rules_Tables)
        //{
        //    NewDbHelper sugar = new NewDbHelper();
        //    using (var db = sugar.db)
        //    {
        //        int a = db.Updateable(rules_Tables).ExecuteCommand();
        //        return a;
        //    }
        //}

        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="rules_Tables"></param>
        //public static int ExecuteInsert(List<rules_table> rules_Tables)
        //{
        //    NewDbHelper sugar = new NewDbHelper();
        //    using (var db = sugar.db)
        //    {
        //        // int a = db.Updateable(rules_Tables).ExecuteCommand();
        //        int a = db.Insertable(rules_Tables).ExecuteReturnIdentity();
        //        return 1;
        //    }
        //}
    }
}
