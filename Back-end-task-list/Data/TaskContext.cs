
using Microsoft.EntityFrameworkCore;
using Back_end_task_list.Models; 

namespace Back_end_task_list.Data
{
    public class TaskContext : DbContext
    {
        public TaskContext(DbContextOptions<TaskContext> options) : base(options)
        {
        }

        public DbSet<TaskEntity> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var task = modelBuilder.Entity<TaskEntity>();
            task.ToTable("tb_task");
            task.HasKey(x => x.Id);
            task.Property(x => x.Id).HasColumnName("id_task").ValueGeneratedOnAdd();
            task.Property(x => x.Description).HasColumnName("description");
            task.Property(x => x.TaskStatus).HasColumnName("status");
        }

    }
}