using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOS.DataAccess.Data
{
    public class MainDBContext:DbContext
    {
        public MainDBContext() : base("SysCon")
        {
            //Database.SetInitializer<MainDBContext>(new DropCreateDatabaseAlways<MainDBContext>());
        }
        public DbSet<Models.Project> Projects { get; set; }
        public DbSet<Models.Company> Companies { get; set; }
    }
}
