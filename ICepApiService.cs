using AprendendoRefit.Models;
using Refit;

namespace AprendendoRefit.Interfaces
{
    public interface ICepApiService
    {
        [Get("/ws/{cep}/json")]
        Task<CepResponse> GetEnderecoAsync(string cep);
    }
}