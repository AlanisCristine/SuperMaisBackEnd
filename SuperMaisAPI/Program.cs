
using SuperMaisAPI.AutoMapper;
using SuperMaisAPI.InjecaoDependencia;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(typeof(MappingProfile));
DependenciaInjecao.Inject(builder);

builder.Services.AddCors(options =>
{
    options.AddPolicy("PermitirTudo",
        builder =>
        {
            builder.AllowAnyOrigin()
                   .AllowAnyMethod()
                   .AllowAnyHeader();
        });
}); // Configuração do CORS

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("PermitirTudo"); // Permite requisições de qualquer origem (CORS)

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
