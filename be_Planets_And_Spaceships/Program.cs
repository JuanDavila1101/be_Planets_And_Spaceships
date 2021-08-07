using System;
using System.Collections.Generic;
using System.Linq;

namespace be_Planets_And_Spaceships
{
  class Program
  {
    static void Main(string[] args)
    {
      List<string> planetList = new List<string>() { "Mercury", "Mars" };
      Console.WriteLine($"\nThe planets in the list are: {string.Join(", ", planetList)}.");

      planetList.Add("Jupiter");
      planetList.Add("Saturn");
      Console.WriteLine($"\nThe planets in the list are: {string.Join(", ", planetList)}.");

      List<string> planetList1 = new List<string>() { "Mercury", "Mars" };
      List<string> planetList2 = new List<string>() { "Jupiter", "Saturn" };
      Console.WriteLine($"\nThe planets 1 in the list are: {string.Join(", ", planetList1)}.");
      Console.WriteLine($"\nThe planets 2 in the list are: {string.Join(", ", planetList2)}.");

      planetList1.AddRange(planetList2);
      Console.WriteLine($"\nAfter AddRange() the planets 1 in the list are: {string.Join(", ", planetList1)}.");
      Console.WriteLine($"\nAfter AddRange() the  planets 2 in the list are: {string.Join(", ", planetList2)}.");

      planetList1.Insert(1, "Earth");
      Console.WriteLine($"\nAfter Insert the planets 1 in the list are: {string.Join(", ", planetList1)}.");

      planetList1.Insert(1, "Venus");
      Console.WriteLine($"\nAfter Insert the planets 1 in the list are: {string.Join(", ", planetList1)}.");

      planetList1.Add("Neptune");
      Console.WriteLine($"\nAfter Addthe planets 1 in the list are: {string.Join(", ", planetList1)}.");

      planetList1.Add("Pluto");
      Console.WriteLine($"\nAfter Addthe planets 1 in the list are: {string.Join(", ", planetList1)}.");

      var rockyPlanets = planetList1.GetRange(0, 4);
      Console.WriteLine($"\nAfter GetRange planets 1 in the list are: {string.Join(", ", planetList1)}.");
      Console.WriteLine($"\nThe Rocky Planets in the list are: {string.Join(", ", rockyPlanets)}.");

      planetList1.Remove(planetList1.Last());
      Console.WriteLine($"\nPluto is a dwarf planet, so we are taking it off the list: {string.Join(", ", planetList1)}.");

      planetList1.Add("Pluto");
      Console.WriteLine($"\nBut Pluto is now back in the list: {string.Join(", ", planetList1)}.");

      var listOfSolarSystemProbes = new Dictionary<string, List<string>>();
      listOfSolarSystemProbes.Add("Rocket", new List<string> { "Mars", "Mercury", "Saturn", "Pluto" });
      listOfSolarSystemProbes.Add("The Ark", new List<string> { "Mars", "Saturn", "Pluto" });
      listOfSolarSystemProbes.Add("The Milano", new List<string> { "Mars", "Mercury", "Pluto" });
      listOfSolarSystemProbes.Add("USS ENterprise", new List<string> { "Mars", "Mercury", "Neptune", });
      listOfSolarSystemProbes.Add("Experiment 626", new List<string> { "Earth", "Mercury", "Saturn", "Pluto" });
      listOfSolarSystemProbes.Add("Birthing Matrix", new List<string> { "Venus", "Mercury", "Jupiter", "Pluto" });
      listOfSolarSystemProbes.Add("Millenium Falcon", new List<string> { "Earth", "Neptune", "Saturn", "Pluto" });

      Console.Write($"\n\n ");

      foreach (var planet in planetList1)
      {
        Console.Write($"\n{planet}: ");
        foreach (var (probeName, probePlanestList) in listOfSolarSystemProbes)
        {
          if (probePlanestList.Contains(planet))
          {
            Console.Write($"{probeName}, ");
          }

        }
      }



    }
  }
}









// ## Reference

// - [C# Lists](https://msdn.microsoft.com/en-us/library/6sh2ey19(v=vs.110).aspx)
// - [Interactive C# Lists](http://www.learncs.org/en/Lists)

// ## Exercise

// In the `Main` method, place the following code

// ```csharp
// List<string> planetList = new List<string>() { "Mercury", "Mars" };
// ```

// 1. `Add()` Jupiter and Saturn at the end of the list.
// 2. Create another `List` that contains that last two planet of our solar system.
// 3. Combine the two lists by using `AddRange()`.
// 4.Use `Insert()` to add Earth, and Venus in the correct order.
// 5. Use `Add()` again to add Pluto to the end of the list.
// 6. Now that all the planets are in the list, slice the list using `GetRange()` in order to extract the rocky planets into a new list called `rockyPlanets`.
// 7.Being good amateur astronomers, we know that Pluto is now a dwarf planet, so use the `Remove()` method to eliminate it from the end of `planetList`.

// ## Iterating over planets

// > Ref: [List of Solar System probes](https://en.wikipedia.org/wiki/List_of_Solar_System_probes)

// 1.Create a dictionary that will hold the name of a spacecraft
// that we have launched, and a list of names of the planets that it has
// visited. Remember that `List` is a Type just like native types (such as `string`, `int`, & `bool`) and your custom types (such as `Movie`, `Dog`, and `Food`). These types can be passed to anything, like a dictionary.
// 2. Iterate over your list of planets from above, and inside that loop,
// iterate over the dictionary. Write to the console, for each planet,
// which satellites have visited which planet.

// ```
// Mars: Viking, Opportunity, Curiosity
// Venus: Mariner, Venera
// etc...
// ```


















