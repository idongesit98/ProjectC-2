// See https://aka.ms/new-console-template for more information
using ProjectC_2;

Console.WriteLine("Hello, World!");

try{
Shape circle = new Circle(10);
Shape rectangle = new Rectangle(5,10);
Shape triangle = new Triangle(30, 40,50);

Console.WriteLine($"Circle: Area = {circle.GetArea()}, Perimeter = {circle.GetPerimeter()}");
Console.WriteLine($"Rectangle:Area = {rectangle.GetArea()}, Perimeter = {rectangle.GetPerimeter()}");
Console.WriteLine($"Triangle:Area = {triangle.GetArea()} Perimeter = {triangle.GetPerimeter()}");
}
catch(ArgumentException ex)
{
    Console.WriteLine($"Error:{ex.Message}");
}
catch(Exception ex)
{
    Console.WriteLine($"Error:{ex.Message}");
}
