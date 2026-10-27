# Blue Hammerhead API

Backend API for the Blue Hammerhead project.

## Project Structure

- `Blue.Hammerhead.Api` - ASP.NET Core Web API project
- `Blue.Hammerhead.Domain` - Business and domain logic project
- `Blue.Hammerhead.slnx` - Solution file

The API project references the Domain project so the API can use the business objects and logic.

## Build

From the repository root:

```powershell
dotnet restore
dotnet build
```