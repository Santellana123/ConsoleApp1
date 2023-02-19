using ConsoleApp1;
using System.Diagnostics.Contracts;

Contacto1 x;
x = new Contacto1();
Console.WriteLine("Nombre");
x.Nombre = Console.ReadLine();
Console.WriteLine("Telefono");
x.Telefono = Console.ReadLine();
x.FechaNacimiento2 = DateTime.Parse("2003/01/01");

Console.WriteLine(x.ToString());


Console.ReadKey();