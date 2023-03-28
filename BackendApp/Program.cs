var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//var MyAllowSpecificOrigins1 = "http://20.48.8.213";
//var MyAllowSpecificOrigins2 = "http://20.78.254.111";
//var MyAllowSpecificOrigins3 = "http://20.18.210.37";
//var MyAllowSpecificOrigins4 = "http://20.27.43.119";
//builder.Services.AddCors(options =>
//{
//    options.AddPolicy(name: MyAllowSpecificOrigins,
//                      build =>
//                      {
//                          build.WithOrigins("http://20.48.8.213", "http://20.78.254.111", "http://20.18.210.37", "http://20.27.43.119")
//                          .AllowAnyOrigin()
//                          .AllowAnyHeader()
//                          .AllowAnyMethod();
//                      });


//});

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
app.UsePathBase("/backend");
app.UseCors(options =>
{
    options.WithOrigins("http://20.48.8.213", "http://20.78.254.111", "http://20.18.210.37", "http://20.27.43.119");
    options.AllowAnyHeader();
    options.AllowAnyMethod();
});
app.UseAuthorization();
//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});
app.Run();
