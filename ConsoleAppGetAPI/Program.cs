using ConsoleAppGetAPI.Models;
using Newtonsoft.Json;
using System;
using System.Data.SqlClient;
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
        insertResult = WriteToFile(myDeserializedClass.ToJsonString(), className, i);
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
        insertResult = WriteToFile(myDeserializedClass.ToJsonString(), className, i);
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
        insertResult = WriteToFile(myDeserializedClass.ToJsonString(), className, i);
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
        insertResult = WriteToFile(myDeserializedClass.ToJsonString(), className, i);
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
        insertResult = WriteToFile(myDeserializedClass.ToJsonString(), className, i);
        Thread.Sleep(1500);
      }

      display("Press any key to exit:");
      Console.ReadKey();
    }

    private static bool WriteToFile(string deserializedObject, string fileName, int number)
    {
      try
      {
        using (StreamWriter sw = new StreamWriter($"{fileName}{number}.txt"))
        {
          sw.Write(deserializedObject);
        }
      }
      catch (Exception)
      {
        return false;
      }

      return true;
    }

    private static bool SaveToDatabase(string deserializedObject, string className)
    {
      string connexionString = GetConnexionString();
      bool result = false;
      string table = $"[{className}]";
      string queryStart = "INSERT INTO [dbo].";
      string queryTableName = string.Empty;
      string queryEnd = "([Date], [RateEuros], [RateDollar]) VALUES(@theDate, @rateEuro, @ratedollar)";
      switch (className.ToString())
      {
        case "films":
          queryEnd = "([title], [episode_id], [opening_crawl], [director], [producer], [release_date], [characters], [planets], [starships], [vehicles], [species], [created], [edited], [url]) VALUES (@thetitle, @theepisode_id, @theopening_crawl, @thedirector , @theproducer , @therelease_date , @thecharacters , @theplanets , @thestarships , @thevehicles , @thespecies , @thecreated , @theedited , @theurl )";
          break;
        case "people":
          queryEnd = "([name], [height], [mass], [hair_color], [skin_color], [eye_color], [birth_year], [gender], [homeworld], [films], [species], [vehicles], [starships], [created], [edited], [url]) VALUES thename, @theheight, @themass, @thehair_color, @theskin_color, @theeye_color, @thebirth_year, @thegender, @thehomeworld, @thefilms, @thespecies, @thevehicles, @thestarships, @thecreated, @theedited, @theurl)";
          break;
        case "planets":
          queryEnd = "([name], [rotation_period], [orbital_period], [diameter], [climate], [gravity], [terrain], [surface_water], [population], [residents], [films], [created], [edited], [url]) VALUES (@thename, @therotation_period, @theorbital_period, @thediameter, @theclimate, @thegravity, @theterrain, @thesurface_water, @thepopulation, @theresidents, @thefilms, @thecreated, @theedited, @theurl)";
          break;
        case "species":
          queryEnd = "([name], [classification], [designation], [average_height], [skin_colors], [hair_colors], [eye_colors], [average_lifespan], [homeworld], [language], [people], [films], [created], [edited], [url]) VALUES (@thename, @theclassification, @thedesignation, @theaverage_height, @theskin_colors, @thehair_colors, @theeye_colors, @theaverage_lifespan, @thehomeworld, @thelanguage, @thepeople, @thefilms, @thecreated, @theedited, @theurl)";
          break;
        case "starships":
          queryEnd = "([name], [model], [manufacturer], [cost_in_credits], [length], [max_atmosphering_speed], [crew], [passengers], [cargo_capacity], [consumables], [hyperdrive_rating], [MGLT], [starship_class], [pilots], [films], [created], [edited], [url]) VALUES(@thename, @themodel, @themanufacturer, @thecost_in_credits, @thelength, @themax_atmosphering_speed, @thecrew, @thepassengers, @thecargo_capacity, @theconsumables, @thehyperdrive_rating, @theMGLT, @thestarship_class, @thepilots, @thefilms, @thecreated, @theedited, @theurl)";
          break;

      }

      using (SqlConnection connection = new SqlConnection(connexionString))
      {
        string query = $"{queryStart}{table} {queryEnd}";

        using (SqlCommand command = new SqlCommand(query, connection))
        {
          switch (className.ToString())
          {

            case "films":
              command.Parameters.AddWithValue("@thetitle", thetitle);
              command.Parameters.AddWithValue("@theepisode_id", theepisode_id);
              command.Parameters.AddWithValue("@theopening_crawl", theopening_crawl);
              command.Parameters.AddWithValue("@thedirector", thedirector);
              command.Parameters.AddWithValue("@theproducer", theproducer);
              command.Parameters.AddWithValue("@therelease_date", therelease_date);
              command.Parameters.AddWithValue("@thecharacters", thecharacters);
              command.Parameters.AddWithValue("@theplanets", theplanets);
              command.Parameters.AddWithValue("@thestarships", thestarships);
              command.Parameters.AddWithValue("@thevehicles", thevehicles);
              command.Parameters.AddWithValue("@thespecies", thespecies);
              command.Parameters.AddWithValue("@thecreated", thecreated);
              command.Parameters.AddWithValue("@theedited", theedited);
              command.Parameters.AddWithValue("@theurl", theurl);

              break;
            default:
              break;
          }


          connection.Open();
          var QueryResult = command.ExecuteNonQuery();

          // Check Error
          if (QueryResult < 0)
          {
            //var errorMessage = "Error inserting data into Database!";
            result = false;
          }
          else
          {
            result = true;
          }
        }

        return true;
      }
    }

    public static string GetLatestDate()
    {
      string result = string.Empty;
      string connectionString = GetConnexionString();
      string query = "SELECT TOP(1) Date FROM BitCoin order by date DESC";

      using (SqlConnection connection = new SqlConnection(connectionString))
      {
        SqlCommand command = new SqlCommand(query, connection);
        try
        {
          connection.Open();
          var queryResult = command.ExecuteScalar();
          if (queryResult == null)
          {
            result = string.Empty;
          }
          else
          {
            result = queryResult.ToString();
          }
        }
        catch (Exception exception)
        {
          Console.WriteLine($"exception : {exception.Message}");
        }
        finally
        {
          connection.Close();
        }
      }

      if (result == null)
      {
        result = string.Empty;
      }

      return result;
    }

    private static string GetConnexionString()
    {
      return "Data Source=DESKTOP-MSI;Initial Catalog=StarWars2;Integrated Security=True";
    }

    public static bool WriteToDatabase(DateTime requestDate, double euro, double dollar)
    {
      bool result = false;
      using (SqlConnection connection = new SqlConnection(GetConnexionString()))
      {
        string query = "INSERT INTO [dbo].[BitCoin] ([Date], [RateEuros], [RateDollar]) VALUES(@theDate, @rateEuro, @ratedollar)";

        using (SqlCommand command = new SqlCommand(query, connection))
        {
          command.Parameters.AddWithValue("@theDate", requestDate);
          command.Parameters.AddWithValue("@rateEuro", euro);
          command.Parameters.AddWithValue("@ratedollar", dollar);

          connection.Open();
          var QueryResult = command.ExecuteNonQuery();

          // Check Error
          if (QueryResult < 0)
          {
            //var errorMessage = "Error inserting data into Database!";
            result = false;
          }
          else
          {
            result = true;
          }
        }
      }

      return result;
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
  }
}
