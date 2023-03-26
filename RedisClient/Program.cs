using StackExchange.Redis;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static readonly ConnectionMultiplexer redis = ConnectionMultiplexer.Connect("localhost");

        static async Task Main(string[] args)
        {
            var db = redis.GetDatabase();
            var pong = await db.PingAsync();
            Console.WriteLine(pong);
        }
    }
}