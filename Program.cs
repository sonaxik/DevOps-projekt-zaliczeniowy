using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Endpoint g³ówny (/)
app.MapGet("/", () => "Witaj w TicketManagement API! PrzejdŸ do /products aby zobaczyæ bilety.");

// Endpoint produktów (/products) 
var tickets = new List<Ticket>
{
    new Ticket(1, "Koncert Metallica", "2025-06-15", 350.00m),
    new Ticket(2, "Mecz Polska - Niemcy", "2025-09-10", 120.50m),
    new Ticket(3, "Teatr: Hamlet", "2025-11-05", 80.00m),
    new Ticket(4, "Kino: Diuna 3", "2025-07-20", 35.00m)
};

app.MapGet("/products", () => tickets)
   .WithName("GetTickets")
   .WithOpenApi();

app.Run();
record Ticket(int Id, string Name, string Date, decimal Price);