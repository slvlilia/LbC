
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string word1 = "караловий";
        string word2 = "помаранчевий";

        var letters1 = new HashSet<char>(word1);
        var letters2 = new HashSet<char>(word2);

        var uniqueLetters = letters1.Except(letters2).Concat(letters2.Except(letters1));

        var counts = new Dictionary<char, int>();
        foreach (var letter in uniqueLetters)
        {
            counts[letter] = word1.Count(c => c == letter) + word2.Count(c => c == letter);
        }

        var result = counts.Where(pair => pair.Value == 1).Select(pair => pair.Key);

        foreach (var letter in result)
        {
            Console.Write(letter + " ");
        }
    }
}
