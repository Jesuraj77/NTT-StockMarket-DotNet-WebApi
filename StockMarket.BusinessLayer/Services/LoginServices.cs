using StockMarket.BusinessLayer.Interfaces;
using StockMarket.DataLayer.Dbcontext;

using StockMarket.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.BusinessLayer.Services
{
    public class LoginServices : ILoginServices
    {

        private StockDbcontext _context;

        public LoginServices(StockDbcontext context)
        {
            _context = context;
        }

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
