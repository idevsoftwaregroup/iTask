using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Application.Contract.DTOs;
using TaskManager.Application.Contract.Interfaces;
using TaskManager.Infastructure.Contract.Interfaces;

namespace TaskManager.Application.Services
{
    public class TaskManagerService : ITaskManagerService
    {
        private readonly ITaskManagerRepository _repo;
        public TaskManagerService(ITaskManagerRepository repo)
        {
            this._repo = repo;
        }
        public async Task<List<TaskItemApplicationDTO>> GetTaskItems(CancellationToken cancellationToken = default)
        {
            return (await _repo.GetTaskItems(cancellationToken)).Select(x => new TaskItemApplicationDTO
            {
                ID = x.Id,
                Title = x.Title,
            }).ToList();
        }
    }
}
