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
    public class AdminController : ControllerBase
    {
        [HttpGet]
        public List<Company> GetAllCompany()
        {
            List<Company> CompanyList = new List<Company>();
            return CompanyList;
        }

        [HttpPost]
        public bool AddCompany(List<Company> company)
        {

            return false;

        }


        public bool DeleteCompany(int Id)
        {
            return true;
        }


        public Company UpdateCompany(int Id)
        {
            Company Company = new Company();
            return Company;
        }


        public Company GetCompanyById(int Id)
        {
            Company Company = new Company();
            return Company;
        }


        public IPODetail GetIPOById(int Id)
        {
            IPODetail IPOdetail = new IPODetail();
            return IPOdetail;
        }


        public bool ImportData(object file)
        {
            return true;
        }


        public IPODetail UpdateIPODetail(int Id)
        {
            IPODetail IPOdetail = new IPODetail();
            return IPOdetail;
        }


        public Company ViewCompany(int Id)
        {
            Company CompanyList = new Company();
            return CompanyList;
        }

      
    }
}

  