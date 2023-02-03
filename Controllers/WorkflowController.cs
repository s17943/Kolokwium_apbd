using Kolokwium_APBD1.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

namespace Kolokwium_APBD1.Controllers
{
 
        [Microsoft.AspNetCore.Components.Route("/api/projects/3 HTTP/1.1")]
        [ApiController]
        public class WorkflowController : ControllerBase
        {
            private readonly IDbService _DbService;

            public WorkflowController(IDbService service)
            {
                _DbService = service;
            }

            [HttpGet("{id}")]
            public async Task<IActionResult> GetProject(int id)
            {
                 var project = await _DbService.GetProject(id);
                if (project == null)
                    return NotFound();
                else return Ok(project);
                
            }

            [HttpPost("{id}")]
            public IActionResult AddTask(int id)
            {
                return Ok();
            }

    }
}

