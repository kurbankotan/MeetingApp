var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();

app.UseStaticFiles(); //wwwroot altındaki dosyaların erişime açılması için
app.UseRouting();     // Routing için bu middleware'in eklenmesi lazım

//Böyle tek tek tanımlanabilir
// app.MapGet("/", () => "Hello World!");
// app.MapGet("/abc", () => "Deneme");


// Ya da genel olarak tanımlanabilir
//{controller=Home}/{action=Index}/{id?}
//app.MapDefaultControllerRoute();

//Ya da genel yazımın daha uzun şekli olarak aşağıdaki gibi yazılabilir
app.MapControllerRoute(
    name:"default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);




app.Run();