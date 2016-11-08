using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ymnik
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            string output = "";
            PhraseGenerator stupidBot = new PhraseGenerator();
            output = stupidBot.Talk(input);
        }
    }
}
