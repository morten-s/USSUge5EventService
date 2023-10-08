var builder = WebApplication.CreateBuilder(args);
builder.Services.Scan(selector => selector
        .FromAssemblyOf<Program>()
        .AddClasses(c => c.Where(t =>  t.GetMethods().All(m => m.Name != "<Clone>$")))
        .AsImplementedInterfaces());
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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
