
using Api.Enums;

namespace Api.Domain.Entities
{
    public class TaskEntity
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public Status TaskStatus { get; set; }
    }
}