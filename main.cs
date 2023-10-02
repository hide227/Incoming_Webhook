using System;
using System.Collections;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Incoming_webhook
{
  class Main
  {
    static void Main(string[] args)
    {
      var statusCode = SendMessage().Result;
      Console.WriteLine(statusCode);
    }

    static async Task<HttpStatusCode> SendMessage()
    {
      var incomingWebhook = "https://mywebhook";
      using (HttpClient client = new HttpClient())
      {
        var param = new Hashtable();
	param["Title"] = "Title";
	param["Text"]  = "Message"
	               + "<br>Body";
        var json = JsonConvert.SerializeObject(param);
	var content = new StringContent(json);
	HttpResponseMessage res = await client.PostAsync(incomingWebhook, content);

        return res.StatusCode;
      }
    }
  }
}