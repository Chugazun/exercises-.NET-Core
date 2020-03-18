using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace ExercisesCore.Test_JSON_CEP.Services
{
    public static class SearchService
    {
        static HttpClient client = new HttpClient();
        public static string GetByZipCode(string zipCode)
        {
            string url = $"https://viacep.com.br/ws/{zipCode}/json/";

            string result = client.GetStringAsync(url).Result;

            return result;
        }
    }
}
