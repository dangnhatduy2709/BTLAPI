using BLL.Interfaces;
using BLL;
using DAL;
using DAL.Helper;
using DAL.Interface;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
});

builder.Services.AddTransient<IDatabaseHelper, DatabaseHelper>();

builder.Services.AddTransient<IMatHangReponsitory, MatHangRepository>();
builder.Services.AddTransient<IMatHangBusiness, MatHangBusiness>();

builder.Services.AddTransient<ILoaiHangReponsitory, LoaiHangRepository>();
builder.Services.AddTransient<ILoaiHangBusiness, LoaiHangBusiness>();

builder.Services.AddTransient<INhaCCRepository, NhaCCRepository>();
builder.Services.AddTransient<INhaCCBusiness, NhaCCBusiness>();




// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseRouting();

app.UseCors(x => x
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader());

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
