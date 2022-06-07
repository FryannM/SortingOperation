using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static List<string> sortingOperations(int N, List<string> aWords)
    {
        string temp = string.Empty;
        List<string> result = new List<string>();
        aWords = aWords.Take(N).ToList();
        foreach (string word in aWords)
        {
            var orderedWord = word
                .GroupBy(x => x)
                .OrderByDescending(x => x.Count())
                .ThenBy(x => x.Key)
                .SelectMany(x => x).ToList();

            foreach (var itemWord in orderedWord)
            {
                temp += itemWord;
                Console.Write(itemWord + " ");
            }

            Console.WriteLine();
            result.Add(temp);
            temp = string.Empty;
            
        }
        Console.Read();
        return result;
    }

    public static void Main()
    {

        sortingOperations(17, new List<string>()
        {
            //2
            "abaccadcc",
            "xyzxy",
            //10
            "dulgvgzwqg",
            "gxtjtmtywr",
            "hnlnxiupgt",
            "gzjotckivp",
            "dpwwsdptae",
            "pcscpilknb",
            "btvyhhmflf",
            "artrtnqxcr",
            "nrtcmcoadn",
            "fkdsgnekft",
            //5
            "wzenwebuau",
            "vokfxzynwl",
            "neldfeyrxk",
            "wqadfiodgs",
            "ykiuvzfcbc"
        });

    }
}