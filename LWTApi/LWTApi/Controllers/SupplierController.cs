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
        [HttpGet]
        [Route("[action]")]
        public ActionResult<List<Goods>> GetGoods()
        {
            var list = _supplierServices.Goods().ToList();
            return list;
        }
<<<<<<< HEAD

=======
        [HttpPut]
        [Route("[action]")]
        public ActionResult <bool> UpdateGoods(int Id, int State=1)
        {
            var list = _supplierServices.UpdateGoods(Id, State);
            return list;
        }
>>>>>>> d22afad3913962c21401aa4cd4e455468a61952f
    }
}