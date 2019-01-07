using CommBankCoding.Interface;
using CommBankCodingTest.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CommBankCoding.Implementation
{
    public class StringOperations : IStringOperations
    {
        public double AverageWordsLength(string str, string[] keyValues)
        {
            List<string> words = new List<string>();
            double Average = 0;
            words = GetWordsStartingWith(str, keyValues);
            if(!words.IsBlank()) Average= words.Average(x => x.Length);
            return Average;
        }

        public List<string> CountofWordsStartingWith(string str, string[] startingKeys, string[] innerkeyvalue)
        {
            List<string> words = new List<string>();
            words = GetWordsStartingWith(str, startingKeys, innerkeyvalue);
            return words;
        }

        public int LongestLengthWord(string str, string[] keyValues)
        {
            List<string> words = new List<string>();
            words = GetWordsStartingWith(str, keyValues);
            int longestWord = words.Max(x => x.Length);
            return longestWord;
        }

        public int CountSequenceofWords(string str, string[] firstWordChar, string[] followingWordChar)
        {
            string[] words = str.Split(' ');
            int counter = 0;
            List<string> wordsStartingWithFirstChar = new List<string>();
            wordsStartingWithFirstChar = GetWordsStartingWith(str, firstWordChar);
            foreach (var word in wordsStartingWithFirstChar)
            {
                if (words[words.Length - 1] != word)
                {
                    string position = words[(Array.FindIndex(words, row => row.Contains(word))) + 1];
                    if (followingWordChar.Any(x => position.StartsWith(x)))
                        counter++;
                }
            }
            return counter;
        }

        private List<string> GetWordsStartingWith(string str, string[] keyValues,string[] innerValues = null)
        {
            if (String.IsNullOrEmpty(str))
                throw new ArgumentException("The string to find should not be empty");
            if (keyValues.IsBlank())
                throw new ArgumentException("Key values should not be blank");

            List<string> words = str.Split(' ').ToList();
            List<string> startIndexes = new List<string>();

            foreach (string character in keyValues)
                startIndexes.AddRange(words.Where(val => val.IndexOf(character) == 0).ToList());
            if(!innerValues.IsBlank())
            {
                foreach (string innerValue in innerValues)
                    startIndexes.RemoveAll(x => x.IndexOf(innerValue, StringComparison.OrdinalIgnoreCase) < 0);
            }
            return startIndexes;
        }
    }
}
