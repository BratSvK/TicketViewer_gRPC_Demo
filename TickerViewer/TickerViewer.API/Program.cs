using TickerViewer.API.Config;
using TickerViewer.API.Interfaces;
using TickerViewer.Shared.Enum;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAppOptions(builder.Configuration);
builder.Services.AddApplicationServices();
builder.Services.AddTicketApiClient();
builder.Services.AddGrpcClient(builder.Configuration);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("api/actualTicketOffer", ([FromKeyedServices(KeyedServiceType.REST)] ITicketService ticketService)
    => ticketService.GetActualOfferTicketsAsync());

app.MapGet("grpc/actualTicketOffer", ([FromKeyedServices(KeyedServiceType.gRPC)] ITicketService ticketService)
    => ticketService.GetActualOfferTicketsAsync());

app.Run();
