using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Domain.Models;

namespace TaskManager.Infastructure.Contract.Interfaces
{
    public interface ITaskManagerRepository
    {
        Task<List<TaskItem>> GetTaskItems(CancellationToken cancellationToken = default);
    }
}
