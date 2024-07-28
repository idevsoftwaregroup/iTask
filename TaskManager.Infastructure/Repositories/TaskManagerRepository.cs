using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Domain.Models;
using TaskManager.Infastructure.Context;
using TaskManager.Infastructure.Contract.Interfaces;

namespace TaskManager.Infastructure.Repositories
{
    public class TaskManagerRepository : ITaskManagerRepository
    {
        private readonly TaskManagerContext _context;
        public TaskManagerRepository(TaskManagerContext context)
        {
            this._context = context;    
        }

        public async Task<List<TaskItem>> GetTaskItems(CancellationToken cancellationToken = default)
        {
            try
            {
                return await _context.TaskItems.ToListAsync(cancellationToken: cancellationToken);
            }
            catch (Exception)
            {

                return new List<TaskItem>();
            }
        }
    }
}
