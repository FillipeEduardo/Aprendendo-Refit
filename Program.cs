using AprendendoRefit.Interfaces;
using Refit;

namespace AprendendoRefit
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var cepClient = RestService.For<ICepApiService>("https://viacep.com.br");
            var endereco = await cepClient.GetEnderecoAsync("49052180");
            System.Console.WriteLine($"Endereço: {endereco.Logradouro}");
            System.Console.WriteLine($"Bairro: {endereco.Bairro}");
            
        }
    }
}