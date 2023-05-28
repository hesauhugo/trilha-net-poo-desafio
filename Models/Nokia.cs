namespace DesafioPOO.Models
{
    
    public class Nokia:Smartphone
    {
        public Nokia(string numero, string modelo,string imei,int memoria):base(numero,modelo,imei,memoria){
        }

        public void InstalarAplicativo(string nomeApp){
            Console.WriteLine($"Celular modelo {Modelo}, aplicativo nome {nomeApp} instalado");
        }
    }
}