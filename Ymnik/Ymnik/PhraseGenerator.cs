using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Ymnik
{
    internal class PhraseGenerator
    {
        private ArrayList dictionary;

        public PhraseGenerator()
        {
            dictionary = new ArrayList();
            loadDict();
        }

        public string Talk(string input)
        {
            var phrase = PickClosesPhrase(input);
            return phrase;
        }

        private string PickClosesPhrase(string input)
        {
            /**/
            Random phraseLenght = new Random();
            String[] phrases = GenerateRandomPhrases(phraseLenght.Next(0, 20), 1000);/*пока константы, гугл не всегда может съесть дохрена фраз*/
        }

        private string[] GenerateRandomPhrases(int wordsCount, int countOfPhrases)
        {
            Random rndWord = new Random();
            HashSet<string> phrases = new HashSet<string>();
            for (int i = 0; i < 1000; i++)
            {
                string generatingPhrase = "";
                for (int j = 0; j < wordsCount; j++)
                {
                    generatingPhrase += dictionary[rndWord.Next(0, dictionary.Count)];
                }
            }
        }
    }
}