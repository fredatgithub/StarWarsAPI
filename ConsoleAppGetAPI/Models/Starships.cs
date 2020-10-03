using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppGetAPI.Models
{
  public class Starships
  {
    public string name { get; set; }
    public string model { get; set; }
    public string manufacturer { get; set; }
    public string cost_in_credits { get; set; }
    public string length { get; set; }
    public string max_atmosphering_speed { get; set; }
    public string crew { get; set; }
    public string passengers { get; set; }
    public string cargo_capacity { get; set; }
    public string consumables { get; set; }
    public string hyperdrive_rating { get; set; }
    public string MGLT { get; set; }
    public string starship_class { get; set; }
    public List<object> pilots { get; set; }
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
      result.Append($"\"model\":\"{model}\",");
      result.Append($"{Environment.NewLine}");
      result.Append($"\"manufacturer\":\"{manufacturer}\",");
      result.Append($"{Environment.NewLine}");
      result.Append($"\"cost_in_credits\":\"{cost_in_credits}\",");
      result.Append($"{Environment.NewLine}");
      result.Append($"\"length\":\"{length}\",");
      result.Append($"{Environment.NewLine}");
      result.Append($"\"max_atmosphering_speed\":\"{max_atmosphering_speed}\",");
      result.Append($"{Environment.NewLine}");
      result.Append($"\"crew\":\"{crew}\",");
      result.Append($"{Environment.NewLine}");
      result.Append($"\"passengers\":\"{passengers}\",");
      result.Append($"{Environment.NewLine}");
      result.Append($"\"cargo_capacity\":\"{cargo_capacity}\",");
      result.Append($"{Environment.NewLine}");
      result.Append($"\"consumables\":\"{consumables}\",");
      result.Append($"{Environment.NewLine}");
      result.Append($"\"hyperdrive_rating\":\"{hyperdrive_rating}\",");
      result.Append($"{Environment.NewLine}");
      result.Append($"\"MGLT\":\"{MGLT}\",");
      result.Append($"{Environment.NewLine}");
      result.Append($"\"starship_class\":\"{starship_class}\",");
      result.Append($"{Environment.NewLine}");

      if (pilots.Count > 0)
      {
        result.Append($"\"pilots\":[");
        foreach (string item in pilots)
        {
          result.Append($"\"{item}\",");
          result.Append($"{Environment.NewLine}");
        }

        result.Append($"],");
        result.Append($"{Environment.NewLine}");
      }
      else
      {
        result.Append($"\"pilots\":[],");
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
