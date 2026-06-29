using BlackBelt.Context;
using BlackBelt.Repositories;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;

namespace BlackBelt
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

            builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.LoginPath = "/Login/Index";
                    options.LogoutPath = "/Login/Logout";
                    options.AccessDeniedPath = "/Login/AcessoNegado";
                });

            builder.Services.AddAuthorization();

            builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            builder.Services.AddScoped<ITurmaRepository, TurmaRepository>();
            builder.Services.AddScoped<ILoginRepository, LoginRepository>();
            builder.Services.AddScoped<IAlunoRepository, AlunoRepository>();
            builder.Services.AddScoped<IPresencaRepository, PresencaRepository>();
            builder.Services.AddScoped<IHabilidadeRepository, HabilidadeRepository>();

            builder.Services.AddSession();

            var app = builder.Build();

            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();
            app.UseSession();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Login}/{action=Index}/{id?}");

            using (var scope = app.Services.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();

                var usuarioExistente = context.Usuarios.FirstOrDefault(u => u.Cpf == "12345678900");
                if (usuarioExistente != null)
                {
                    usuarioExistente.SenhaHash = BlackBelt.Models.CriptografiaSenha.SenhaHash("123");
                    context.Usuarios.Update(usuarioExistente);
                }
                else
                {
                    context.Usuarios.Add(new BlackBelt.Models.Usuario
                    {
                        Nome = "Usuário Mestre",
                        Cpf = "12345678900",
                        Email = "teste@teste.com",
                        Telefone = "(31) 99999-9999",
                        Dt_Nascimento = new DateOnly(1990, 1, 1),
                        Tipo_Usuario = "Admin",
                        SenhaHash = BlackBelt.Models.CriptografiaSenha.SenhaHash("123")
                    });
                }
                context.SaveChanges();
            }
//teste//
            app.Run();
        }
    }
}