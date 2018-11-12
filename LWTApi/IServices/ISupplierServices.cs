using System;
using System.Collections.Generic;
using System.Text;

using Model;
namespace IServices
{
    public interface ISupplierServices
    {
        /// <summary>
        /// 获取商品列表
        /// </summary>
        /// <returns></returns>
        List<Goods> Goods();

        /// <summary>
        /// 审批商品
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        bool UpdateGoods(int Id, int State);

        /// <summary>
        /// 获取订单列表
        /// </summary>
        /// <returns></returns>
        List<Orders> GetOrder();

        /// <summary>
        /// 获取订单从表详细信息
        /// </summary>
        /// <param name="OrderNum"></param>
        /// <returns></returns>
        List<OrderList> GetOrderList(int OrderNum);

        /// <summary>
        /// 添加新商品（新商品添加需要审批才能上架）
        /// </summary>
        /// <returns></returns>
        int AddGoods(Goods goods);

        /// <summary>
        /// 统计订单
        /// </summary>
        /// <param name="OrderTime"></param>
        /// <returns></returns>
        int CountOrder(string OrderTime);
    }
}
