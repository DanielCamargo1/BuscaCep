using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BuscaCep.Deserializer
{
    internal class DeserializerApi
    {
        [JsonPropertyName("cep")]
        public string Cep { get; set; }

        [JsonPropertyName("bairro")]
        public string Bairro { get; set; }

        [JsonPropertyName("localidade")]
        public int Localidade { get; set; }

        [JsonPropertyName("uf")]
        public int Estado { get; set; }

        
    }
}
