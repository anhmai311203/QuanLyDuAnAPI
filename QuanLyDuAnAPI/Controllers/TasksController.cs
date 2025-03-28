using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuanLyDuAnAPI.Data;
using QuanLyDuAnAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QuanLyDuAnAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly AppDbContext _context;

        public TasksController(AppDbContext context)
        {
            _context = context;
        }

        // Lấy danh sách tất cả Tasks
        [HttpGet("{id}")]
        public async Task<ActionResult<QuanLyDuAnAPI.Models.Task>> GetTask(int id)
        {
            var task = await _context.Tasks.FindAsync(id);
            if (task == null)
            {
                return NotFound();
            }
            return Ok(task);
        }

        // Lấy thông tin Task theo ID



        // Thêm một Task mới
        [HttpPost]
        public async Task<ActionResult<QuanLyDuAnAPI.Models.Task>> CreateTask(QuanLyDuAnAPI.Models.Task task)
        {
            _context.Tasks.Add(task);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetTask), new { id = task.Id }, task);
        }



        // Cập nhật thông tin Task
        [HttpPut("{id}")]
        public async Task<ActionResult<QuanLyDuAnAPI.Models.Task>> UpdateTask(int id, QuanLyDuAnAPI.Models.Task task)
        {
            if (id != task.Id) return BadRequest();
            _context.Entry(task).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        // Xóa một Task
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTask(int id)
        {
            var task = await _context.Tasks.FindAsync(id);
            if (task == null) return NotFound();
            _context.Tasks.Remove(task);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
