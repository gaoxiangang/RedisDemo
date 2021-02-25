using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ServiceStack.Redis;
using static System.Console;
using Newtonsoft.Json;

namespace RedisDemo
{
    public class SetTest
    {

        static string setId = "Redis_Test";
        public static void RunMain(IRedisClient client)
        {

            #region Set操作
            //set 存储格式类似于list 不同之处，set可以自动去重复
            //var libai = new UserInfo() { ID = "001", Name = "李白", Address = "上海" };
            //client.AddItemToSet(setId, JsonConvert.SerializeObject(libai));
            //client.AddItemToSet(setId, JsonConvert.SerializeObject(libai));
            //client.AddItemToSet(setId, JsonConvert.SerializeObject(libai));

            //Console.WriteLine(client.GetSetCount(setId));
            #endregion

            #region set批量操作

            //List<string> list = new List<string>();

            //list.Add(JsonConvert.SerializeObject(new UserInfo() { ID = "001", Name = "李白", Address = "上海" }));
            //list.Add(JsonConvert.SerializeObject(new UserInfo() { ID = "002", Name = "杜甫", Address = "上海" }));
            //list.Add(JsonConvert.SerializeObject(new UserInfo() { ID = "003", Name = "白居易", Address = "上海" }));

            ////批量插入数据
            //client.AddRangeToSet(setId, list);

            //var sets = client.GetAllItemsFromSet(setId);

            //foreach (var item in sets)
            //{
            //    Console.WriteLine(item);
            //}

            //随机获取集合中的一个值

            //Console.WriteLine(client.GetRandomItemFromSet(setId));

            //随机删除集合中的元素,并返回删除的数据
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(client.PopItemFromSet(setId));
            //}

            #endregion

            #region 交叉并补
            //List<string> list = new List<string>();

            //list.Add(JsonConvert.SerializeObject(new UserInfo() { ID = "001", Name = "李白", Address = "上海" }));
            //list.Add(JsonConvert.SerializeObject(new UserInfo() { ID = "002", Name = "杜甫", Address = "上海" }));
            //list.Add(JsonConvert.SerializeObject(new UserInfo() { ID = "003", Name = "白居易", Address = "上海" }));

            ////批量插入数据
            //client.AddRangeToSet(setId, list);

            ////根据值去删除数据
            //client.RemoveItemFromSet(setId, JsonConvert.SerializeObject(new UserInfo() { ID = "001", Name = "李白", Address = "上海" }));

            //var sets = client.GetAllItemsFromSet(setId);

            //foreach (var item in sets)
            //{
            //    Console.WriteLine(item);
            //}

            //从原来的集合移除值到一个新的集合中去
            //client.MoveBetweenSets(setId,"Redis_Test_New", JsonConvert.SerializeObject(new UserInfo() { ID = "001", Name = "李白", Address = "上海" }));

            //交叉并补，类似qq号的相同好友  就是交集
            //client.AddRangeToSet(setId, new List<string>() { "001", "002", "003", "004" });
            ////client.AddRangeToSet("Redis_New_Test", new List<string>() { "005", "002", "003", "006" });
            //client.AddRangeToSet("Redis_New_Test", new List<string>() { "005", "006", "007", "008" });


            //var result = client.GetIntersectFromSets(setId, "Redis_New_Test");
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            //取并集
            //var result = client.GetUnionFromSets(setId, "Redis_New_Test");
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            ////取setId中在Redis_New_Test没有的数据
            //var result = client.GetDifferencesFromSet(setId, "Redis_New_Test");

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region ZSET 自动去重而且多了一个权重或者分数的字段，这个字段自动排序的依据

            //如果不写 默认为最大
            //client.AddItemToSortedSet(setId, "李白1", 1);
            //client.AddItemToSortedSet(setId, "李白2", 2);
            //client.AddItemToSortedSet(setId, "李白3", 3);

            //批量插入每一个排序分数都是一样的 
            //client.AddRangeToSortedSet(setId,new List<string>() { "001", "002" , "003" },1);

            ////顺序获取
            //var zsets= client.GetAllItemsFromSortedSet(setId);
            //foreach (var item in zsets)
            //{
            //    Console.WriteLine(item);
            //}

            ////倒叙获取
            //var zsetsDesc = client.GetAllItemsFromSortedSetDesc(setId);
            //foreach (var item in zsetsDesc)
            //{
            //    Console.WriteLine(item);
            //}

            ////根据下标顺序获取 不返回分数
            //var list = client.GetRangeFromSortedSet(setId, 0, 1);
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);

            //}

            ////根据下标倒叙获取 不返回分数
            //var list = client.GetRangeFromSortedSetDesc(setId, 0, 1);
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);

            //}

            //根据下标获取 带分数
            //var list = client.GetRangeWithScoresFromSortedSet(setId, 0, 1);

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}


            ////多个交叉并补
            //client.AddItemToSortedSet(setId, "李白", 1);
            //client.AddItemToSortedSet(setId, "杜甫", 2);
            //client.AddItemToSortedSet(setId, "白居易", 3);

            //client.AddItemToSortedSet("Redis_Test2", "李白", 1);
            //client.AddItemToSortedSet("Redis_Test2", "曹操", 2);
            //client.AddItemToSortedSet("Redis_Test2", "刘备", 3);

            //client.AddItemToSortedSet("Redis_Test3", "杜甫", 1);
            //client.AddItemToSortedSet("Redis_Test3", "曹操", 2);
            //client.AddItemToSortedSet("Redis_Test3", "白居易", 3);

            ////将交集的集合部分存放到一个新的集合中，并返回交集的个数
            //Console.WriteLine(client.StoreIntersectFromSortedSets("Redis_Test_1", setId, "Redis_Test2"));


            #endregion

        }
    }
}
