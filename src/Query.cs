namespace Server;

public class Query
{
    public string Name { get; set; } = "Peter Doering";
    public string Location { get; set; } = "Germany";

    public string Homepage { get; set; } = "https://www.peter-doering.com";
    public string Github { get; set; } = "https://github.com/doeringp";

    public string Job { get; set; } = "Full Snack 🍕🍿🍰 Software Developer";

    /// <summary>
    /// The programming languages I'm experienced with.
    /// </summary>
    public string[] ProgrammingLanguages { get; set; } = {
        "C#",
        "JavaScript",
        "TypeScript",
        "Python",
    };

    /// <summary>
    /// Programming paradigms I use to solve real life problems.
    /// </summary>
    public string[] ProgrammingParadigms { get; set; } = {
        "Object-oriented",
        "Functional",
        "Domain-driven",
        "Event-driven",
    };

    public string[] Methodologies { get; set; } = {
        "Agile",
        "SCRUM",
        "Incremental",
        "Kanban",
        "DevOps"
    };

    /// <summary>
    /// The technologies and frameworks I work with every day.
    /// </summary>
    public string[] Stack {get; set; } = {
        ".NET",
        "Microsoft",
        "ASP.NET Core",
        "Entity Framework Core",
        "LINQ",
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
}
