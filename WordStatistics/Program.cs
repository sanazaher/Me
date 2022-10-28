using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;
using WordStatistics;
using static System.Net.Mime.MediaTypeNames;

class Program
{
    static void Main()
    {
        List<IWordFrequency> wordFrequencies = frequencies(20);
        List<String> strings = longestWord(10);
        Console.WriteLine("The highest occurences words");
        foreach (WordStats wordStats in wordFrequencies)
        {
          
            Console.WriteLine(wordStats.CountWord() +" "+ wordStats.Frequency());

        }
        Console.WriteLine("The longest words");
        {
            foreach (String s in strings)
             
             Console.WriteLine(s);
        }

    }
 

    private static List<IWordFrequency> frequencies(int n)
    {
       List<IWordFrequency> frequencyList = new List<IWordFrequency>();
        FetchFile file = new FetchFile();
        String s= file.fetchDoc();
        char[] chars = { ' ', ',', '?', '#', '.', ';', ':', '*', '[', ']', '{', '}', '(', ')', '"' };
        String[] words = s.Split(chars);
        var result = words.GroupBy(x => x)
        .OrderByDescending(y => y.Count())
        .Select(z => new
        {
            str = z.Key,
            count = z.Count()
        })
      .ToList();
       
            foreach (var test in result)
        {
            if (frequencyList.Count < n)
            {
                frequencyList.Add(new WordStats(test.str, test.count));
            }
        }

        return frequencyList;
    }

    private static List<String> longestWord(int n)
{
        var longWord = new List<String>();
        FetchFile file = new FetchFile();
        String s = file.fetchDoc();
       
        char[] chars = { ' ', ',', '?', '#', '.', ';', ':', '*', '[', ']', '{', '}', '(', ')', '"','/','-'};

        String[] words = s.Split(chars);

        var wordsLength = words.Select(x => x.Length).OrderByDescending(x => x)
             .Distinct().ToList();

        
        
       
        foreach(var word in wordsLength)
        { 
            if(longWord.Count<n)
            longWord.Add(word.ToString());
        }


        return longWord;


    }


}





