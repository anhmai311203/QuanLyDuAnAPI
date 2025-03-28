using System.ComponentModel.DataAnnotations;

namespace QuanLyDuAnAPI.Models
{
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public int? ClientId { get; set; }
        public string Status { get; set; } = "Active";
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public string ProjectCode { get; set; }
        public DateTime? StartDate { get; set; }
        public Client Client { get; set; }
    }
}
