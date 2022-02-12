// See https://aka.ms/new-console-template for more information
var pi = Math.PI;

DateTime today = DateTime.Now;
Console.WriteLine("Today's Date");
Console.WriteLine($"1. {today, 40:MMMM} {today:dd}, {today:yyyy}");
Console.WriteLine($"2. {today:yyyy}.{today:MM}.{today:dd}");
Console.WriteLine($"3. Day {today:dd} of {today:MMMM}, {today:yyyy}");
Console.WriteLine($"4. Year {today:yyyy}, Month:{today:MM}, Day:{today:dd}");
Console.WriteLine($"5. {today, 10:dddd}");
Console.WriteLine($"6. {today, 4:hh}:{today:mm} {today:tt} {today, 10:dddd}");
Console.WriteLine($"7. h:{today:hh},m:{today:mm},s:{today:ss}");
Console.WriteLine($"8. {today:yyyy}.{today:MM}.{today:hh}.{today:mm}.{today:ss}");

Console.WriteLine("Using PI");
Console.WriteLine("1. ${0:n}", pi);
Console.WriteLine($"2. {pi, 10:f3}");
