using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium_APBD1.Models
{
    public class ProjDbContext : DbContext 
    {
        public ProjDbContext() { }
        public ProjDbContext(DbContextOptions opts)
            : base(opts) { }
        public DbSet<Project> Projects { get; set; }
        public DbSet<TaskType> TaskTypes { get; set; }
        public DbSet<TeamMember> TeamMembers { get; set; }
        public DbSet<MyTask> MyTasks { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            base.OnModelCreating(mb);
            mb.Entity<TeamMember>(entity =>

               entity.HasData(new TeamMember { FirstName = "Andrzej", LastName = "Kowalski", Email = "email@wp.pl", IdTeamMember = 1 }));

            mb.Entity<MyTask>(entity =>

               entity.HasData(new MyTask { IdTask = 1, DateTime = new DateTime(09 / 05 / 2019), IdTeam = 1, Description = "Test task", IdAssignedTo = 1, Name = "new task", IdCreator = 1, IdTaskType = 1  }));


        
            mb.Entity<Project>(entity =>

                entity.HasData(new Project { IdProject = 1, Date = new DateTime(09 / 05 / 2019), IdTeam = 1, Name ="Projekt" }));
 

        }

    }
}
