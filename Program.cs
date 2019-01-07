using CommBankCoding.Implementation;
using CommBankCoding.Interface;
using System;
using System.Collections.Generic;

namespace CommBankCoding
{
    class Program
    {
        static void Main(string[] args)
        {
            IStringOperations stringObj = new StringOperations();
            IIOOperations ioObj = new IOOperations();
            //Requirement 1
            try
            {
                Console.WriteLine("Enter string to count the average length of words strating with a or A");
                string stringForAvg = Console.ReadLine();
                if (!string.IsNullOrEmpty(stringForAvg))
                {
                    double avg = stringObj.AverageWordsLength(stringForAvg, new string[] { "a", "A" });
                    ioObj.WriteToTextFile(new List<string> {
                                                                "Input string:" + stringForAvg,
                                                                "",
                                                                "Average:"+ avg.ToString()
                                                            }, "average_length_of_words_starting_with_a.txt");
                    Console.WriteLine("Result has been saved in average_length_of_words_starting_with_a.txt file");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Average Block:" + ex.Message);
            }
            Console.ReadLine();
            //Requirement 2
            try
            {
                Console.WriteLine("Enter string to words starting with b or B and containing e or E");
                string stringForWords = Console.ReadLine();
                if (!string.IsNullOrEmpty(stringForWords))
                {
                    List<string> value = stringObj.CountofWordsStartingWith(stringForWords, new string[] { "b", "B" }, new string[] { "e", "E" });
                    ioObj.WriteToTextFile(value, "count_of_e_in_words_starting_with_b.txt");
                    Console.WriteLine("Result has been saved in count_of_e_in_words_starting_with_b.txt file");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Finding e in words:" + ex.Message);
            }            
            Console.ReadLine();
            //Requirement 3
            try
            {
                Console.WriteLine("Enter string to find longest word starting with a or b or c");
                string stringForLongestWord = Console.ReadLine();
                if (!string.IsNullOrEmpty(stringForLongestWord))
                {
                    int longest = stringObj.LongestLengthWord(stringForLongestWord, new string[] { "a", "b", "c" });
                    ioObj.WriteToTextFile(new List<string> { longest.ToString() }, "longest_words_starting_with_abc.txt");
                    Console.WriteLine("Result has been saved in longest_words_starting_with_abc.txt file");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Longest word block:" + ex.Message);
            }
            Console.ReadLine();
            //Requirement 4
            try
            {
                Console.WriteLine("Enter string to find sequence starting with c or C and following word starting with a or A");
                string stringForWordSequence = Console.ReadLine();
                if (!string.IsNullOrEmpty(stringForWordSequence))
                {
                    int sequence = stringObj.CountSequenceofWords(stringForWordSequence, new string[] { "c", "C" }, new string[] { "a", "A" });
                    ioObj.WriteToTextFile(new List<string> { sequence.ToString() }, "count_of_sequence_of_words_starting_withs_c_and_a.txt");
                    Console.WriteLine("Result has been saved in count_of_sequence_of_words_starting_withs_c_and_a.txt file");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Sequence of words block:" + ex.Message);
            }
            Console.Read();

        }
    }
}
