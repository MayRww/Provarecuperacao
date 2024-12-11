var builder = WebApplication.CreateBuilder(args);
var builder.services.AppDbContext<AppDataContext> ();
var app = builder.Build();

app.MapGet("/api/IMC/listar", ([fromServices]) => Maiara.db context ); =>
{

    if (ctx.imc.any())
    {
       return Results.OK (ctx.imc.ToList);
    }

    return Results.Notfound ();
}

app.MapPost("/Aluno", async (Aluno aluno, Maiara.db context) =>
{
    context.Add(aluno);
    await context.SaveChangesAsync();
    return Results.Created($"/aluno/{aluno.id}", alunos);
}


app.MapPut("/imc/{aluno}", async (string Nome, IMC iMCAtualizado, Maiara.db context) =>
{
    var IMC = await context.IMC.FindAsync(id);
    if (IMC == null)
    {
        return Results.NotFound("IMC não encontrado.");
    }

    IMC.Nome = iMCAtualizadoAtualizado.Nome;
    IMC.decimaç = IMCAtualizado.decimal;
    await context.SaveChangesAsync();
    return Results.Ok("IMC atualizado com sucesso.");
});

);

app.Run();
