// Day 1: Calorie Counting


var lines = File.ReadAllLines(@"input");
lines.Append("");
var sum = 0;

var listOfCaloriesSum = new List<int>();

foreach (var line in lines)
    if (line != "")
    {
        var number = int.Parse(line);
        sum += number;
    }
    else
    {
        listOfCaloriesSum.Add(sum);
        sum = 0;
    }

var max = listOfCaloriesSum.Max();
var index = listOfCaloriesSum.IndexOf(max);
Console.WriteLine("Elf number {0} carries the most calories: {1}.", index + 1, max);

var maxThreeSum = listOfCaloriesSum.OrderByDescending(x => x).Take(3).Sum();
Console.WriteLine("Top three Elves are carrying in total {0} calories.", maxThreeSum);