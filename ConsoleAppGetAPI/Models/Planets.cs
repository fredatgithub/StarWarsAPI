using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppGetAPI.Models
{
  public class Planets
  {
    public string name { get; set; }
    public string rotation_period { get; set; }
    public string orbital_period { get; set; }
    public string diameter { get; set; }
    public string climate { get; set; }
    public string gravity { get; set; }
    public string terrain { get; set; }
    public string surface_water { get; set; }
    public string population { get; set; }
    public List<string> residents { get; set; }
    public List<object> films { get; set; }
    public DateTime created { get; set; }
    public DateTime edited { get; set; }
    public string url { get; set; }

    public string ToJsonString()
    {
      StringBuilder result = new StringBuilder();
      result.Append("{");
      result.Append($"{Environment.NewLine}");
      result.Append($"\"name\": \"{name}\",");
      result.Append($"{Environment.NewLine}");
      result.Append($"\"rotation_period\": \"{rotation_period}\",");
      result.Append($"{Environment.NewLine}");
      result.Append($"\"orbital_period\": \"{orbital_period}\",");
      result.Append($"{Environment.NewLine}");
      result.Append($"\"diameter\": \"{diameter}\",");
      result.Append($"{Environment.NewLine}");
      result.Append($"\"climate\": \"{climate}\",");
      result.Append($"{Environment.NewLine}");
      result.Append($"\"gravity\": \"{gravity}\",");
      result.Append($"{Environment.NewLine}");
      result.Append($"\"terrain\": \"{terrain}\",");
      result.Append($"{Environment.NewLine}");
      result.Append($"\"surface_water\": \"{surface_water}\",");
      result.Append($"{Environment.NewLine}");
      result.Append($"\"population\": \"{population}\",");
      result.Append($"{Environment.NewLine}");

      int counter = 0;
      string comma = ",";
      if (residents.Count > 0)
      {
        counter = 0;
        comma = ",";
        result.Append($"\"residents\": [");
        result.Append($"{Environment.NewLine}");
        foreach (string item in residents)
        {
          counter++;
          if (counter == residents.Count)
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
        result.Append($"\"residents\": [],");
        result.Append($"{Environment.NewLine}");
      }

      if (films.Count > 0)
      {
        counter = 0;
        comma = ",";
        result.Append($"\"films\": [");
        result.Append($"{Environment.NewLine}");
        foreach (string item in films)
        {
          counter++;
          if (counter == films.Count)
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
        result.Append($"\"films\": [],");
        result.Append($"{Environment.NewLine}");
      }

      result.Append($"\"created\": \"{created}\",");
      result.Append($"{Environment.NewLine}");
      result.Append($"\"edited\": \"{edited}\",");
      result.Append($"{Environment.NewLine}");
      result.Append($"\"url\": \"{url}\"");
      result.Append($"{Environment.NewLine}");
      result.Append("}");
      result.Append($"{Environment.NewLine}");

      return result.ToString();
    }
  }
}
