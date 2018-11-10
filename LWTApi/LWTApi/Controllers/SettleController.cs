using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IServices;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Model;
namespace LWTApi.Controllers
{
    /// <summary>
    /// 跨域设置与指定路由
    /// </summary>
    [EnableCors("anyCors")]
    [Route("api/[controller]")]
    [ApiController]
    public class SettleController : ControllerBase
    {
        private ISettleServices settleServices;
        public SettleController(ISettleServices _settleServices)
        {
            settleServices = _settleServices;
        }

        /// <summary>
        ///额度管理表显示 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("[action]")]
        public ActionResult<List<Limit>> GetLimit()
        {
            var list = settleServices.GetLimit().ToList();
            return list;
        }

        /// <summary>
        /////采购结算列表
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("[action]")]
        public ActionResult<List<PurchaseSettle>> GetPurChaseSettle()
        {
            return settleServices.GetPurchaseSettle().ToList();
        }
  
        /// <summary>
        /////采购结算列表详情
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("[action]")]

        public ActionResult<List<Orders>> ThinPurState()
        {
            return settleServices.ThinPurState().ToList();
        }

        /// <summary>
        /////额度详情
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("[action]")]
        public ActionResult<List<Limit>> ThinMaLimite()
        {
            return settleServices.ThinMaLimite().ToList();
        }

        [HttpPut]
        [Route("[action]")]
        /// <summary>
        /// 额度审核状态
        /// </summary>
        /// <param name="id"></param>
        /// <param name="states"></param>
        /// <returns></returns>
        public ActionResult<bool> UpdateState(int id)
        {
            var list = settleServices.UpdateState(id, 1);
            return list;
        }
    }
}