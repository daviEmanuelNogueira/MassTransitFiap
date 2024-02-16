Projeto de mensageria usando inicialmente MassTransit depois usando Azure Service Bus.

O repositório tem basicamente 3 projetos: produtor, core e cosumidor.

Produtor: Web API com .NET 7
  - Envia a request (exemplo) para uma fila no Azure Service Bus.
Core: Class library
  - Contém as classes usadas no API de pedido e usuário.
Consumidor: Worker Service
  - Monitora a fila e tem como objetivo ler a fila e apresentar por console as informações lidas.

NOTA: A fila pode estar indisponível pois se trada de uma conta de estudande e alguns serviços podem ser removidos.
