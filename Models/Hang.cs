using System.Collections.Generic;
using System;
using System.Text;

namespace Hang.Models
{
    public class Hangman
    {
        private static string _word;
        private static bool[] _chosen = new bool[26];

        public string GetWord()
        {
            return _word;
        }

        public static void SetWord(string newWord)
        {
            _word = newWord;
            for (int i = 0; i < 26; i++)
            {
                _chosen[i] = false;
            }
        }

        public static void Guess(string newLetter)
        {
            char newLet = newLetter[0];
            int index = (int)Char.GetNumericValue(newLet);
            Console.WriteLine (index);
            Console.WriteLine (newLet);
            Console.WriteLine (newLetter);
            if (index >= 0 && index <= 25)
            {
                _chosen[index] = true;
            }
        }

        public static int NumMiss()
        {
            int misses = 0;
            for (int i = 0; i < 26; i++)
            {
                if (_chosen[i])
                {
                    bool miss = true;
                    for (int j = 0; j < _word.Length; j++)
                    {
                        if ((char.ToUpper(_word[j]) - 65)==i)
                        {
                            miss = false;
                        }
                    }
                    if (miss)
                    {
                        misses++;
                    }
                }
            }
            return misses;

        }

        public static string ListMisses()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            for (int i = 0; i < 26; i++)
            {
                if (_chosen[i])
                {
                    bool miss = true;
                    int k = 0;
                    for (int j = 0; j < _word.Length; j++)
                    {
                        if ((char.ToUpper(_word[j]) - 65)==i)
                        {
                            miss = false;
                            k = j;
                        }
                    }
                    if (miss)
                    {
                        sb.Append(_word[k]);
                    }
                }
            }
            return sb.ToString();
        }

        public static string HitLetters()
        {
            Console.WriteLine("1");
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            Console.WriteLine(sb);
            for (int j = 0; j < _word.Length; j++)
            {
                if (_chosen[char.ToUpper(_word[j]) - 65])
                {
                    sb.Append(_word[j]);
                } else
                {
                    sb.Append("_");
                }
            }
            return sb.ToString();
        }
    }
}
