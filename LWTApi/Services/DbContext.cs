using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Model;
using SqlSugar;
namespace Services
{
   public class DbContext
    {
        public DbContext()
        {
            Db = new SqlSugarClient(new ConnectionConfig()
            {
                ConnectionString = Config.ConnectionString,
                DbType = DbType.Oracle,
                InitKeyType = InitKeyType.Attribute,//从特性读取主键和自增列信息
                IsAutoCloseConnection = true,//开启自动释放模式和EF原理一样我就不多解释了

            });
            //调式代码 用来打印SQL 
            Db.Aop.OnLogExecuting = (sql, pars) =>
            {
                Console.WriteLine(sql + "\r\n" +
                    Db.Utilities.SerializeObject(pars.ToDictionary(it => it.ParameterName, it => it.Value)));
                Console.WriteLine();
            };
        }
        public SqlSugarClient Db;//用来处理事务多表查询和复杂的操作
        public SimpleClient<Goods> GoodsDb { get { return new SimpleClient<Goods>(Db); } }//用来处理Goods表的常用操作
    }
}
