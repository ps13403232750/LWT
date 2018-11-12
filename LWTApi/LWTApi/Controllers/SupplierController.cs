using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using Model;
using IServices;
using SqlSugar;
using Microsoft.AspNetCore.Cors;

namespace LWTApi.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("anyCors")]
    [ApiController]
    public class SupplierController : Controller
    {
        private ISupplierServices _supplierServices;
        public SupplierController(ISupplierServices supplierServices)
        {
            _supplierServices = supplierServices;
        }

        /// <summary>
        /// 获取商品信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("[action]")]
        public ActionResult<List<Goods>> GetGoods()
        {
            var result = _supplierServices.Goods().ToList();
            return result;
        }       

        /// <summary>
        /// 用户列表分页
        /// </summary>
        /// <param name="pageParams"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        public ActionResult<PageResult<Goods>> PageGoods(PageParams pageParams)
        {
            var list = _supplierServices.PageGoods(pageParams);
            return list;
        }

        /// <summary>
        /// 订单列表分页
        /// </summary>
        /// <param name="pageParams"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        public ActionResult<PageResult<Orders>> PageOrders(PageParams pageParams)
        {
            var list = _supplierServices.PageOrders(pageParams);
            return list;
        }

        /// <summary>
        /// 审核提交的商品信息
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="State"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("[action]")]
        public ActionResult<bool> UpdateGoods(int Id, int State = 1)
        {
            var result = _supplierServices.UpdateGoods(Id, State);
            return result;
        }

        /// <summary>
        /// 获取订单表数据
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("[action]")]
        public ActionResult<List<Orders>> GetOrder()
        {
            var result = _supplierServices.GetOrder().ToList();
            return result;
        }
        
        /// <summary>
        /// 获取订单从表数据
        /// </summary>
        /// <returns></returns>1
        [HttpGet]
        [Route("[action]")]
        public ActionResult<List<OrderList>> GetOrderList(string OrderNum)
        {
            var result = _supplierServices.GetOrderList(OrderNum).ToList();
            return result;
        }

        /// <summary>
        /// 添加新商品
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        public int AddGoods(Goods goods)
        {
            var result = _supplierServices.AddGoods(goods);
            return result;
        }

        [HttpGet]
        [Route("[action]")]
        public int CountOrder(string OrderTime)
        {
            var result = _supplierServices.CountOrder(OrderTime);
            return result;
        }

    } 
}