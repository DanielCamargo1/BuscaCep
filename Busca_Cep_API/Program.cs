using BuscaCep.Deserializer;
using BuscaCep.Filtros;
using System.Text.Json;

internal class Program
{
    private static async Task Main(string[] args)
    {
        using (HttpClient client = new HttpClient())
        {
            try
            {
                Console.WriteLine("Insira o seu cep: ");
                int cep = int.Parse(Console.ReadLine());
                string CepString = cep.ToString();
                if (CepString.Length < 8 || CepString.Length > 8)
                {
                    Console.WriteLine("Invalido! O cep digitado é menor do que 8 digitos!!");
                    Console.ReadKey();
                }
                string resposta = await client.GetStringAsync($@"https://viacep.com.br/ws/{CepString}/json/");
                var ApiCep = JsonSerializer.Deserialize<List<DeserializerApi>>(resposta)!;
                Console.WriteLine(ApiCep);
            }
            catch (Exception ex)
            {
                Console.WriteLine($" Problema: { ex.Message}");
            }
        }
    }
}