using System;
using System.Collections.Generic;
using System.Text;

using Model;
using IServices;
using SqlSugar;
namespace Services
{
    public class SupplierServices : BaseDB, ISupplierServices
    {

        /// <summary>
        /// 获取商品表数据
        /// </summary>
        /// <returns></returns>
        public List<Goods> Goods()
        {
            var db = BaseDB.GetInstance();
            return db.Queryable<Goods>().ToList();
        }



    }
}
