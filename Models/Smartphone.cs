namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo { get; set; }
        public string Memoria { get; set; }

        public Smartphone(string numero, string modelo, string memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        // Certifique-se de que este método está declarado como "abstract"
        public abstract void InstalarAplicativo(string nomeApp);
    }
}
