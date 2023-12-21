namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
            // TODO: Passar os parâmetros do construtor para as propriedades
        }

        protected Smartphone(string numero)
        {
            Numero = numero;
        }

        public void Ligar(Smartphone fazerLigacao)
        {
            Console.WriteLine($"Ligando para: {fazerLigacao.Numero}");
        }
        
        public void ReceberLigacao(Smartphone receberLigacao)
        {
            
            Console.WriteLine($"Recebendo ligação de: {receberLigacao.Numero}");
        }

        public abstract void InstalarAplicativo(string nomeApp, int tamanho);                
    }
}