
using Back_end_task_list.Domain.Enums;

namespace Back_end_task_list.Models
{
    public class TaskEntity
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public  Status TaskStatus {get; set; }
    }
}