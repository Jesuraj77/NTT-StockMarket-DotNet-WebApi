using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockMarket.DataLayer.Dbcontext;

using StockMarket.Entities;

namespace StockMarket.BusinessLayer.Services
{
    public class UserServices : IUserServices
    {
        private StockDbcontext _context;

        public UserServices(StockDbcontext context)
        {
            _context = context;
        }


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
            Company Company= new Company();
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
