using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace LWT.Common
{
   public class Client
    {
        public static string GetApi(string verb, string url, Object obj = null)
        {
            string json = string.Empty;
            Task<HttpResponseMessage> task = null;
            HttpResponseMessage response = null;
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:60259/api/");
                switch (verb.ToLower())
                {
                    case "get":
                        task = client.GetAsync(url);
                        break;
                    case "post":
                        task = client.PostAsJsonAsync(url,obj);
                        break;
                    case "delete":
                        task = client.DeleteAsync(url);
                        break;
                    case "put":
                        task = client.PutAsJsonAsync(url,obj);
                        break;
                }
                task.Wait();
                response = task.Result;
                if (response.IsSuccessStatusCode)
                {
                    var res = response.Content.ReadAsStringAsync();
                    json = res.Result;
                }
            }
            return json;
        }
    }
}
