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
        private IUserServices UserServices;
        public ValuesController(IUserServices userServices)
        {
            UserServices = userServices;
        }

        /// <summary>
        /// 权限列表信息显示
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("[action]")]
        public ActionResult<List<Power>> GetPower()
        {
            return UserServices.GetPowerMessage().ToList();
        }

        // GET api/values
        [HttpGet]
        public ActionResult<string> Get()
        {
            return UserServices.Add(new Users()).ToString();
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
            var i = UserServices.Add(user);
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
