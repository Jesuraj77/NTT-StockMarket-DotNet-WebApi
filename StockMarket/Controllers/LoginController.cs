using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StockMarket.Entities;

namespace StockMarket.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        public bool Login(string UserName, string Password, string UserType)
        {
            return false;
        }

        public bool SignUp(User user)
        {
            return false;
        }
    }
}