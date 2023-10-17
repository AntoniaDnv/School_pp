﻿namespace HangMan
{
    internal class Program
    {
        static void Main(string[] args)
        {

          
            string win = 
@"┌───────────────────────────┐
│ │
│ WW WW **NN N │
│ WW WW ii NNN N │
│ WW WW WW ii N NN N │
│ WWWWWWW ii N NNN │
│ WW W ii N NN │
│ │
│ Good job! │
│ You guessed the word! │
└───────────────────────────┘";

            string loose = @" 
┌────────────────────────────────────┐
│ LLL OOOO SSSS SSSS │
│ LLL OO OO SS SS SS SS │
│ LLL OO OO SS SS │
│ LLL OO OO SSSS SSSS │
│ LLL OO OO SS SS │
│ LLLLLLLLLL OO OO SS SS SS SS │
│ LLLLLLLLL OOOO SSSS SSSS │
│ |
│ You were so close. │
│ Next time you will guess the word! │
└────────────────────────────────────┘";
            string[] wrongGuess =
            {
                @" ╔═══╗ "+'\n' +
@" | ║ "+'\n' +
@" ║ "+'\n' +
@" ║ "+'\n' +
@" ║ "+ '\n' +
@" ███ ║ "+'\n' +
@" ══════╩═══",
@" ╔═══╗ "+'\n' +
@" | ║ "+'\n' +
@" O ║ "+'\n' +
@" ║ "+'\n' +
@" ║ "+'\n' +
@" ███ ║ "+'\n' +
@" ══════╩═══",
@" ╔═══╗ "+'\n' +
@" | ║ " +'\n' +
@" O ║ "+'\n' +
@" | ║ " +'\n' +
@" ║ " +'\n' +
@" ███ ║ " +'\n' +
@" ══════╩═══",
@" ╔═══╗ " +'\n' +
@" | ║ " +'\n' +
@" O ║ " +'\n' +
@" |\ ║ " +'\n' +
@" ║ " +'\n' +
@" ███ ║ " +'\n' +
@" ══════╩═══",
@" ╔═══╗ " +'\n' +
@" | ║ " +'\n' +
@" O ║ " +'\n' +
@" /|\ ║ " +'\n' +
@" ║ " +'\n' +
@" ███ ║ " +'\n' +
@" ══════╩═══",
@" ╔═══╗ " +'\n' +
@" | ║ " +'\n' +
@" O ║ " +'\n' +
@" /|\ ║ " +'\n' +
@" \ ║ " +'\n' +
@" ███ ║ " +'\n' +
@" ══════╩═══",
@" ╔═══╗ " +'\n' +
@" | ║ " +'\n' +
@" O ║ " +'\n' +
@" /|\ ║ " +'\n' +
@" / \ ║ " +'\n' +
@" ███ ║ " +'\n' +
@" ══════╩═══"
        };

            string[] deathAnimation =
                {@" ╔═══╗ " +'\n' +
@" | ║ " +'\n' +
@" O ║ " +'\n' +
@" /|\ ║ " +'\n' +
@" / \ ║ " +'\n' +
@" ███ ║ " +'\n' +
@" ══════╩═══",
@" ╔═══╗ " +'\n' +
@" | ║ " +'\n' +
@" O ║ " +'\n' +
@" /|\ ║ " +'\n' +
@" / \ ║ " +'\n' +
@" ║ " +'\n' +
@" ══════╩═══",
@" ╔═══╗ " +'\n' +
@" | ║ " +'\n' +
@" o & gt; ║ " +'\n' +
@" /| ║ " +'\n' +
@" &gt;\ ║ " +'\n' +
@" ║ " +'\n' +
@" ══════╩═══",
@" ╔═══╗ " +'\n' +
@" | ║ " +'\n' +
@" O ║ " +'\n' +
@" /|\ ║ " +'\n' +
@" / \ ║ " +'\n' +
@" ║ " +'\n' +
@" ══════╩═══",
@" ╔═══╗ " +'\n' +
@" | ║ " +'\n' +
@" &lt; o ║ " +'\n' +
@" |\ ║ " +'\n' +
@" / &lt; ║ " +'\n' +
@" ║ " +'\n' +
@" ══════╩═══",
@" ╔═══╗ " +'\n' +
@" | ║ " +'\n' +
@" O ║ " +'\n' +
@" /|\ ║ " +'\n' +
@" / \ ║ " +'\n' +
@" ║ " +'\n' +
@" ══════╩═══",
@" ╔═══╗ " +'\n' +
@" | ║ " +'\n' +
@" o & gt; ║ " +'\n' +
@" /| ║ " +'\n' +
@" &gt;\ ║ " +'\n' +
@" ║ " +'\n' +
@" ══════╩═══",
@" ╔═══╗ " +'\n' +
@" | ║ " +'\n' +
@" o & gt; ║ " +'\n' +
@" /| ║ " +'\n' +
@" &gt;\ ║ " +'\n' +
@" ║ " +'\n' +
@" ══════╩═══",
@" ╔═══╗ " +'\n' +
@" | ║ " +'\n' +
@" O ║ " +'\n' +
@" /|\ ║ " +'\n' +
@" / \ ║ " +'\n' +
@" ║ " +'\n' +
@" ══════╩═══",
@" ╔═══╗ " +'\n' +
@" | ║ " +'\n' +
@" &lt; o ║ " +'\n' +
@" |\ ║ " +'\n' +
@" / &lt; ║ " +'\n' +
@" ║ " +'\n' +
@" ══════╩═══",
@" ╔═══╗ " +'\n' +
@" | ║ " +'\n' +
@" &lt; o ║ " +'\n' +
@" |\ ║ " +'\n' +
@" / &lt; ║ " +'\n' +
@" ║ " +'\n' +
@" ══════╩═══",
@" ╔═══╗ " +'\n' +
@" | ║ " +'\n' +
@" &lt; o ║ " +'\n' +
@" |\ ║ " +'\n' +
@" / &lt; ║ " +'\n' +
@" ║ " +'\n' +
@" ══════╩═══",
@" ╔═══╗ " +'\n' +
@" | ║ " +'\n' +
@" O ║ " +'\n' +
@" /|\ ║ " + '\n' +
@" / \ ║ " + '\n' +
@" ║ " + '\n' +
@" ══════╩═══",
@" ╔═══╗ " + '\n' +
@" | ║ " + '\n' +
@" o ║ " + '\n' +
@" | ║ " + '\n' +
@" | ║ " + '\n' +
@" ║ " + '\n' +
@" ══════╩═══",
@" ╔═══╗ " + '\n' +
@" | ║ " + '\n' +
@" o ║ " + '\n' +
@" | ║ " + '\n' +
@" | ║ " + '\n' +
@" ║ " + '\n' +
@" ══════╩═══",
@" ╔═══╗ " + '\n' +
@" | ║ " + '\n' +
@" o ║ " + '\n' +
@" | ║ " + '\n' +
@" | ║ " + '\n' +
@" ║ " + '\n' +
@" ══════╩═══",
@" ╔═══╗ " + '\n' +
@" | ║ " + '\n' +
@" o ║ " + '\n' +
@" | ║ " + '\n' +
@" | ║ " + '\n' +
@" ║ " + '\n' +
@" ══════╩═══",
@" ╔═══╗ " + '\n' +
@" | ║ " + '\n' +
@" o ║ " + '\n' +
@" | ║ " + '\n' +
@" | ║ " + '\n' +
@" ║ " + '\n' +
@" ══════╩═══",
@" ╔═══╗ " + '\n' +
@" | ║ " + '\n' +
@" o ║ " + '\n' +
@" | ║ " + '\n' +
@" | ║ " + '\n' +
@" ║ " + '\n' +
@" ══════╩═══",
@" ╔═══╗ " + '\n' +
@" | ║ " + '\n' +
@" O ║ " + '\n' +
@" ║ " + '\n' +
@" | ║ " + '\n' +
@" | ║ " + '\n' +
@" ══════╩═══",
@" ╔═══╗ " + '\n' +
@" | ║ " + '\n' +
@" O ║ " + '\n' +
@" ║ " + '\n' +
@" / ║ " + '\n' +
@" \ ║ " + '\n' +
@" ══════╩═══",
@" ╔═══╗ " + '\n' +
@" | ║ " + '\n' +
@" O ║ " + '\n' +
@" ' ║ " + '\n' +
@" ║ " + '\n' +
@" |__ ║ " + '\n' +
@" ══════╩═══",
@" ╔═══╗ " + '\n' +
@" | ║ " + '\n' +
@" O ║ " + '\n' +
@" . ║ " + '\n' +
@" ║ " + '\n' +
@" \__ ║ " + '\n' +
@" ══════╩═══",
@" ╔═══╗ " + '\n' +
@" | ║ " + '\n' +
@" O ║ " + '\n' +
@" ║ " + '\n' +
@" ' ║ " + '\n' +
@" ____ ║ " + '\n' +
@" ══════╩═══",
@" ╔═══╗ " + '\n' +
@" | ║ " + '\n' +
@" O ║ " + '\n' +
@" ' ║ " + '\n' +
@" . ║ " + '\n' +
@" __ ║ " + '\n' +
@" /══════╩═══",
@" ╔═══╗ " + '\n' +
@" | ║ " + '\n' +
@" O ║ " + '\n' +
@" . ║ " + '\n' +
@" ║ " + '\n' +
@" _ ' ║ " + '\n' +
@" _/══════╩═══",
@" ╔═══╗ " + '\n' +
@" | ║ " + '\n' +
@" O ║ " + '\n' +
@" ║ " + '\n' +
@" ' ║ " + '\n' +
@" _ ║ " + '\n' +
@" __/══════╩═══",
@" ╔═══╗ " + '\n' +
@" | ║ " + '\n' +
@" O ║ " + '\n' +
@" ' ║ " + '\n' +
@" . ║ " + '\n' +
@" ║ " + '\n' +
@" __/══════╩═══",
@" ╔═══╗ " + '\n' +
@" | ║ " + '\n' +
@" O ║ " + '\n' +
@" . ║ " + '\n' +
@" ║ " + '\n' +
@" ' ║ " + '\n' +
@" __/══════╩═══",
@" ╔═══╗ " + '\n' +
@" | ║ " + '\n' +
@" O ║ " + '\n' +
@" ║ " + '\n' +
@" ' ║ " + '\n' +
@" _ ║ " + '\n' +
@" __/══════╩═══",
@" ╔═══╗ " + '\n' +
@" | ║ " + '\n' +
@" O ║ " + '\n' +
@" ' ║ " + '\n' +
@" . ║ " + '\n' +
@" ║ " + '\n' +
@" __/══════╩═══",
@" ╔═══╗ " + '\n' +
@" | ║ " + '\n' +
@" O ║ " + '\n' +
@" . ║ " + '\n' +
@" ║ " + '\n' +
@" ' ║ " + '\n' +
@" __/══════╩═══",
@" ╔═══╗ " + '\n' +
@" | ║ " + '\n' +
@" O ║ " + '\n' +
@" ║ " + '\n' +
@" ' ║ " + '\n' +
@" _ ║ " + '\n' +
@" __/══════╩═══",
@" ╔═══╗ " + '\n' +
@" | ║ " + '\n' +
@" O ║ " + '\n' +
@" ║ " + '\n' +
@" . ║ " + '\n' +
@" ║ " + '\n' +
@" __/══════╩═══",
@" ╔═══╗ " + '\n' +
@" | ║ " + '\n' +
@" O ║ " + '\n' +
@" ║ " + '\n' +
@" ║ " + '\n' +
@" ' ║ " + '\n' +
@" __/══════╩═══",
@" ╔═══╗ " + '\n' +
@" | ║ " + '\n' +
@" O ║ " + '\n' +
@" ║ " + '\n' +
@" ║ " + '\n' +
@" _ ║ " + '\n' +
@" __/══════╩═══"

            };
            static string[] RandomWords()

            {
                string currentDirectory = Directory.GetCurrentDirectory();
                string projectDirectory = Directory.GetParent(currentDirectory).Parent.Parent.FullName;

                const string WordsFileName = "words.txt";

                string path = $@"{projectDirectory}/{WordsFileName}";

                string[] words = File.ReadAllLines(path);

                return words;



            }

            string[] words = RandomWords();
            Console.CursorVisible = false ;
            while(true)
            {
              //  string word = GetRandomWords(words);

                string wordToGuess = new(Underscore, word.Length);
            }
        }
        
      
    }
}