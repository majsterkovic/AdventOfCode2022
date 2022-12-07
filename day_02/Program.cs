// Day 2: Rock Paper Scissors

var firstStrategy = 0;
var secondStrategy = 0;

foreach (var line in File.ReadLines(@"input"))
{
    var shapes = line.Split(' ');

    var opponent = Convert.ToChar(shapes[0]) - 'A';
    var player = Convert.ToChar(shapes[1]) - 'X';

    if (player == opponent)
        firstStrategy += 3;
    else if (player == (opponent + 1) % 3)
        firstStrategy += 6;
    firstStrategy += player + 1;


    secondStrategy += player * 3;
    if (player == 2) secondStrategy += (opponent + 1) % 3 + 1;
    else if (player == 1) secondStrategy += opponent + 1;
    else if (player == 0) secondStrategy += (opponent + 2) % 3 + 1;
}

Console.WriteLine("Points scored for the first strategy: " + firstStrategy);
Console.WriteLine("Points scored for the second strategy: " + secondStrategy);