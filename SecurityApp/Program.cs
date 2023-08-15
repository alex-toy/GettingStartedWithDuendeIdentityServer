using Microsoft.AspNetCore.Authentication;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

AuthenticationBuilder authenticationBuilder = builder.Services.AddAuthentication(defaultScheme: "cookies");
authenticationBuilder.AddCookie("cookies", options =>
{
    options.Cookie.Name = "demo";
    options.ExpireTimeSpan = TimeSpan.FromMinutes(5);
    options.LoginPath = new PathString("/account/login");
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();

app.Run();
