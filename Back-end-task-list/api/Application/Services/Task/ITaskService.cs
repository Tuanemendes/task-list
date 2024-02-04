using Api.Domain.Entities;

namespace Api.Application.Services
{
    public interface ITaskService
    {
        Task<IEnumerable<TaskEntity>> ListAsync();
    }
}