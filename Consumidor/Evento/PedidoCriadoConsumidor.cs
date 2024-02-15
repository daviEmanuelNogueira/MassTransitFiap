using Core;
using MassTransit;

namespace Consumidor.Evento;
public class PedidoCriadoConsumidor : IConsumer<Pedido>
{
    public Task Consume(ConsumeContext<Pedido> context)
    {
        Console.WriteLine(context.Message);
        return Task.CompletedTask;
    }
}
