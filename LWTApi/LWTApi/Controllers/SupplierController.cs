using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using Model;
using IServices;
using SqlSugar;
namespace LWTApi.Controllers
{
    [Route("api/[controller]")]

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
            return _supplierServices.Goods().ToList();
        }
        
    }
}