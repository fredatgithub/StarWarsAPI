using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppGetAPI.Models
{
  public class Films
  {
    public string title { get; set; }
    public int episode_id { get; set; }
    public string opening_crawl { get; set; }
    public string director { get; set; }
    public string producer { get; set; }
    public string release_date { get; set; }
    public List<string> characters { get; set; }
    public List<string> planets { get; set; }
    public List<string> starships { get; set; }
    public List<string> vehicles { get; set; }
    public List<string> species { get; set; }
    public DateTime created { get; set; }
    public DateTime edited { get; set; }
    public string url { get; set; }

    public string ToJsonString()
    {
      StringBuilder result = new StringBuilder();
      result.Append($"{Environment.NewLine}");
      result.Append($"\"title\":\"{title}\",");
      result.Append($"{Environment.NewLine}");
      result.Append($"\"episode_id\":\"{episode_id}\",");
      result.Append($"{Environment.NewLine}");
      result.Append($"\"opening_crawl\":\"{opening_crawl}\",");
      result.Append($"{Environment.NewLine}");
      result.Append($"\"director\":\"{director}\",");
      result.Append($"{Environment.NewLine}");
      result.Append($"\"producer\":\"{producer}\",");
      result.Append($"{Environment.NewLine}");
      result.Append($"\"release_date\":\"{release_date}\",");
      result.Append($"{Environment.NewLine}");

      int counter = 0;
      string comma = ",";
      if (characters.Count > 0)
      {
        counter = 0;
        comma = ",";
        result.Append($"\"characters\":[");
        result.Append($"{Environment.NewLine}");
        foreach (string item in characters)
        {
          counter++;
          if (counter == characters.Count)
          {
            comma = string.Empty;
          }

          result.Append($"\"{item}\"{comma}");
          result.Append($"{Environment.NewLine}");
        }

        result.Append($"],");
        result.Append($"{Environment.NewLine}");
      }
      else
      {
        result.Append($"\"characters\":[],");
        result.Append($"{Environment.NewLine}");
      }

      if (planets.Count > 0)
      {
        counter = 0;
        comma = ",";
        result.Append($"\"planets\":[");
        result.Append($"{Environment.NewLine}");
        foreach (string item in planets)
        {
          counter++;
          if (counter == planets.Count)
          {
            comma = string.Empty;
          }

          result.Append($"\"{item}\"{comma}");
          result.Append($"{Environment.NewLine}");
        }

        result.Append($"],");
        result.Append($"{Environment.NewLine}");
      }
      else
      {
        result.Append($"\"planets\":[],");
        result.Append($"{Environment.NewLine}");
      }

      if (starships.Count > 0)
      {
        counter = 0;
        comma = ",";
        result.Append($"\"starships\":[");
        result.Append($"{Environment.NewLine}");
        foreach (string item in starships)
        {
          counter++;
          if (counter == starships.Count)
          {
            comma = string.Empty;
          }

          result.Append($"\"{item}\"{comma}");
          result.Append($"{Environment.NewLine}");
        }

        result.Append($"],");
        result.Append($"{Environment.NewLine}");
      }
      else
      {
        result.Append($"\"starships\":[],");
        result.Append($"{Environment.NewLine}");
      }

      if (vehicles.Count > 0)
      {
        counter = 0;
        comma = ",";
        result.Append($"\"vehicles\":[");
        result.Append($"{Environment.NewLine}");
        foreach (string item in vehicles)
        {
          counter++;
          if (counter == vehicles.Count)
          {
            comma = string.Empty;
          }

          result.Append($"\"{item}\"{comma}");
          result.Append($"{Environment.NewLine}");
        }

        result.Append($"],");
        result.Append($"{Environment.NewLine}");
      }
      else
      {
        result.Append($"\"vehicles\":[],");
        result.Append($"{Environment.NewLine}");
      }

      if (species.Count > 0)
      {
        counter = 0;
        comma = ",";
        result.Append($"\"species\":[");
        result.Append($"{Environment.NewLine}");
        foreach (string item in species)
        {
          counter++;
          if (counter == species.Count)
          {
            comma = string.Empty;
          }

          result.Append($"\"{item}\"{comma}");
          result.Append($"{Environment.NewLine}");
        }

        result.Append($"],");
        result.Append($"{Environment.NewLine}");
      }
      else
      {
        result.Append($"\"species\":[],");
        result.Append($"{Environment.NewLine}");
      }

      result.Append($"created:{created},");
      result.Append($"{Environment.NewLine}");
      result.Append($"edited:{edited},");
      result.Append($"{Environment.NewLine}");
      result.Append($"url:{url}");
      result.Append($"{Environment.NewLine}");
      result.Append("}");
      result.Append($"{Environment.NewLine}");

      return result.ToString();
    }
  }
}
