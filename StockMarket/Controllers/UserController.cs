using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StockMarket.Entities;

namespace StockMarket.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public List<Company> DisplayChart(List<Color> color)
        {

            List<Company> CompanyList = new List<Company>();
            return CompanyList;
        }

        public bool ExportDataFromChart(Chart chart)
        {
            return true;
        }

        public List<Company> FilterCompany(string CompanyName, string CompanyCode)
        {
            List<Company> CompanyList = new List<Company>();
            return CompanyList;
        }

        public Chart GetChart(Company company, string StockExchange, DateTime FromPeriod, DateTime ToPeriod)
        {
            Chart chart = new Chart();
            return chart;
        }

        public Company SearchCompany(string CompanyName)
        {
            Company Company = new Company();
            return Company;
        }

        public User UpdateProfile(string UserName)
        {
            User user = new User();
            return user;
        }
        public User GetUserById(int Id)
        {
            User user = new User();
            return user;

        }

    }
}