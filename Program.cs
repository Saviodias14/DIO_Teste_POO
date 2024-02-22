using DesafioPOO.Models;

Iphone iphone = new("991472152", "IPhone 12X", "78989538995754857", 256);
Console.WriteLine(iphone.Numero);
Console.WriteLine(iphone.Modelo);
Console.WriteLine(iphone.IMEI);
Console.WriteLine(iphone.Memoria);

iphone.InstalarAplicativo("WhatsApp");
Nokia nokia = new("992020599", "Nokia Tijolão", "93800934800398493", 32);
Console.WriteLine(nokia.Numero);
Console.WriteLine(nokia.Modelo);
Console.WriteLine(nokia.IMEI);
Console.WriteLine(nokia.Memoria);

nokia.InstalarAplicativo("Jogo da cobrinha");

