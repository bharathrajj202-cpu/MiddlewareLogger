# MiddlewareDemo – ASP.NET Core Web API

## Project Description

This project demonstrates the ASP.NET Core Web API architecture using a custom logging middleware component.

## Features

- ASP.NET Core Web API
- Custom Request Logging Middleware
- HTTP GET endpoint
- Static JSON response
- Middleware pipeline configuration

## API Endpoint

**Method:** GET

**URL:** `http://localhost:5079/api/message`

### Sample Response

```json
{
  "message": "Message recieved",
  "status": "Success"
}
```

## Custom Middleware

The `RequestLoggingMiddleware.cs` component logs the HTTP request method and request path to the console.

Example:

```text
HTTP Method: GET, Request Path: /api/message
```

## Middleware Registration

The custom middleware is registered in `Program.cs` before routing:

```csharp
app.UseMiddleware<RequestLoggingMiddleware>();

app.UseRouting();

app.UseAuthorization();

app.MapControllers();
```

## Why Middleware Order Is Important

ASP.NET Core processes HTTP requests through an ordered middleware pipeline.

Our custom logging middleware is registered before routing so that it can inspect and log incoming requests before the routing component processes them.

The `await _next(context)` statement passes the request to the next middleware component.

This demonstrates the modular and extensible architecture of ASP.NET Core.

## How to Run

```powershell
dotnet restore
dotnet build
dotnet run --urls http://localhost:5079
```

Test the endpoint:

```text
http://localhost:5079/api/message
```