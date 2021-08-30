using Equinox.Domain.Interfaces;
using Equinox.Domain.Models;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;

namespace ViaCepService
{
    public class ViaCep : ICepService
    {
        public ConsultaCep ConsultarCep(string cep)
        {
            try
            {
                cep = cep.Replace(".", "").Replace("-", "").Replace(" ", "");
                var client = new RestClient($"http://viacep.com.br/ws/{cep}/json/") { Timeout = 3000 };
                var request = new RestRequest(Method.GET);
                var response = client.Execute(request);

                return JObject.Parse(response.Content).ToObject<ConsultaCep>();
            }
            catch
            {
                return new ConsultaCep();
            }
        }
    }
}
