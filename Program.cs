using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ServiceStack.Redis;
using static System.Console;
namespace RedisDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //引入redis Nuget包 连接redis服务器
            IRedisClient client = new RedisClient("47.116.75.154", 6379);
            //程序开始之前清除所有Key值
            client.FlushDb();

            //string Test
            //StringTest.RunMain(client);

            //HashTest
            //HashTest.RunMain(client);

            //ListTest
            //ListTest.RunMain(client);

            //SetTest
            SetTest.RunMain(client);

            Console.WriteLine("OK");
            ReadKey();

        }
    }
}
