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
    .WithOptions(new GraphQLServerOptions
    {
        // Disable the Banana Cake Pop GraphQL IDE
        Tool = { Enable = false }
    });

app.Run();
