using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IServices;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Model;
using Services;

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
        /// 额度管理表
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("[action]")]
        public ActionResult<List<Limits>> GetLimit()
        {
            return settleServices.GetLimit().ToList();
        }

        /// <summary>
        ///额度管理表分页
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        public ActionResult<PageResult<Limits>> GetLimitPageList(PageParams pageParams)
        {
            var list = settleServices.GetSettlePageList(pageParams);
            return list;
        }

        /// <summary>
        /////采购结算列表
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("[action]")]
        public ActionResult<List<Settle>> GetPurchaseSettle()
        {
            return settleServices.GetPurchaseSettle().ToList();
        }

        /// <summary>
        ///采购结算列表分页
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        public ActionResult<PageResult<Settle>> SettlePageList(PageParams pageParams)
        {
            var list = settleServices.SettlePageList(pageParams);
            return list;
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
        public ActionResult<List<Limits>> ThinMaLimite()
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