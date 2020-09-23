using ConsoleAppGetAPI.Models;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Threading;

namespace ConsoleAppGetAPI
{
  class Program
  {
    static void Main()
    {
      Action<string> display = Console.WriteLine;
      display("Get JSON from Starwars API");
      string url1 = "https://swapi.dev/api/people/1/";

      string apiUrlBase = "https://swapi.dev/api";
      string apiUrl = "https://swapi.dev/api/people/";
      string className = "people";
      for (int i = 1; i <= 83; i++)
      {
        if (i == 17)
        {
          continue;
        }

        apiUrl = $"{apiUrlBase}/{className}/{i}/";
        var myJsonResponse = GetAPIFromUrl(apiUrl);
        People myDeserializedClass = JsonConvert.DeserializeObject<People>(myJsonResponse);
        bool insertResult = false;
        myJsonResponse = GetAPIFromUrl(apiUrl);
        myDeserializedClass = JsonConvert.DeserializeObject<People>(myJsonResponse);
        display($"{myDeserializedClass}");
        insertResult = WriteToFile(myDeserializedClass, className, i);
        Thread.Sleep(1500);
      }

      // planets
      className = "planets";
      for (int i = 1; i <= 60; i++)
      {
        apiUrl = $"{apiUrlBase}/{className}/{i}/";
        var myJsonResponse = GetAPIFromUrl(apiUrl);
        Planets myDeserializedClass = JsonConvert.DeserializeObject<Planets>(myJsonResponse);
        bool insertResult = false;
        myJsonResponse = GetAPIFromUrl(apiUrl);
        myDeserializedClass = JsonConvert.DeserializeObject<Planets>(myJsonResponse);
        display($"{myDeserializedClass}");
        insertResult = WriteToFile(myDeserializedClass, className, i);
        Thread.Sleep(1500);
      }

      // starships
      className = "starships";
      for (int i = 2; i <= 43; i++)// 2 to 43
      {
        if (i == 4 || i == 6 || i == 7 || i == 8 || i == 14 || i == 16 || i == 18 || i == 19 || i == 20 || i == 24 || i == 25 || i == 26 || i == 30 || i == 33 || i == 34 || i == 35 || i == 36 || i == 37 || i == 38 || i == 42)
        {
          continue;
        }

        apiUrl = $"{apiUrlBase}/{className}/{i}/";
        var myJsonResponse = GetAPIFromUrl(apiUrl);
        Starships myDeserializedClass = JsonConvert.DeserializeObject<Starships>(myJsonResponse);
        bool insertResult = false;
        myJsonResponse = GetAPIFromUrl(apiUrl);
        myDeserializedClass = JsonConvert.DeserializeObject<Starships>(myJsonResponse);
        display($"{myDeserializedClass}");
        insertResult = WriteToFile(myDeserializedClass, className, i);
        Thread.Sleep(1500);
      }

      // films
      className = "films";
      for (int i = 1; i <= 6; i++)// 1 to 6
      {
        apiUrl = $"{apiUrlBase}/{className}/{i}/";
        var myJsonResponse = GetAPIFromUrl(apiUrl);
        Films myDeserializedClass = JsonConvert.DeserializeObject<Films>(myJsonResponse);
        bool insertResult = false;
        myJsonResponse = GetAPIFromUrl(apiUrl);
        myDeserializedClass = JsonConvert.DeserializeObject<Films>(myJsonResponse);
        display($"{myDeserializedClass}");
        insertResult = WriteToFile(myDeserializedClass, className, i);
        Thread.Sleep(1500);
      }

      // species
      className = "species";
      for (int i = 1; i <= 37; i++)// 1 to 37
      {
        apiUrl = $"{apiUrlBase}/{className}/{i}/";
        var myJsonResponse = GetAPIFromUrl(apiUrl);
        Species myDeserializedClass = JsonConvert.DeserializeObject<Species>(myJsonResponse);
        bool insertResult = false;
        myJsonResponse = GetAPIFromUrl(apiUrl);
        myDeserializedClass = JsonConvert.DeserializeObject<Species>(myJsonResponse);
        display($"{myDeserializedClass}");
        insertResult = WriteToFile(myDeserializedClass, className, i);
        Thread.Sleep(1500);
      }



      display("Press any key to exit:");
      Console.ReadKey();
    }

    private static bool WriteToFile(object mydeserializedObject, string fileName, int number)
    {
      try
      {
        using (StreamWriter sw = new StreamWriter($"{fileName}{number}.txt"))
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
  }
}
