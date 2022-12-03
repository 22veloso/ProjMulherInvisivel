
using Newtonsoft.Json;
using ProjMulherInvisivel.Models;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ProjMulherInvisivel.Service
{
    public class ApiService
    {
            static readonly HttpClient cliente = new HttpClient();
            public static async Task<List<Cliente>> GetCliente()
            {
            try
            {
                HttpResponseMessage response = await ApiService.cliente.GetAsync(@"https://localhost:7190/api/Clientes");
                response.EnsureSuccessStatusCode();
                string clienteReturn = await response.Content.ReadAsStringAsync();
                var clientes = JsonConvert.DeserializeObject<List<Cliente>>(clienteReturn);
                return clientes;
            }
            catch (HttpRequestException e)
            {
                throw;
            }
        }
    }

}

        

