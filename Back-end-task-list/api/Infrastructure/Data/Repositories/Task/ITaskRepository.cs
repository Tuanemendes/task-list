using Api.Domain.Entities;

namespace Api.Repositories
{
    public interface ITaskRepository
    {
        Task<IEnumerable<TaskEntity>> ListAsync();
    }
}