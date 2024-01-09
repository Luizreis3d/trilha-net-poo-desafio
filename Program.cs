using DesafioPOO.Models;



Smartphone iphone = new Iphone("819123456", "13 PRO MAX", "0122456774", 128);
Console.WriteLine("\n");
Console.WriteLine("Smartphone Iphone");
Console.WriteLine($"Especificações do Smartphone\nModelo: {iphone.Modelo}\nMemoria RAM: {iphone.Memoria}GB");
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");

Console.WriteLine("\n");


Smartphone nokia = new Nokia("8190098212", "G60 5G", "0122454321", 256);
Console.WriteLine("Smartphone Nokia");
Console.WriteLine($"Especificações do Smartphone\nModelo: {nokia.Modelo}\nMemoria RAM: {nokia.Memoria}GB");
nokia.Ligar();
nokia.InstalarAplicativo("Twitter");