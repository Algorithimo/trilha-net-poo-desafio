using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia nokia= new Nokia("12345678", "nokia Barato", "121131", 16);
Iphone iphone= new Iphone("87654321", "iphone Barato", "121131", 32);

nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smarthphone iPhone:");
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
