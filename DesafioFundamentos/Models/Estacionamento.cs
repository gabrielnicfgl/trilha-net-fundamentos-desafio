namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        string placa = "";


        public Estacionamento(decimal precoDeInicio, decimal precoHora)
        {
            this.precoInicial = precoDeInicio; //construtor tem a função de receber o ´parametro do program.cs, e atualizar a variavel encapsulada
            this.precoPorHora = precoHora;
        }

        public void AdicionarVeiculo()
        {


            Console.WriteLine("Digite a placa do veículo para estacionar:");
            placa = Console.ReadLine();
            veiculos.Add(placa);


        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            placa = Console.ReadLine();



            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper())) // (expressão lambda)Verifica se a placa digitada existe na minha lista "nesse caso o => tem a função de retornar o valor atribuido de x"
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                
                int horas = int.Parse(Console.ReadLine());

                decimal valorTotal = precoInicial + precoPorHora * horas;

                veiculos.Remove(placa);


                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {



            if (veiculos.Any())   // Verifica se há veículos na atribuidos a lista "veiculos"

            {
                Console.WriteLine("Os veículos estacionados são:");

                foreach (string veiculo in veiculos)
                {

                    System.Console.WriteLine(veiculo);

                }

            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
