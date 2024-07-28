using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using TaskManager.Application.Contract.DTOs;
using TaskManager.Application.Contract.Interfaces;

namespace TaskManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskManagerController : ControllerBase
    {
        private readonly ITaskManagerService _taskManagerService;
        public TaskManagerController(ITaskManagerService taskManagerService)
        {
            this._taskManagerService = taskManagerService;
        }
        [HttpGet("GetTaskItems")]
        public async Task<ActionResult<List<TaskItemApplicationDTO>>> GetTaskItems(CancellationToken cancellationToken = default)
        {
            var data = await _taskManagerService.GetTaskItems(cancellationToken);
            return data.Any() ? Ok(data) : StatusCode((int)HttpStatusCode.NoContent, data);
        }
    }
}
