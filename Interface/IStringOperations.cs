
using System.Collections.Generic;

namespace CommBankCoding.Interface
{
    interface IStringOperations
    {
        double AverageWordsLength(string str, string[] keyValues);
        List<string> CountofWordsStartingWith(string str, string[] startingstr, string[] innerValue);
        int LongestLengthWord(string str, string[] keyValues);
        int CountSequenceofWords(string str, string[] firstWordChar, string[] followingWordChar);
    }
}
