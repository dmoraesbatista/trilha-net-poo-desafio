using System.Runtime;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string numero;
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        public string modelo;
        public string IMEI;
        public string memoria;
        public Smartphone(string aNumero, string aModelo, string aIMEI, string aMemoria)
        {
            numero = aNumero;
            // TODO: Passar os parâmetros do construtor para as propriedades
            modelo = aModelo;
            IMEI = aIMEI;
            memoria = aMemoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public virtual void InstalarAplicativo(string nomeApp)
        {
           Console.WriteLine($"Instalando o aplicativo {nomeApp} no smartphone {modelo}...");
        }
    }
}