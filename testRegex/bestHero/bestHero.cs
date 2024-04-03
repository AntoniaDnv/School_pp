    using System.IO.Pipes;
    using System.Text.RegularExpressions;
    using static System.Net.Mime.MediaTypeNames;

    namespace bestHero
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                string[] names = Console.ReadLine()
                    .Split(", ");
                string input = Console.ReadLine();
           
                var patternW = @"[A-z]";
                var patternD = @"\d";
                Regex regexW = new Regex(patternW); 
                Regex regexD = new Regex(patternD);
                Dictionary<string, double> collection= new Dictionary<string, double>();
           
                while (input.ToLower() != "end")
                {
                    MatchCollection matches = regexW.Matches(input);
                    string name = "";
                    foreach (Match match in matches)
                    {
                        name += match;
                    }
                    if(names.Contains(name))
                    {
                        double value = 0;
                        MatchCollection matchesD = regexD.Matches(input);
                        foreach (Match matchD in matchesD)
                        {
                            value += double.Parse(matchD.Value);
                        }
                   
                        if (collection.ContainsKey(name))
                        {
                            collection[name] += value;
                        }
                        else
                        {
                            collection.Add(name, value);
                        }
                    }
                    input = Console.ReadLine();
                }
                 int max = int.MinValue;
                 string best = "";
               
                foreach(var kvp in collection.OrderByDescending(x => x.Value).Take(3))
                {
                   
                Console.WriteLine(kvp.Key);
            }
          
            }
        }
    }