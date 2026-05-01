# AGENTS.md

## Commands

```sh
dotnet tool restore   # first-time setup
dotnet restore
dotnet r start        # run server (http://localhost:5034)
dotnet r watch        # run with auto-restart on file changes
```

`dotnet r` comes from the `run-script` tool in `.config/dotnet-tools.json`; scripts are defined in `global.json`.

## Architecture

- **Single project**: `src/Server.csproj`, .NET 7, HotChocolate 13.3.3
- **GraphQL schema**: defined inline in `src/Query.cs` — public properties become GraphQL fields automatically (no `.graphql` files, no codegen)
- **Entrypoint**: `src/Program.cs` — minimal API, maps `/graphql`, serves `wwwroot/`, GraphiQL at root via `index.html`
- **No tests**, no linters, no formatters beyond `.editorconfig` (C#: 4-space indent, final newline)

## CI

- `.github/workflows/docker-image.yml` — builds and pushes `doeringp/graphql-portfolio:latest` to Docker Hub on push to `main`

## Notable

- Banana Cake Pop tool is **disabled** (`Tool.Enable = false`); use GraphiQL (served at `/`) instead
- Hot reload is **disabled** (`--no-hot-reload` flag in `watch` script); file watcher still restarts the process
- No env vars, no .env files, no test prerequisites