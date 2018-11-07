using System;
using System.Collections.Generic;
using System.Text;

using Model;
using IServices;
using SqlSugar;
namespace Services
{
   public class SupplierServices: BaseDB,ISupplierServices
    {
        SimpleClient<Goods> goods = new SimpleClient<Goods>(GetInstance());

        /// <summary>
        /// 获取商品表数据
        /// </summary>
        /// <returns></returns>
        public List<Goods> GetGoods() => goods.GetList();
    }
}
