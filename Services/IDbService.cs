using Kolokwium_APBD1.DTO;
using Kolokwium_APBD1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kolokwium_APBD1.Services
{
        public interface IDbService
        {
        Task<Project> GetProject(int? ID);

        public MytaskDTO addTask();
        }
    }
