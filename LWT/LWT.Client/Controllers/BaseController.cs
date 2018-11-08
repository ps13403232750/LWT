using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using LWT.Common;
using LWT.Client.Models;

namespace LWT.Client.Controllers
{
    public class BaseController : Controller
    {
        public UserData LoginInfo
        {
            get
            {
                return RedisHelper.Get<UserData>(_loginInfo.Id.ToString()); ;
            }
        }
    }
}