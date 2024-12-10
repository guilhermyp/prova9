using ProjetoImc.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Aspnetcore.Mvc;
using System.Linq;

var app = builder.Build();

builder.services.addControllers().AddJsonoptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = System.Text.JsonSerializerOptions.ReferenceHandler.Preserve;
});
    builder.services.AddCors(options=>
    options.addPolicy("Acesso total",
    Configs => Configs
    .allowAnyOrigin()
    .AllowAnyHeader()
    .AllowAnyMethod())
);    

//CADASTRAR ALUNO
app.MapPost("/ProjetoImc/Aluno/Cadastrar", ([FromBody] Aluno aluno, [FromServices] AppDataContext ctx) =>
{
    if (aluno == aluno)
    {
        return Results.notfound($"Aluno já cadastrado");
    }
    else
    {
    ctx.aluno.add(aluno);
    ctx.SaveChanges();
    }
});

//LISTAR ALUNO
app.MapGet("/ProjetoImc/Aluno/Listar", ([FromServices] AppDataContext ctx)=>
{
return Results.ok(ctx.aluno.tolist());
});


//EDITAR ALUNO POR ID
app.MapPut("ProjetoImc/Aluno/Editar/{AlunoId}",([FromServices] AppDataContext ctx, int AlunoId, [FromBody] Aluno updatedAluno) =>
{
    var aluno ctx.alunos.FirstOrDefault(e => e.Id == AlunoId);
    {
    
    return Result.NotFound($"Aluno com id:{alunoId} não encontrado");
    
    }
    
    aluno.nome = updatedAluno.nome ?? aluno.nome;
    aluno.SobrenomeAluno = updatedAluno.SobrenomeAluno ?? aluno.SobrenomeAluno;

});

//CADASTRAR IMC'S
app.MapPost("/ProjetoImc/Imc/Cadastrar", ([FromBody] Imc imc, [FromServices] AppDataContext ctx) =>
{
    ctx.imc.add(imc);
    ctx.SaveChanges();
    
});


//LISTAR IMC's
app.MapGet("/ProjetoImc/Imc/Listar", ([FromServices] AppDataContext ctx)=>
{

//CALCULAR IMC 
return Results.ok(ctx.Imc.tolist());
});

//ALTERAR IMC's
app.MapPut("ProjetoImc/Imc/Editar/{Imcid}",([FromServices] AppDataContext ctx, int ImcId, [FromBody] Imc updatedImc) =>
{
    var Imc ctx.imcs.FirstOrDefault(e => e.Id == ImcId);
    {
    
    return Result.NotFound($"IMC com id:{ImcId} não encontrado");
    
    }
    
    imc.peso = updatedImc.peso ?? imc.altura;
    imc.altura = updatedImc.altura ?? imc.altura;

});

App.userCors("Acesso Total");
App.run;


