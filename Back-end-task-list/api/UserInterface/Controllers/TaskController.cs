using Api.Domain.Entities;
using Api.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace Api.UserInterface.Controllers

{
    [ApiController]
    [Route("api/[controller]")]
    public class TaskController : ControllerBase
    {
        private readonly ITaskService taskService;

        public TaskController(ITaskService taskService)
        {
            this.taskService = taskService;
        }

        [HttpGet]
        public async Task<IEnumerable<TaskEntity>> GetAllAsync()
        {
            var tasks = await this.taskService.ListAsync();
            return tasks;
        }
    }
}