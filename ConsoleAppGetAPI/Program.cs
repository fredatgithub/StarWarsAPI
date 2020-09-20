using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace ConsoleAppGetAPI
{
  class Program
  {
    static void Main()
    {
      Action<string> display = Console.WriteLine;
      display("Get JSON from Starwars API");
      string url1 = "https://swapi.dev/api/people/1/";

      string apiUrlBase = "https://swapi.dev/api/people/";
      string apiUrl = "https://swapi.dev/api/people/";
      string className = "people";
      for (int i = 1; i < 10; i++)
      {
        apiUrl = $"{apiUrlBase}/{className}/{i}/";

      }
      var myJsonResponse = GetAPIFromUrl(apiUrl);
      People myDeserializedClass = JsonConvert.DeserializeObject<People>(myJsonResponse);
      bool insertResult = false;
      myJsonResponse = GetAPIFromUrl(apiUrl);
      myDeserializedClass = JsonConvert.DeserializeObject<People>(myJsonResponse);
      display($"{myDeserializedClass}");

      insertResult = WriteToFile(myDeserializedClass);

      display("Press any key to exit:");
      Console.ReadKey();
    }

    private static bool WriteToFile(object mydeserializedObject)
    {
      try
      {
        using (StreamWriter sw = new StreamWriter("luke1.txt"))
        {
          sw.Write(mydeserializedObject.ToString());
        }
      }
      catch (Exception)
      {
        return false;
      }

      return true;
    }

    public static string GetAPIFromUrl(string url)
    {
      ServicePointManager.Expect100Continue = true;
      ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
             | SecurityProtocolType.Tls11
             | SecurityProtocolType.Tls12
             | SecurityProtocolType.Ssl3;

      WebRequest request = (HttpWebRequest)WebRequest.Create(url);
      WebResponse response = request.GetResponse();
      Stream dataStream = response.GetResponseStream();
      StreamReader reader = new StreamReader(dataStream);
      string responseFromServer = reader.ReadToEnd();
      reader.Close();
      response.Close();
      return responseFromServer;
    }

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class People
    {
      public string name { get; set; }
      public string height { get; set; }
      public string mass { get; set; }
      public string hair_color { get; set; }
      public string skin_color { get; set; }
      public string eye_color { get; set; }
      public string birth_year { get; set; }
      public string gender { get; set; }
      public string homeworld { get; set; }
      public List<string> films { get; set; }
      public List<object> species { get; set; }
      public List<string> vehicles { get; set; }
      public List<string> starships { get; set; }
      public DateTime created { get; set; }
      public DateTime edited { get; set; }
      public string url { get; set; }
    }


  }
}
