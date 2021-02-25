using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ServiceStack.Redis;
using static System.Console;

namespace RedisDemo
{
    public class HashTest
    {

        public static void RunMain(IRedisClient client)
        {

            string hashId = "RedisTest";

            #region 新增
            //client.SetEntryInHash(hashId,"name","张三");
            //Console.WriteLine(client.GetValueFromHash(hashId, "name"));

            //client.SetEntryInHash(hashId,"id","001");
            //Console.WriteLine(client.GetValueFromHash(hashId, "id"));

            //client.SetEntryInHash(hashId,"age","18");
            //Console.WriteLine(client.GetValueFromHash(hashId, "age"));

            //client.SetEntryInHash(hashId,"address","上海");

            //Console.WriteLine(client.GetValueFromHash(hashId, "address"));
            #endregion

            #region 批量操作
            //Dictionary<string, string> dict = new Dictionary<string, string>();
            //dict.Add("Redis_Name", "张三");
            //dict.Add("Redis_ID", "001");
            //dict.Add("Redis_Age", "18");
            //dict.Add("Redis_Address", "上海");
            //client.SetRangeInHash(hashId, dict);


            //var values = client.GetAllEntriesFromHash(hashId);
            //foreach (var item in values)
            //{
            //    Console.WriteLine(item.Key + " - " + item.Value);
            //}
            #endregion

            #region 操作对象 

            //SetEntryInHashIfNotExists 存在则插入并返回True 否则则不插入 返回False
            //Console.WriteLine(client.SetEntryInHashIfNotExists(hashId, "name", "6666"));
            //Console.WriteLine(client.SetEntryInHashIfNotExists(hashId, "name", "redis666"));

            //client.StoreAsHash<UserInfo>(new UserInfo() { ID = "001", Name = "zs", Age = "18", Address = "sh" });

            ////UserInfo userInfo = client.GetFromHash<UserInfo>("001");
            //Console.WriteLine(client.GetFromHash<UserInfo>("001").Name);


            #endregion

            #region 其他操作

            //读取hash数量以及Key/Values
            //Dictionary<string, string> dict = new Dictionary<string, string>();
            //dict.Add("Redis_Name", "张三");
            //dict.Add("Redis_ID", "001");
            //dict.Add("Redis_Age", "18");
            //dict.Add("Redis_Address", "上海");
            //client.SetRangeInHash(hashId, dict);

            //Console.WriteLine(client.GetHashCount(hashId));
            //var hashKeys = client.GetHashKeys(hashId);

            //foreach (var item in hashKeys)
            //{
            //    Console.WriteLine(item);
            //}
            //var hashValues = client.GetHashValues(hashId);

            //foreach (var item in hashValues)
            //{
            //    Console.WriteLine(item);
            //}

            //删除hash内数据
            //client.RemoveEntryFromHash(hashId,"Redis_Name");
            //Console.WriteLine(client.GetHashCount(hashId));

            #region 判断hash数据中是否存在key的数据
            //Dictionary<string, string> dict = new Dictionary<string, string>();
            //dict.Add("Redis_Name", "张三");
            //dict.Add("Redis_ID", "001");
            //dict.Add("Redis_Age", "18");
            //dict.Add("Redis_Address", "上海");
            //client.SetRangeInHash(hashId, dict);

            
            ////bool isExist = client.HashContainsEntry(hashId, "Redis_Name");
            ////Console.WriteLine(isExist);

            ////自增
            //client.IncrementValueInHash(hashId,"Redis_Age",1);

            //Console.WriteLine(client.GetValueFromHash(hashId,"Redis_Age"));
            #endregion

            #endregion
        }
    }
}
