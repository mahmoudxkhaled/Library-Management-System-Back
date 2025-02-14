using LMS.BL;
using LMS.DAL;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

#region Database

builder.Services.AddDbContext<LMSDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


#endregion
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddBusinessLayer();
builder.Services.AddDataAccessLayer();



#region Identity

builder.Services.AddIdentity<User, IdentityRole>(options =>
{
    // Dev Configuration
    options.User.RequireUniqueEmail = true;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequiredUniqueChars = 3;
    options.Password.RequiredLength = 5;
    options.Password.RequireDigit = false;
    options.Password.RequireUppercase = false;
    options.Password.RequireLowercase = false;

}).AddEntityFrameworkStores<LMSDbContext>()
  .AddDefaultTokenProviders();

#endregion

#region Authentication

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = "AppUserScema"; // for handling Authentication
    options.DefaultChallengeScheme = "AppUserScema"; // for handling Challenge
}).AddJwtBearer("AppUserScema", options =>
{

    // Access secretkey to use it to validate Requests
    string? stringKey = builder.Configuration.GetValue<string>("SecretKey");
    byte[] keyASBytes = Encoding.ASCII.GetBytes(stringKey!);
    SymmetricSecurityKey key = new SymmetricSecurityKey(keyASBytes);

    options.TokenValidationParameters = new TokenValidationParameters
    {
        IssuerSigningKey = key,
        ValidateIssuer = false,
        ValidateAudience = false,
    };
});

#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
