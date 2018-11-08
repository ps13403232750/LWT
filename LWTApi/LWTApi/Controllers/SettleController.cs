using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Model;
namespace LWTApi.Controllers
{
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
        public ActionResult<List<ManageLimit>> GetManageLimit()
        {
            return settleServices.GetManageLimit().ToList();
        }

        /// <summary>
        /////采购结算列表显示 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("[action]")]
        public ActionResult<List<PurChaseSettle>> GetPurChaseSettle()
        {
            return settleServices.GetPurChaseSettle().ToList();
        }
  
        /// <summary>
        /////采购结算列表显示 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("[action]")]
        public ActionResult<List<PurChaseNumber>> ThinPurState()
        {
            return settleServices.ThinPurState().ToList();
        }

        /// <summary>
        /////额度详情
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("[action]")]
        public ActionResult<List<PurChaseNumber>> ThinMaLimite()
        {
            return settleServices.ThinMaLimite().ToList();
        }

        /// <summary>
        /// 额度审核状态
        /// </summary>
        /// <param name="id"></param>
        /// <param name="states"></param>
        /// <returns></returns>
        public ActionResult<int> UpdateSettle(int id, int states)
        {
            var list = settleServices.UpdateSettle(id, states);
            return list;
        }
    }
}