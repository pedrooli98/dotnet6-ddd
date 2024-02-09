var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddControllers();
}
// Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();
{
    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();
}
