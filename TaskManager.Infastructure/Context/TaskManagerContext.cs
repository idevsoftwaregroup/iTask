using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Domain.Models;

namespace TaskManager.Infastructure.Context
{
    public class TaskManagerContext : DbContext
    {
        public DbSet<TaskItem> TaskItems { get; set; }

        public TaskManagerContext(DbContextOptions<TaskManagerContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region TaskItem

            modelBuilder.Entity<TaskItem>().Property(x => x.Title).IsRequired();

            #endregion

            base.OnModelCreating(modelBuilder);
        }
    }
}
