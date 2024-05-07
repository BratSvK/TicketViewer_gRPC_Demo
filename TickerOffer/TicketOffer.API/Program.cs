using TickerViewer.API.Config;
using TicketOffer.API.Interfaces;
using TicketOffer.API.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApplicationServices();
builder.Services.AddGrpc();

var app = builder.Build();

#region Endpoints

app.MapGet("api/getTickets", (ITicketRepository ticketRepo) => ticketRepo.GetTickets());

#endregion

app.MapGrpcService<TicketGrpcService>();

app.Run();
