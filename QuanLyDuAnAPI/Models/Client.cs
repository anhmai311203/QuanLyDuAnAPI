using System.ComponentModel.DataAnnotations;

namespace QuanLyDuAnAPI.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public ICollection<Project> Projects { get; set; } = new List<Project>();
    }
}
