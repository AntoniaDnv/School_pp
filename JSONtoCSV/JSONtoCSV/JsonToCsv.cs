using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace JSONtoCSV
{
    public static class JsonToCsv
    {
        public static void CheckUserInput(string userInput)
        {
            string userInputValidator = @"^(?<path>\w+) /\w+/$";

            Match match = Regex.Match(userInput, userInputValidator);

            //if (!match.Success || !IsApiPathValid(match))
           // {
            //    throw new Exception("Invalid input request");

           // }


        }
    }
}
