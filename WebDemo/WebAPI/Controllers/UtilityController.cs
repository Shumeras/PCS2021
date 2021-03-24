using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    public class UtilityController : Controller
    {
        public UtilityController()
        {

        }
        public IActionResult Get()
        {
            return Unauthorized("Nope");
        }
    }
}
