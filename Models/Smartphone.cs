namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Marca { get; set; }
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }
        public string SO { get; set; }


        public Smartphone(string numero, string marca, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Marca = marca;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
            if (Marca == "Aplle")
            {
                SO = "iOS";
            }
            else
            {
                SO = "Android";
            }
        }

        public void Ligar()
        {
            Console.WriteLine($"Ligando {this.Marca} {this.Modelo}...");
            Console.WriteLine($"Iniciando {this.SO}...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine($"Recebendo ligação no {this.Marca} {this.Modelo}...");
        }

        public void FazerLigacao()
        {
            Console.WriteLine($"Fazendo ligação do {this.Marca} {this.Modelo}...");
        }

        public abstract void InstalarAplicativo(string nomeApp);

        public void ExecutarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Executando {nomeApp} no {this.SO}...");
        }
    }
}