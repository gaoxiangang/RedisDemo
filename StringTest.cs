using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ServiceStack.Redis;
using static System.Console;

namespace RedisDemo
{
    public class StringTest
    {

        public static void RunMain(IRedisClient client)
        {

            #region 添加string Key
            ////添加string Key
            //client.Set<string>("Redis_Name","redis");
            ////读取string Key
            //Console.WriteLine(client.Get<string>("Redis_Name"));
            #endregion

            #region 批量操作
            //批量添加Key值
            //Dictionary<string, string> dict = new Dictionary<string, string>();
            //dict.Add("Redis_Name", "gxg");
            //dict.Add("Redis_Age", "18");
            //dict.Add("Redis_Address", "上海");
            //dict.Add("Redis_Email", "120927128zh@gmail.com");
            //client.SetAll(dict);

            ////批量读取数据

            //var list = client.GetAll<string>(new string[] { "Redis_Name", "Redis_Age", "Redis_Address", "Redis_Email" });
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item.Key + " : " + item.Value);
            //}

            #endregion

            #region 设置过期时间

            ////添加string Key
            //client.Set<string>("Redis_Name", "timeOut",TimeSpan.FromSeconds(10));
            //client.Set<string>("Redis_Name", "timeOut", DateTime.Now.AddDays(1)) ;

            //Task.Delay(11*1000).Wait();
            ////读取string Key
            //Console.WriteLine(client.Get<string>("Redis_Name"));
            #endregion

            #region  追加值和获取旧值设置新值

            //client.AppendToValue("Redis_Name", "timeOut");
            //client.AppendToValue("Redis_Name","666");

            //client.Set<string>("Redis_Name", "timeOut");

            //string oldVlaue = client.GetAndSetValue("Redis_Name", "6666");

            //Console.WriteLine("旧值:" + oldVlaue);
            //Console.WriteLine("新值：" + client.Get<string>("Redis_Name"));
            #endregion

            #region 自增和自减

            //client.IncrementValue("Redis_Count");
            //client.Increment("Redis_Count",100);



            //client.Decrement("Redis_Count",99);
            //client.DecrementValue("Redis_Count");
            //Console.WriteLine(client.Get<int>("Redis_Count")); 

            #endregion

            #region add和set

            ////Add  不存在则插入 存在则不插入
            //Console.WriteLine(client.Add<string>("Redis_Name", "Value"));
            //Console.WriteLine(client.Add<string>("Redis_Name", "Redis"));

            ////Set  不存在则插入 存在则替换
            //Console.WriteLine(client.Set("Redis_Age", 18));
            //Console.WriteLine(client.Set("Redis_Age", 19));
            //Console.WriteLine(client.Set("Redis_Age", 20));
            #endregion


        }
    }
}
