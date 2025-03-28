using System.ComponentModel.DataAnnotations;

namespace QuanLyDuAnAPI.Models
{
    public class ProjectTask
    {
        [Key]
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string TaskName { get; set; }
        public bool IsBillable { get; set; } = true;
        public Project Project { get; set; }
    }
}
