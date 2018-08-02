using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOS.DataAccess.Data;
using SOS.DataAccess.Repository;
using SOS.DataAccess.Models;
using System.Net.Http;
using System.Net;

namespace SOS.Services
{
    
    public class ProjectDataService
    {
        MainDBContext db;
        RepositoryBaseMain<Project> Repo;

        public ProjectDataService()
        {
            db = new MainDBContext();
            Repo = new RepositoryBaseMain<Project>(db);
        }

        public IEnumerable<Project> GetProjectsService() {
            return Repo.FindAll();
        }

        public  Project GetProjectService(int id) {
            return Repo.Find(id);
        }

        public Project ModifiyProjectService(Project project)
        {
            return Repo.Modify(project);
        }

        public Project SaveProjectService(Project project)
        {
            return Repo.Save(project);
        }
        
        public bool DeleteProjectService(int id)
        {
            return Repo.Delete(id);
        }
    
    }
}
