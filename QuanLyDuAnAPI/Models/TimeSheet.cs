
using System.ComponentModel.DataAnnotations;
namespace QuanLyDuAnAPI.Models
{
    public class TimeSheet
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ProjectId { get; set; }
        public int TaskId { get; set; }
        public DateTime Date { get; set; }
        public decimal Hours { get; set; }
        public bool IsBillable { get; set; } = true;
        public bool IsOvertime { get; set; } = false;
        public User User { get; set; }
        public Project Project { get; set; }
        public Task Task { get; set; }

    }
}
