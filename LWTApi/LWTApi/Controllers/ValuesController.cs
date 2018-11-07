using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using IServices;
using Model;

namespace LWTApi.Controllers
{
    [Route("api/[controller]")]

    [ApiController]
    public class ValuesController : ControllerBase
    {
        private IUserServices userServices;
        private ISettleServices settleServices;
        public ValuesController(IUserServices _userServices)
        {
            userServices = _userServices;
        }

        /// <summary>
        /// 权限列表信息显示
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("[action]")]
        public ActionResult<List<Power>> GetPower()
        {
            return userServices.GetPowerMessage().ToList();
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
        ///采购结算类表显示 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("[action]")]
        public ActionResult<List<PurChaseSettle>> GetPurChaseSettle()
        {
            return settleServices.GetPurChaseSettle().ToList();
        }

        // GET api/values
        [HttpGet]
        public ActionResult<string> Get()
        {
            return userServices.Add(new Users()).ToString();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [Route("AddUser")]
        [HttpPost]
        public int AddUser(Users user)
        {
            var i = userServices.Add(user);
            return i;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
