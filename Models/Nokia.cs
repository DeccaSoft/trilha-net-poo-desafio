namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string marca, string modelo, string imei, int memoria) : base(numero, marca, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando App {nomeApp} para {this.SO}...");
        }
    }
}