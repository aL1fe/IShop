using DataAccessLayer;
using ServiceLayer;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>();
builder.Services.AddControllers();

//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ProductServices>();

var app = builder.Build();

// if (app.Environment.IsDevelopment())
// {
//     app.UseSwagger();
//     app.UseSwaggerUI();
// }

app.UseHttpsRedirection();

// app.UseCors(x => x.AllowAnyOrigin()); 
// app.UseCors(x => x.WithOrigins("https://localhost:7087; http://localhost:5087")
//     .AllowAnyHeader()
//     .AllowAnyMethod()
// );

app.UseAuthorization();

app.MapControllers();

app.Run();