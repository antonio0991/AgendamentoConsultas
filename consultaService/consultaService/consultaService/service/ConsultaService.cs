using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using consultaService.model;
using Newtonsoft.Json;

namespace consultaService.service
{
    public class ConsultaService
    {
       private readonly string urlBase = "http://10.0.2.2:5236/api/consultas";
        public async Task<List<Consulta>> GetAll()
        {
            using (var client = new HttpClient())
            {
               var result = await client.GetStringAsync(urlBase);
               return JsonConvert.DeserializeObject<List<Consulta>>(result);
            }
        }
    }
}
