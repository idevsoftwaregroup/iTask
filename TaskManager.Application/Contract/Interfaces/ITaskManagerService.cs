using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Application.Contract.DTOs;

namespace TaskManager.Application.Contract.Interfaces
{
    public interface ITaskManagerService
    {
        Task<List<TaskItemApplicationDTO>> GetTaskItems(CancellationToken cancellationToken = default);
    }
}
