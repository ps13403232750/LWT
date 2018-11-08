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
    }
}
