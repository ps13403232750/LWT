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

>>>>>>> 6a2b4cc2e97d689484881e2455d258b0140d7f5a
    }
}