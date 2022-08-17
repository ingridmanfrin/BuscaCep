using BuscaCep.Models;
using Newtonsoft.Json;

namespace BuscaCep.Services
{
    public class ViaCep
    {
        //async: assíncrono
        public static async Task<CepResponse> BuscaCep(string cep)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://viacep.com.br/");
                
                var result = await client.GetAsync($"/ws/{cep}/json/");
                string resultContent = await result.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<CepResponse>(resultContent);
                
            }
        }
    }
}
