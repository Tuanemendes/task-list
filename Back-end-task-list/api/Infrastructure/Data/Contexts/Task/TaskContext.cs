using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace Api.Infrastructure.Contexts
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