namespace DesafioPOO.Models
{
    //TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
     {
         public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
             Modelo = modelo;
             IMEI = imei;
             Memoria = memoria;
        }

             public string Modelo { get; set; }
             public string IMEI { get; set; }
             public int Memoria { get; set; }

         public override void InstalarAplicativo(string nomeApp, int tamanho)       
        {
            if (this.Memoria > tamanho )
            {
                Console.WriteLine($"Instalando o aplicativo {nomeApp} no nokia {this.Modelo}...\nAplicativo instalado com sucesso.\nAgora seu smartphone contém {this.Memoria - tamanho}GB de memoria");
            }

            else
            {
                Console.WriteLine($"Instalando o aplicativo {nomeApp} no nokia {this.Modelo}...\nErro: memoria insuficiente para concluir a instalação do aplicativo.\nSeu smartphone contém {this.Memoria}GB de memoria e o tamanho do aplicativo é de {tamanho}GB");
            }
        
        }
    }            
}