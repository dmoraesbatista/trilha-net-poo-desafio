using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia nokia = new Nokia("123456789", "Nokia 3310", "123456789012345", "32MB");
nokia.Ligar();
nokia.InstalarAplicativo("Snake");

Iphone iphone = new Iphone("987654321", "iPhone 12", "987654321098765", "128GB");
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");