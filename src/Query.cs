namespace Server;

public class Query
{
    public string Name { get; set; } = "Peter Doering";
    public string Location { get; set; } = "Germany";

    public string Homepage { get; set; } = "https://www.peter-doering.com";
    public string Github { get; set; } = "https://github.com/doeringp";

    public string EmployedAt { get; set; } = "Liebherr";
    public string Job { get; set; } = "Full Snack 🍕🍿🍰 Software Developer";

    /// <summary>
    /// The topics I am an expert in.
    /// </summary>
    public string[] ExpertFor { get; set; } = {
        "Designing Web APIs",
        "GraphQL",
        "OpenID Connect",
        "DevOps"
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
}
