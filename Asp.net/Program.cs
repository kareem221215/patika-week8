namespace Asp.net
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();

           /* 
            
           Explanation of Key Concepts:

           - Controller: Handles HTTP requests and returns responses.
           - Action: A method inside a controller that processes requests.
           - Model: Represents data and business logic.
           - View: The UI template (HTML + Razor syntax) rendered for the user.
           - Razor: A markup syntax for embedding C# in views.
           - RazorView: The actual rendered HTML page using Razor syntax.
           - wwwroot: Stores static files like CSS, JS, and images.
           - builder.Build(): Builds the application and its dependencies.
           - app.Run(): Starts the application and begins listening for requests.
           */
        }
    }
}
