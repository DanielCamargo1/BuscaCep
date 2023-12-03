using BuscaCep.Deserializer;
using System.Text.Json;

internal class Program
{
    private static async Task Main(string[] args)
    {
        {
            Console.WriteLine("Insira o seu cep: ");
            var cep = Console.ReadLine();
            if(cep.Length < 8 || cep.Length > 9)
            {
                Console.WriteLine("CEP INVÁLIDO, DIGITE NOVAMENTE!: ");
                cep = "";
            }
            var endereco = $@"http://viacep.com.br/ws/{cep}/json/";
            Console.WriteLine("Executando para:" + endereco);
            var client = new HttpClient();
            try
            {
                HttpResponseMessage? response = await client.GetAsync(endereco);
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();
                Console.WriteLine(responseBody);
            }
            catch (Exception ex)
            {
                Console.WriteLine($" Problema: {ex.Message}");
            }
        }
    }
}