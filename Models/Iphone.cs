using System;

namespace DesafioPOO.Models;
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
    public Iphone(string aNumero, string aModelo, string aIMEI, string aMemoria) : base(aNumero, aModelo, aIMEI, aMemoria)
    {
    }

    // TODO: Sobrescrever o método "InstalarAplicativo"
    public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no iPhone ...");
        }
    }
