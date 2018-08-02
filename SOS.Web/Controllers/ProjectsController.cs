using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SOS.DataAccess.Data;
using SOS.DataAccess.Repository;
using SOS.DataAccess.Models;
using SOS.Services;
using System.Web.Http.Cors;

namespace SOS.Web.Controllers
{
    [EnableCors(origins:"*",headers:"*",methods:"*")]
    public class ProjectsController : ApiController
    {
        public ProjectDataService ProjectDataService;

        public ProjectsController()
        {
            ProjectDataService = new ProjectDataService();
        }
  
        // GET: api/Projects
        public IHttpActionResult GetProjects() {
            try
            {
                return Ok(ProjectDataService.GetProjectsService());
            }
            catch (Exception ex){
                
                return ResponseMessage(Request.CreateErrorResponse(HttpStatusCode.InternalServerError,ex));
            }
        }

        // GET: api/Project/id
        public IHttpActionResult GetProject(int id){
            try
            {
                return Ok(ProjectDataService.GetProjectService(id));
            }
            catch (Exception ex)
            {
                return ResponseMessage(Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex));
            }
        }

        // PUT: api/Project/id
        public IHttpActionResult PutProjects(Project project)
        {
            try
            {
                return Ok(ProjectDataService.ModifiyProjectService(project));
            }
            catch (Exception ex)
            {
                return ResponseMessage(Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex));
            }
        }

        // POST: api/Projects
        public IHttpActionResult PostProjects(Project project)
        {
            try
            {
                return Ok(ProjectDataService.SaveProjectService(project));
            }
            catch (Exception ex)
            {
                return ResponseMessage(Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex));
            }
        }

        // DELETE: api/Project/id
        public IHttpActionResult DeleteProject(int id)
        {
            try
            {
                return Ok(ProjectDataService.DeleteProjectService(id));
            }
            catch (Exception ex)
            {
                return ResponseMessage(Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex));
            }
        }

    }
}
