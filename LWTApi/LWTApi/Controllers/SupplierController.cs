﻿using System;
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
        public ActionResult<List<OrderList>> GetOrderList(int OrderNum)
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
    } 
}