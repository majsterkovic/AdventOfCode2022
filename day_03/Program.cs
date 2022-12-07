// Day 3: Rucksack Reorganization

int GetPriority(string i)
{
    var item = Convert.ToChar(i);
    if (char.IsUpper(item))
        return item - 'A' + 1 + 26;
    else
        return item - 'a' + 1;
}

var lines = File.ReadAllLines(@"input");

var sumOfPriorities = 0;

foreach (var line in lines)
{
    var lineLength = line.Length;
    var compartment1 = line.Substring(0, lineLength / 2);
    var compartment2 = line.Substring(lineLength / 2, lineLength / 2);

    var commonItem = compartment1.Intersect(compartment2);
    var result = string.Join(" ", commonItem);

    sumOfPriorities += GetPriority(result);
}

Console.WriteLine("The sum of the priorities of those item types is {0}", sumOfPriorities);


sumOfPriorities = 0;

for (var i = 0; i < lines.Length; i += 3)
{
    var rucksack1 = lines.ElementAt(i);
    var rucksack2 = lines.ElementAt(i + 1);
    var rucksack3 = lines.ElementAt(i + 2);

    var commonItem = rucksack1.Intersect(rucksack2).Intersect(rucksack3);
    var result = string.Join(" ", commonItem);

    sumOfPriorities += GetPriority(result);
}

Console.WriteLine("The sum of the priorities of those item types is {0}", sumOfPriorities);