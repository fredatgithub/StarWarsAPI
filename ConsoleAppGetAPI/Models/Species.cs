using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppGetAPI.Models
{
  public class Species
  {
    public string name { get; set; }
    public string classification { get; set; }
    public string designation { get; set; }
    public string average_height { get; set; }
    public string skin_colors { get; set; }
    public string hair_colors { get; set; }
    public string eye_colors { get; set; }
    public string average_lifespan { get; set; }
    public string homeworld { get; set; }
    public string language { get; set; }
    public List<string> people { get; set; }
    public List<string> films { get; set; }
    public DateTime created { get; set; }
    public DateTime edited { get; set; }
    public string url { get; set; }

    public string ToJsonString()
    {
      StringBuilder result = new StringBuilder();
      result.Append($"{Environment.NewLine}");
      result.Append($"\"name\":\"{name}\",");
      result.Append($"{Environment.NewLine}");
      result.Append($"\"classification\":\"{classification}\",");
      result.Append($"{Environment.NewLine}");
      result.Append($"\"designation\":\"{designation}\",");
      result.Append($"{Environment.NewLine}");
      result.Append($"\"skin_colors\":\"{skin_colors}\",");
      result.Append($"{Environment.NewLine}");
      result.Append($"\"hair_colors\":\"{hair_colors}\",");
      result.Append($"{Environment.NewLine}");
      result.Append($"\"eye_colors\":\"{eye_colors}\",");
      result.Append($"{Environment.NewLine}");
      result.Append($"\"average_lifespan\":\"{average_lifespan}\",");
      result.Append($"{Environment.NewLine}");
      result.Append($"\"homeworld\":\"{homeworld}\",");
      result.Append($"{Environment.NewLine}");
      result.Append($"\"language\":\"{language}\",");
      result.Append($"{Environment.NewLine}");

      if (people.Count > 0)
      {
        result.Append($"\"people\":[");
        foreach (string item in people)
        {
          result.Append($"\"{item}\",");
          result.Append($"{Environment.NewLine}");
        }

        result.Append($"],");
        result.Append($"{Environment.NewLine}");
      }
      else
      {
        result.Append($"\"people\":[],");
        result.Append($"{Environment.NewLine}");
      }

      if (films.Count > 0)
      {
        result.Append($"\"films\":[");
        foreach (string item in films)
        {
          result.Append($"\"{item}\",");
          result.Append($"{Environment.NewLine}");
        }

        result.Append($"],");
        result.Append($"{Environment.NewLine}");
      }
      else
      {
        result.Append($"\"films\":[],");
        result.Append($"{Environment.NewLine}");
      }

      result.Append($"created:{created},");
      result.Append($"{Environment.NewLine}");
      result.Append($"edited:{edited},");
      result.Append($"{Environment.NewLine}");
      result.Append($"url:{url},");
      result.Append($"{Environment.NewLine}");
      result.Append("}");
      result.Append($"{Environment.NewLine}");

      return result.ToString();
    }
  }
}
