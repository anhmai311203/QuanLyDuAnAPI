using Microsoft.EntityFrameworkCore;
using QuanLyDuAnAPI.Data;

var builder = WebApplication.CreateBuilder(args);

// Thêm kết nối database
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();
app.Run();
