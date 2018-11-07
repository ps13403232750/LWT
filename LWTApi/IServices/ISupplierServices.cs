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
        List<Goods> GetGoods();
    }
}
