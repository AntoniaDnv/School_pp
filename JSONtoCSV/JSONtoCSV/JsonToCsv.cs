using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace JSONtoCSV
{
    public static class JsonToCsv
    {
        private static IEnumerable<Country> countries = new List<Country>();
       
       

        public static void CheckUserInput(string userInput)
        {
            string userInputValidator = @"^(?<path>\w+)/\w+/$";

            Match match = Regex.Match(userInput, userInputValidator);

            if (!match.Success || !IsApiPathValid(match))
            {
                throw new Exception("Invalid input request");

            }

        }
        public static bool IsApiPathValid(Match match)
        {
            string path = match.Groups["path"].Value.ToLower();
            string[] allApiPaths = Enum.GetNames(typeof(ApiPath));

            bool isPathValid = allApiPaths
                .Any(x => x.Equals(path, StringComparison.OrdinalIgnoreCase));

            if (isPathValid)
            {
                return true;
            }
            return false;
        }

        public static string GetJson(string userInput)
        {
            Task<HttpResponseMessage> response = GetResponse(userInput);
            HttpStatusCode statusCode = response.Result.StatusCode;

            if(statusCode == HttpStatusCode.NotFound)
            {
                throw new Exception("No results found");
            }
            else if (statusCode != HttpStatusCode.OK)
            {
              throw new Exception("An error apeared! Try again.");

            }
             string responseAsString = ReadResponseAsStringAsync(response);

            try
            {
               // countries = DeserializeJson(responseAsString);
            }
            catch (Exception )
            {
                throw new Exception("Invalid JSON. Try another request.");
            }

           // string countriesAsJson = SerializeJson();
           // return countriesAsJson;
            return String.Empty;



        }
        public static Task<HttpResponseMessage> GetResponse(string userInput)
        {
            string url = $"https://restcountries.com/v3.1/%7BuserInput%7D{userInput}";
            HttpClient client = new HttpClient();
            Task<HttpResponseMessage> response = client.GetAsync(url);
            return response;

        }

        public static string ReadResponseAsStringAsync(Task<HttpResponseMessage> response) 
            => response.Result.Content.ReadAsStringAsync().Result;
    }
}
