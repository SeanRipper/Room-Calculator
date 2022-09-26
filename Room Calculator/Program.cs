// See https://aka.ms/new-console-template for more information
using System.Formats.Asn1;

Console.WriteLine("Please enter the length of the room");
double length = double.Parse(Console.ReadLine());

Console.WriteLine("Please enter the width of the room");
double width = double.Parse(Console.ReadLine());





double area = length * width;
double perimeter = (length * 2) + (width * 2);


Console.WriteLine("The area of the room is " + area);
Console.WriteLine();
Console.WriteLine("The perimeter of the room is " + perimeter);
Console.WriteLine();

if (area <= 250)
{
    Console.WriteLine("This is a small-sized room!");
    Console.WriteLine();
}
else if (area > 250 && area < 650)
    {
    Console.WriteLine("This is a medium-sized room!");
    Console.WriteLine();
}
else if (area >= 650)
{
    Console.WriteLine("This is a large-sized room!");
    Console.WriteLine();
}
Console.WriteLine("Please enter the depth of the room");
double depth = double.Parse(Console.ReadLine());

double volume = length * width * depth;
double surface = 2 * ((length * depth) + (depth * width) + (length * width));

Console.WriteLine("The volume of the room is " + volume);
Console.WriteLine();
Console.WriteLine("The surface area of the room is " + surface);
Console.WriteLine();











