using Confluent.Kafka;

var config = new ConsumerConfig
{
    GroupId = "demo-group",
    BootstrapServers = "localhost:8082",
    AutoOffsetReset = AutoOffsetReset.Earliest
};

using (var consumer = new ConsumerBuilder<Ignore, string>(config).Build())
{
    consumer.Subscribe("quickstart");
    while (true)
    {
        var dataFromKafka = consumer.Consume();

        Console.WriteLine(dataFromKafka.Message.Value);
    }
}