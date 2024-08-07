var builder = WebApplication.CreateBuilder(args);

var PatToken = "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";

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

 var password =  "https://cdb-ing-blt-dev-nosql.documents.azure.com:443/";
 var password1 = "H1Ndaslp6JTOms6MvlzOtQkN4k5SzvUlfm2vlxT7SvKEltm87QnzTYjQNWu8PW0DP1gB5RI0DFttACDbVlG96g==";

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
