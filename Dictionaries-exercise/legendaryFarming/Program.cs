using System.ComponentModel;

namespace legendaryFarming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> materials = new Dictionary<string, int>()
            { 
              { "shards", 0 },
              { "fragments", 0 },
              { "motes", 0 }
            };

            SortedDictionary<string, int> junk = new SortedDictionary<string, int>();

            string obtainedItem = "";

            while (true)
            {
                string[] input = Console.ReadLine().Split();

                for (int i = 0; i < input.Length; i += 2)
                {
                    int quantity = int.Parse(input[i]);
                    string material = input[i + 1].ToLower();

                    if (materials.ContainsKey(material))
                    {
                        materials[material] += quantity;

                        if (materials[material] >= 250)
                        {
                            obtainedItem = material;
                            materials[material] -= 250;
                            break;
                        }
                    }
                    else
                    {
                        if (!junk.ContainsKey(material))
                        {
                            junk[material] = 0;
                        }

                        junk[material] += quantity;
                    }
                }

                if (!string.IsNullOrEmpty(obtainedItem))
                {
                    break;
                }
            }

            Console.WriteLine($"{char.ToUpper(obtainedItem[0]) + obtainedItem.Substring(1)} obtained!");

            foreach (var pair in materials.OrderByDescending(pair => pair.Value).ThenBy(pair => pair.Key))
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }

            foreach (var pair in junk)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }


        }
    }
}