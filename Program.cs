// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

List<Eruption> eruptions = new List<Eruption>()
{
    new Eruption("La Palma", 2021, "Canary Is", 2426, "Stratovolcano"),
    new Eruption("Villarrica", 1963, "Chile", 2847, "Stratovolcano"),
    new Eruption("Chaiten", 2008, "Chile", 1122, "Caldera"),
    new Eruption("Kilauea", 2018, "Hawaiian Is", 1122, "Shield Volcano"),
    new Eruption("Hekla", 1206, "Iceland", 1490, "Stratovolcano"),
    new Eruption("Taupo", 1910, "New Zealand", 760, "Caldera"),
    new Eruption("Lengai, Ol Doinyo", 1927, "Tanzania", 2962, "Stratovolcano"),
    new Eruption("Santorini", 46,"Greece", 367, "Shield Volcano"),
    new Eruption("Katla", 950, "Iceland", 1490, "Subglacial Volcano"),
    new Eruption("Aira", 766, "Japan", 1117, "Stratovolcano"),
    new Eruption("Ceboruco", 930, "Mexico", 2280, "Stratovolcano"),
    new Eruption("Etna", 1329, "Italy", 3320, "Stratovolcano"),
    new Eruption("Bardarbunga", 1477, "Iceland", 2000, "Stratovolcano")
};
// Example Query - Prints all Stratovolcano eruptions
/* IEnumerable<Eruption> stratovolcanoEruptions = eruptions.Where(c => c.Type == "Stratovolcano");
PrintEach(stratovolcanoEruptions, "Stratovolcano eruptions."); */

// Execute Assignment Tasks here!

// how do I use FirstOrDefault
// first eruption in Chile
//IEnumerable<Eruption> chErup = eruptions.Where(c => c.Location == "Chile").Take(1);
// IEnumerable<Eruption> ch = eruptions.FirstOrDefault(ch => ch.Location == "Chile").ToList();
// PrintEach(chErup);

// first "Hawaii Is" eruption; if none, print "No Hawaiian Is eruption found"
IEnumerable<Eruption> hwErup = eruptions.Where(hw => hw.Location == "Hawaiian Is").Take(1);
Console.WriteLine(
    $"{hwErup.ToString()}",
    string.IsNullOrEmpty(hwErup.ToString()) ? "not a" : "a"
);

// first eruption after 1900 AND in "New Zealand"
IEnumerable<Eruption> nz = eruptions.Where(nz => nz.Location == "New Zealand" && nz.Year > 1900).Take(1);
// PrintEach(nz);

// all eruptions where volcano's elevation is > 2000m
IEnumerable<Eruption> twoThou = eruptions.Where(t => t.ElevationInMeters > 2000).ToList();
// PrintEach(twoThou);

// how do I print the total #?
// all eruptions where volcano's name starts with Z, and total number of eruptions
IEnumerable<Eruption> zeta = eruptions.Where(z => z.Volcano.StartsWith("Z")).ToList();
// PrintEach(zeta);

// find highest elevation and print that integer
var highest = eruptions.Max(h => h.ElevationInMeters);
Console.WriteLine(highest);

// how do I use this var to access names?
// use highest elevation variable to find and print name of volcano with that elevation
// IEnumerable<Eruption> hName = eruptions.Where()

// how do I get the names only?
// print all volcano names alphabetically
IEnumerable<Eruption> alpha = eruptions.OrderBy(a => a.Volcano);
// PrintEach(alpha);

// print all eruptions that happened before the year 1000 CE alphabetically by volcano name
IEnumerable<Eruption> alphaThou = eruptions.OrderBy(a => a.Volcano).Where(a => a.Year < 1000);
// PrintEach(alphaThou);

// Helper method to print each item in a List or IEnumerable.This should remain at the bottom of your class!
static void PrintEach(IEnumerable<dynamic> items, string msg = "")
{
    Console.WriteLine("\n" + msg);
    foreach (var item in items)
    {
        Console.WriteLine(item.ToString());
    }
}



