using HotChocolate.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>();

var app = builder.Build();

// Use the wwwroot/index.html as homepage
app.UseDefaultFiles();
app.UseStaticFiles();

app.MapGraphQL(path: "/graphql")
    .WithOptions(o =>
    {
        // Disable the Banana Cake Pop GraphQL IDE
        o.Tool.Enable = false;
    });

app.Run();
