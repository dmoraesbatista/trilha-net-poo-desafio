namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string aNumero, string aModelo, string aIMEI, string aMemoria) : base(aNumero, aModelo, aIMEI, aMemoria)
        {
        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia...");
         }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        
    }
}