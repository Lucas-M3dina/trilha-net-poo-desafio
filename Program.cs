using DesafioPOO.Models;

Console.WriteLine("Celular Nokia");
Smartphone nokia = new Nokia("11984217300", "Modelo teste", "15346464646546", 64);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n\n");

Console.WriteLine("Celular iPhone");
Smartphone iPhone = new Iphone("11925417399", "Modelo teste Apple", "168535416545", 128);
iPhone.Ligar();
iPhone.InstalarAplicativo("Instagram");