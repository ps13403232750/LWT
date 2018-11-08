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
        public  SettleController (ISettleServices _settleServices)
        {
            settleServices = _settleServices;
        }
        /// <summary>
        ///额度管理表显示 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("[action]")]
        public ActionResult<List<ManageLimit>> GetManageLimits()
        {
            return settleServices.GetManageLimits().ToList();
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

        //public ActionResult UpdateSettle(int id,int states)
        //{
            
        //}

    }
}