using CrudTodoListApi.Data;

//dotnet ef migrations add CreateDatabase
//dotnet ef database update
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

builder.Services.AddDbContext<DataContext>();
var app = builder.Build();

app.MapControllers();

app.Run();
