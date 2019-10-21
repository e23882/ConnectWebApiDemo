using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConnectWebApiDemo.CommonFunction;
using System.Net.Http;


namespace ConnectWebApiDemo
{
    class Program
    {
        #region Memberfunction
        static void Main(string[] args)
        {
            //Common Search
            //string url = "http://localhost:63207/Api/Test/Get";
            //JObject jo = JObject.Parse(APIConnector.Get(url));
            //Console.WriteLine(jo.GetValue("status"));
            //Console.WriteLine(jo.GetValue("message"));
            //foreach (JObject item in jo.Property("data").Value as JArray)
            //{
            //    Console.WriteLine(item["stockId"]);
            //    Console.WriteLine(item["stockName"]);
            //    Console.WriteLine(item["exchange"]);
            //    Console.WriteLine(item["issued"]);
            //}

            //Condition Search
            //string url = string.Format("http://localhost:63207/Api/Test/Get?stockId={0}", 1101);
            //JObject jo = JObject.Parse(APIConnector.Get(url));
            //Console.WriteLine(jo.GetValue("status"));
            //Console.WriteLine(jo.GetValue("message"));
            //foreach (JObject item in jo.Property("data").Value as JArray)
            //{
            //    Console.WriteLine(item["stockId"]);
            //    Console.WriteLine(item["stockName"]);
            //    Console.WriteLine(item["exchange"]);
            //    Console.WriteLine(item["issued"]);
            //}
            //Post
            PostAction();
            //Put
            //PutAction();
            //string url = "http://localhost:63207/Api/Test/Delete";
            //JObject jo = JObject.Parse(APIConnector.Get(url));
            //Console.WriteLine(jo.GetValue("status"));
            //Console.WriteLine(jo.GetValue("message"));
            //foreach (JObject item in jo.Property("data").Value as JArray)
            //{
            //    Console.WriteLine(item["stockId"]);
            //    Console.WriteLine(item["stockName"]);
            //    Console.WriteLine(item["exchange"]);
            //    Console.WriteLine(item["issued"]);
            //}

            Console.Read();
        }
        public static void PostAction()
        {
            using (var client = new HttpClient())
            {
                StockData p = new StockData { StockID = "2330" };
                client.BaseAddress = new Uri("http://localhost:63207/Api/Test/Post");
                var response = client.PostAsJsonAsync("", p).Result;

                if (response.IsSuccessStatusCode)
                {
                    Console.Write("Success");
                }
                else
                    Console.Write("Error");
            }
        }

        public static void PutAction()
        {
            using (var client = new HttpClient())
            {
                StockData p = new StockData { StockID = "2330" };
                client.BaseAddress = new Uri("http://localhost:63207/Api/Test/Put");
                var response = client.PutAsJsonAsync("", p).Result;

                if (response.IsSuccessStatusCode)
                {
                    Console.Write("Success");
                }
                else
                    Console.Write("Error");
            }
        }

        public static void DeleteAction()
        {
        }

        public class StockData
        {
            public string StockID { get; set; }
            public string Currency { get; set; }
            public double OpenPrice { get; set; }
            public double ClosePrice { get; set; }
        }
        #endregion
    }
}
