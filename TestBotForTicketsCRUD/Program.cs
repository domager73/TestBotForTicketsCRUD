using System.Text.Json;
using Confluent.Kafka;
using TestBotForTicketsCRUD;

var config = new ConsumerConfig
{
    GroupId = "demo-group",
    BootstrapServers = "localhost:9092",
    AutoOffsetReset = AutoOffsetReset.Earliest
};

var tgBot = new TgBot();

using (var consumer = new ConsumerBuilder<Ignore, string>(config).Build())
{
    consumer.Subscribe("quickstart");
    while (true)
    {
        var dataFromKafka = consumer.Consume();

        Console.WriteLine(dataFromKafka.Message.Value);
    }
}