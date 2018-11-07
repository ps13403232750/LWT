using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;

namespace LWT.Common
{
    public class Client
    {
        public  static string GetApi(string verb,string uri,Object obj=null)
        {           
            string json = string.Empty;
            Task<HttpResponseMessage> task = null;
            HttpResponseMessage respose = null;
            using(HttpClient client=new HttpClient()){
                client.BaseAddress = new Uri("http://localhost:65029/api/");
                switch (verb.ToLower())
                {
                    case "get": task = client.GetAsync(uri);
                        break;
                    case "post": task = client.PostAsJsonAsync(uri, obj);
                        break;
                    case "put": task = client.PutAsJsonAsync(uri, obj);
                        break;
                    case "delete": task = client.DeleteAsync(uri);
                        break;
                }
            task.Wait();
                respose = task.Result;
                if (respose.IsSuccessStatusCode)
                {
                    var res = respose.Content.ReadAsStringAsync();
                    json = res.Result;
                }
            }
            return json;
        }
    }
}
