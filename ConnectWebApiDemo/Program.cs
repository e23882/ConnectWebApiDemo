using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConnectWebApiDemo.CommonFunction;

namespace ConnectWebApiDemo
{
    class Program
    {
        #region Memberfunction
        static void Main(string[] args)
        {
            string url = "http://localhost:63207/Api/Test/Get";
            JObject jo = JObject.Parse(APIConnector.Get(string.Format(url, 1000, 0)));
            Console.WriteLine(jo.GetValue("status"));
            Console.WriteLine(jo.GetValue("message"));
            foreach (JObject item in jo.Property("data").Value as JArray)
            {
                Console.WriteLine(item["stockId"]);
                Console.WriteLine(item["stockName"]);
                Console.WriteLine(item["exchange"]);
                Console.WriteLine(item["issued"]);
            }
        }
        #endregion
    }
}
