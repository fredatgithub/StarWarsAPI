using System;

namespace ConsoleAppGetAPI
{
  class Program
  {
    static void Main()
    {
      Action<string> display = Console.WriteLine;
      display("Get JSON from Starwars API");
      string url1 = "https://swapi.dev/api/people/1/";

      display("Press any key to exit:");
      Console.ReadKey();
    }
  }
}
