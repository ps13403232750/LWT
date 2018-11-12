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
            var result = SqlSugarHelper<Goods>.FindAll();
            return result;
        }

        /// <summary>
        /// 审核商品
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public bool UpdateGoods(int Id, int State)
        {
            //别删我,我还有用，谢谢
            //var result = GoodsDb.Update(it => new Goods() { State = State }, it => it.Id == Id);
            //return result;
            
            var result = GetSimpleInstance<Goods>().Update(it => new Goods() { State = State }, it => it.Id == Id);
            return result;
        }

        /// <summary>
        /// 获取订单表数据
        /// </summary>
        /// <returns></returns>
        public List<Orders> GetOrder()
        {
            var result = SqlSugarHelper<Orders>.FindAll();
            return result;
        }

        /// <summary>
        /// 获取订单从表详细数据
        /// </summary>
        /// <returns></returns>
        public List<OrderList> GetOrderList(int OrderNum)
        {
            var db = BaseDB.GetInstance();
            var result = db.Queryable<OrderList>().Where(it => it.OrderNum == OrderNum).ToList();
            return result;
        }

        /// <summary>
        /// 添加新商品
        /// </summary>
        /// <param name="goods"></param>
        /// <returns></returns>
        public int AddGoods(Goods goods)
        {
            var result = SqlSugarHelper<Goods>.Insert(goods);
            return result;
        }

        /// <summary>
        /// 统计订单
        /// </summary>
        /// <param name="OrderTime"></param>
        /// <returns></returns>
        public int CountOrder(string OrderTime)
        {
            var db = BaseDB.GetInstance();
            var count = db.Queryable<Orders>().Where(it => it.OrderTime.Contains(OrderTime)).Count();
            return count;
        }
    }
}
