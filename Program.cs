namespace RecapMvc
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();//Make it Mvc Compatiable.
            var app = builder.Build();
            //app.UseStaticFiles();//For JS, CSS and other non editing files.
            app.MapControllerRoute(
                name: "Default",
                pattern: "{controller=FirstExample}/{action=DisplayView}/{id?}"
            );
            app.Run();
        }
    }
}