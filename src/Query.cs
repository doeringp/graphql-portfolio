namespace Server;

public class Query
{
    public string Name { get; set; } = "Peter Doering";
    public string Location { get; set; } = "Germany";

    public string Homepage { get; set; } = "https://www.peter-doering.com";
    public string Github { get; set; } = "https://github.com/doeringp";

    public string EmployedAt { get; set; } = "Liebherr";
    public string Job { get; set; } = "Full Snack 🍕🍿🍰 Software Developer";

    public string[] ExpertFor { get; set; } = {
        "Designing Web APIs",
        "GraphQL",
        "OpenID Connect",
        "DevOps"
    };

    public string[] CurrentlyLearning { get; set; } = {
        "Functional Programming in C#",
        "GraphQL"
    };

    /// <summary>
    /// The technologies and frameworks I personally use every day to 
    /// built (green emission-free 🌳 and user-friendly) software.
    /// </summary>
    public string[] Stack {get; set; } = {
        ".NET",
        "ASP.NET Core",
        "Entity Framework Core",
        "GraphQL",
        "REST",
        "OpenAPI",
        "gRPC",
        "WCF",
        "MS SQL Server",
        "SQLite",
        "Docker",
        "Kubernetes",
        "Elasticsearch",
        "Azure DevOps",
        "GitHub",
        "Angular",
    };

    /// <summary>
    /// The programming languages I know well
    /// </summary>
    public string[] ProgrammingLanguages { get; set; } = {
        "C#",
        "JavaScript",
        "TypeScript",
        "Python",
    };

    public Product[] ExpertForProducts { get; set; } = {
        new(
            "IdentityServer", 
            "OpenID Connect and OAuth 2.x framework for ASP.NET Core", 
            "https://duendesoftware.com/products/identityserver"
        ),
        new(
            "Hot Chocolate", 
            "Open-source GraphQL server for the Microsoft .NET platform", 
            "https://chillicream.com/docs/hotchocolate/v13"
        ),
        new(
            "Azure DevOps", 
            "Azure DevOps is an end-to-end software development platform", 
            "https://dev.azure.com/"
        ),
    };
}

public record Product(string Name, string Description, string Homepage);
