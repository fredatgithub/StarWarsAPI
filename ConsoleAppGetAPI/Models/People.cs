using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppGetAPI.Models
{
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

    public override string ToString()
    {
      StringBuilder result = new StringBuilder();
      result.Append($"name:{name},");
      result.Append($"{Environment.NewLine}");
      result.Append($"height:{height},");
      result.Append($"{Environment.NewLine}");
      result.Append($"mass:{mass},");
      result.Append($"{Environment.NewLine}");
      result.Append($"hair_color:{hair_color},");
      result.Append($"{Environment.NewLine}");
      result.Append($"skin_color:{skin_color},");
      result.Append($"{Environment.NewLine}");
      result.Append($"eye_color:{eye_color},");
      result.Append($"{Environment.NewLine}");
      result.Append($"birth_year:{birth_year},");
      result.Append($"{Environment.NewLine}");
      result.Append($"gender:{gender},");
      result.Append($"{Environment.NewLine}");
      result.Append($"homeworld:{homeworld},");
      result.Append($"{Environment.NewLine}");

      foreach (string film in films)
      {
        result.Append($"film:{film},");
        result.Append($"{Environment.NewLine}");
      }

      foreach (string item in species)
      {
        result.Append($"species:{item},");
        result.Append($"{Environment.NewLine}");
      }

      foreach (string item in vehicles)
      {
        result.Append($"vehicles:{item},");
        result.Append($"{Environment.NewLine}");
      }

      foreach (string item in starships)
      {
        result.Append($"starships:{item},");
        result.Append($"{Environment.NewLine}");
      }

      result.Append($"created:{created},");
      result.Append($"{Environment.NewLine}");
      result.Append($"edited:{edited},");
      result.Append($"{Environment.NewLine}");
      result.Append($"url:{url}");
      result.Append($"{Environment.NewLine}");

      return result.ToString();
    }

    public string ToJsonString()
    {
      StringBuilder result = new StringBuilder();
      result.Append("{");
      result.Append($"{Environment.NewLine}");
      result.Append($"\"name\":\"{name}\",");
      result.Append($"{Environment.NewLine}");
      result.Append($"\"height\":\"{height}\",");
      result.Append($"{Environment.NewLine}");
      result.Append($"\"mass\":\"{mass}\",");
      result.Append($"{Environment.NewLine}");
      result.Append($"\"hair_color\":\"{hair_color}\",");
      result.Append($"{Environment.NewLine}");
      result.Append($"\"skin_color\":\"{skin_color}\",");
      result.Append($"{Environment.NewLine}");
      result.Append($"\"eye_color\":\"{eye_color}\",");
      result.Append($"{Environment.NewLine}");
      result.Append($"\"birth_year\":\"{birth_year}\",");
      result.Append($"{Environment.NewLine}");
      result.Append($"\"gender\":\"{gender}\",");
      result.Append($"{Environment.NewLine}");
      result.Append($"\"homeworld\":\"{homeworld}\",");
      result.Append($"{Environment.NewLine}");

      int counter = 0;
      string comma = ",";
      if (films.Count > 0)
      {
        counter = 0;
        comma = ",";
        result.Append($"\"films\":[");
        result.Append($"{Environment.NewLine}");
        foreach (string film in films)
        {
          counter++;
          if (counter == films.Count)
          {
            comma = string.Empty;
          }

          result.Append($"\"{film}\"{comma}");
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
