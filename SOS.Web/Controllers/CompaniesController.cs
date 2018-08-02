using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SOS.Services;
using SOS.DataAccess.Models;

namespace SOS.Web.Controllers
{
    public class CompaniesController : ApiController
    {
        public CompanyDataService CompanyDataService;

        //public CompaniesController()
        //{
        //    CompanyDataService = new CompanyDataService();
        //}

        //// GET: api/Companies
        //public IHttpActionResult GetCompanies()
        //{
        //    try
        //    {
        //        return Ok(CompanyDataService.GetCompaniesService());
        //    }
        //    catch (Exception ex)
        //    {

        //        return ResponseMessage(Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex));
        //    }
        //}

        //// GET: api/Company/id
        //public IHttpActionResult GetCompany(int id)
        //{
        //    try
        //    {
        //        return Ok(CompanyDataService.GetCompanyService(id));
        //    }
        //    catch (Exception ex)
        //    {
        //        return ResponseMessage(Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex));
        //    }
        //}

        //// DELETE: api/Project/id
        //public IHttpActionResult DeleteCompany(int id)
        //{
        //    try
        //    {
        //        return Ok(CompanyDataService.DeleteCompanyService(id));
        //    }
        //    catch (Exception ex)
        //    {
        //        return ResponseMessage(Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex));
        //    }
        //}

        //// DELETE: api/Projects
        //public IHttpActionResult DeleteCompanies(Company company)
        //{
        //    try
        //    {
        //        return Ok(CompanyDataService.DeleteCompaniesService(company));
        //    }
        //    catch (Exception ex)
        //    {
        //        return ResponseMessage(Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex));
        //    }
        //}

        //// POST: api/Projects
        //public IHttpActionResult PutProjects(Company company)
        //{
        //    try
        //    {
        //        return Ok(CompanyDataService.ModifiyCompanyService(company));
        //    }
        //    catch (Exception ex)
        //    {
        //        return ResponseMessage(Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex));
        //    }
        //}
        //// PUT: api/Project/id
        //public IHttpActionResult PutProjects(int id, Company company)
        //{
        //    try
        //    {
        //        return Ok(CompanyDataService.ModifiyCompanyService(company));
        //    }
        //    catch (Exception ex)
        //    {
        //        return ResponseMessage(Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex));
        //    }
        //}
    }

}
