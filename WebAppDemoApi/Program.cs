using WebAppDemoApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.       ///ADD SERVICES (Dependency injection)

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddSingleton()   1 об'єкт на програму для всіх сервісів (помилка у всіх)
//builder.Services.AddScoped()   1 об'єкт на сесію (1 з'єднання, декілька команд) HHTP
//builder.Services.AddTransient() 1 об'єкт на звернення (кожен раз перед зверненням)

builder.Services.AddSingleton<FileStoreService>();

var app = builder.Build();

// Configure the HTTP request pipeline.   //RUN
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
