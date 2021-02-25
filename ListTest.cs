using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ServiceStack.Redis;
using static System.Console;
using Newtonsoft.Json;

namespace RedisDemo
{
    public class ListTest
    {
        static string listId = "RedisListTest";
        public static void RunMain(IRedisClient client)
        {
            #region List

            //var userOne = new UserInfo() { ID = "001", Name = "曹操", Address = "三国" };
            //var userTwo = new UserInfo() { ID = "002", Name = "李白", Address = "唐" };
            //var userThree = new UserInfo() { ID = "003", Name = "刘备", Address = "三国" };

            //client.AddItemToList(listId, JsonConvert.SerializeObject(userOne));
            //client.AddItemToList(listId, JsonConvert.SerializeObject(userTwo));
            //client.AddItemToList(listId, JsonConvert.SerializeObject(userThree));


            ////左侧添加 类似于向集合追加数据
            //var useFour = new UserInfo() { ID = "004", Name = "贾诩", Address = "三国" };
            //client.PushItemToList(listId, JsonConvert.SerializeObject(useFour));

            ////右侧添加 把数据追加到集合头部
            //var useFive = new UserInfo() { ID = "005", Name = "诸葛亮", Address = "三国" };
            //client.PrependItemToList(listId, JsonConvert.SerializeObject(useFive));


            ////设置过期时间
            //client.ExpireEntryAt(listId,DateTime.Now.AddSeconds(2));
            //Console.WriteLine(client.GetListCount(listId));

            //Task.Delay(5*1000).Wait();
            //Console.WriteLine(client.GetListCount(listId));
            #endregion

            #region 批量操作

            //client.AddRangeToList(listId,new List<string>() {"001","002","003" });

            //var values = client.GetRangeFromList(listId,0,1);

            //foreach (var item in values)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion


            #region List 队列操作

            string userOne = JsonConvert.SerializeObject( new UserInfo() { ID = "001", Name = "曹操", Address = "三国" });
            string userTwo = JsonConvert.SerializeObject(new UserInfo() { ID = "002", Name = "李白", Address = "唐" });
            string userThree = JsonConvert.SerializeObject(new UserInfo() { ID = "003", Name = "刘备", Address = "三国" });

            client.AddRangeToList(listId,new List<string>() { userOne,userTwo,userThree});
            //将最后一个值读取出来并从List中删除掉
            //Console.WriteLine(client.RemoveEndFromList(listId));

            //移除头部第一个数据并返回结果
            //Console.WriteLine(client.RemoveStartFromList(listId));


            ////扩展  从一个集合尾部移除一个元素并添加到一个集合的头部，并返回移动的值
            //Console.WriteLine(client.PopAndPushItemBetweenLists(listId,"NewRedisListTest"));
            //Console.WriteLine(client.PopAndPushItemBetweenLists(listId,"NewRedisListTest"));

            ////获取当前Key获取过期时间
            //client.ExpireEntryAt(listId,DateTime.Now.AddDays(1));
            //Console.WriteLine(client.GetTimeToLive(listId)) ;

            //根据下标修改值
            //client.SetItemInList(listId,0,"测试");
            //Console.WriteLine(client.GetItemFromList(listId,0));
 

            #endregion
        }
    }
}
