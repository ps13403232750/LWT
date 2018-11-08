using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;


namespace Services
{
    public static class SqlSugarHelper<T> where T : class, new()
    {
        #region Implementation of IRepository<T>

        /// <summary>
        ///  分页 查询
        /// </summary>
        /// <param name="tableName">表名称</param>
        /// <param name="orderStr">排序 倒叙</param>
        /// <param name="pageIndex">页码</param>
        /// <param name="pageSize">每页显示多少条数据</param>
        /// <param name="totalCount">总记录数</param>
        /// <returns></returns>
        public static List<T> FindAll(string tableName, string orderStr, int pageIndex, int pageSize, ref int totalCount)
        {
            using (var db = BaseDB.GetInstance())
            {
                var list = db.Queryable<T>().OrderBy(orderStr).ToPageList(pageIndex, pageSize, ref totalCount);
                return list;
            }
        }

        /// <summary>
        /// 根据主值查询单条数据
        /// </summary>
        /// <param name="pkValue">主键值</param>
        /// <returns>泛型实体</returns>
        public static T FindById(int pkValue)
        {
            using (var db = BaseDB.GetInstance())
            {
                var entity = db.Queryable<T>().InSingle(pkValue);
                return entity;
            }
        }

        /// <summary>
        /// 查询所有数据(无分页,请慎用)
        /// </summary>
        /// <returns></returns>
        public static List<T> FindAll()
        {
            using (var db = BaseDB.GetInstance())
            {
                var list = db.Queryable<T>().ToList();
                return list;
            }
        }

        /// <summary>
        /// 根据条件查询数据
        /// </summary>
        /// <param name="predicate">条件表达式树</param>
        /// <param name="orderBy">排序</param>
        /// <returns>泛型实体集合</returns>
        public static List<T> FindListByClause(Expression<Func<T, bool>> predicate, string orderBy)
        {
            using (var db = BaseDB.GetInstance())
            {
                var entities = db.Queryable<T>().Where(predicate).ToList();
                return entities;
            }
        }

        /// <summary>
        /// 根据条件查询数据
        /// </summary>
        /// <param name="predicate">条件表达式树</param>
        /// <returns></returns>
        public static T FindByClause(Expression<Func<T, bool>> predicate)
        {
            using (var db = BaseDB.GetInstance())
            {
                var entity = db.Queryable<T>().First(predicate);
                return entity;
            }
        }

        /// <summary>
        /// 写入实体数据
        /// </summary>
        /// <param name="entity">实体类</param>
        /// <returns></returns>
        public static int Insert(T entity)
        {
            using (var db = BaseDB.GetInstance())
            {
                //返回插入数据的标识字段值
                var i = db.Insertable(entity).ExecuteCommand();
                return i;
            }
        }

        /// <summary>
        /// 更新实体数据
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public static bool Update(T entity)
        {
            using (var db = BaseDB.GetInstance())
            {
                //这种方式会以主键为条件
                var i = db.Updateable(entity).ExecuteCommand();
                return i > 0;
            }
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="entity">实体类</param>
        /// <returns></returns>
        public static bool Delete(T entity)
        {
            using (var db = BaseDB.GetInstance())
            {
                var i = db.Deleteable(entity).ExecuteCommand();
                return i > 0;
            }
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="where">过滤条件</param>
        /// <returns></returns>
        public static bool Delete(Expression<Func<T, bool>> @where)
        {
            using (var db = BaseDB.GetInstance())
            {
                var i = db.Deleteable<T>(@where).ExecuteCommand();
                return i > 0;
            }
        }

        /// <summary>
        /// 删除指定ID的数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool DeleteById(object id)
        {
            using (var db = BaseDB.GetInstance())
            {
                var i = db.Deleteable<T>(id).ExecuteCommand();
                return i > 0;
            }
        }

        /// <summary>
        /// 删除指定ID集合的数据(批量删除)
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public static bool DeleteByIds(object[] ids)
        {
            using (var db = BaseDB.GetInstance())
            {
                var i = db.Deleteable<T>().In(ids).ExecuteCommand();

                return i > 0;
            }
        }
        

        /// <summary>  
        /// 带条件的分页查询  
        /// </summary>  
        /// <typeparam name="TKey">按哪个字段进行排序</typeparam>  
        /// <param name="pageindex">当前页</param>  
        /// <param name="pagesize">页大小</param>  
        /// <param name="rowCount">数据总条数</param>  
        /// <param name="order">排序</param>  
        /// <param name="where">筛选条件</param>  
        /// <returns></returns>  
        //public IQueryable<T> QueryByPage<TKey>(int pageindex, int pagesize, out int rowCount, Expression<Func<T, TKey>> order, Expression<Func<T, bool>> where)
        //{
        //    using (var db = BaseDB.GetInstance())//链接数据库
        //    {
        //        ////获取总条数  
        //        //rowCount = db..Count(where);
        //        ////建议将这个Where条件语句放在前面，如果你放到后面，分页的时候可能存在问题。  
        //        //return db.Where(where).OrderByDescending(order).Skip((pageindex - 1) * pagesize).Take(pagesize);
        //    }
        //}

        #endregion
    }
}