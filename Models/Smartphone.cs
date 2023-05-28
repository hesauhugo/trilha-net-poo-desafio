namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        protected string Modelo {get;set;}
        protected string IMEI {get;set;}
        protected int Memoria {get;set;}

        public Smartphone(string numero, string modelo,string imei,int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            imei = IMEI;
            memoria = Memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public void InstalarAplicativo(string nomeApp){
            Console.WriteLine($"Celular modelo {Modelo}, aplicativo nome {nomeApp} instalado");
        }
    }
}