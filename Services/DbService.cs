using Kolokwium_APBD1.DTO;
using Kolokwium_APBD1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Kolokwium_APBD1.Services
{
    public class DbService : IDbService
    {

        private readonly ProjDbContext _db;
       
        public SqlConnection connection;

      
        public DbService(ProjDbContext db)
        {
            _db = db;
        }

        public MytaskDTO addTask()
        {
            throw new NotImplementedException();
        }

        public async Task<Project> GetProject(int? ID)
        {
            
            var project = await _db.Projects
                .Where(p => p.IdProject == ID)
                .SingleOrDefaultAsync();

            return project;
        }
            
        
    }
}
