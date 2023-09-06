using WebAppDemoApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.       ///ADD SERVICES (Dependency injection)

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddSingleton()   1 ��'��� �� �������� ��� ��� ������ (������� � ���)
//builder.Services.AddScoped()   1 ��'��� �� ���� (1 �'�������, ������� ������) HHTP
//builder.Services.AddTransient() 1 ��'��� �� ��������� (����� ��� ����� ����������)

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
