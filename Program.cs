using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;

namespace TestWork
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            Solution solution = new Solution();
            string url = "https://goweather.herokuapp.com/weather/Kyiv";
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            string response;

            using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
                response = streamReader.ReadToEnd();

            Console.WriteLine(response);
        } 
    }
}
