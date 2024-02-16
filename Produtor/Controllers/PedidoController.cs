﻿using Core;
using MassTransit;
using Microsoft.AspNetCore.Mvc;

namespace Produtor.Controllers;

[Route("/[controller]")]
[ApiController]
public class PedidoController : ControllerBase
{
    private readonly IBus _bus;
    private readonly IConfiguration _configuration;
    public PedidoController(IBus bus, IConfiguration configuration)
    {
        _bus = bus;
        _configuration = configuration;
    }

    [HttpPost]
    public async Task<IActionResult> Post()
    {
        //var nomeFila = _configuration.GetSection("MassTransitAzure")["NomeFila"] ?? string.Empty;

        //var endpoint = await _bus
        //.GetSendEndpoint(new Uri($"queue:{nomeFila}"));

        //await endpoint.Send(new Pedido(1,
        //    new Usuario(5, "Davi", "davi.nogueira@skytel.com")));
        await _bus.Publish(new Pedido(1,
            new Usuario(5, "Davi", "davi.nogueira@skytel.com")));
        return Ok();
    }
}
