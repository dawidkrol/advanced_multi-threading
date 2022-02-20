using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advanced_multi_threading.PLINQ
{
    //struct PLINQtraining
    //{
    //    int index;
    //    string word;
    //}
    public class PLINQTraining
    {
        ThreadLocal<Random> random;
        string[] wordlLookup;
        HashSet<string> wordLookupForSearch;
        string[] text;
        public PLINQTraining(int number_of_words)
        {
            random = new ThreadLocal<Random>(() => new Random(Guid.NewGuid().GetHashCode()));
            wordlLookup = File.ReadAllLines("../../../PLINQ/WordLookup.txt");
            Prepering(number_of_words);
        }

        void Prepering(int number_of_words)
        {
            var e = Enumerable.Range(0, number_of_words);

            text = e
                .AsParallel()
                .Select(x => wordlLookup[random.Value.Next(0, wordlLookup.Length - 1)])
                .ToArray();

            text[20] = "Error";
            text[420] = "Error2";
            text[1000] = "Error3";

            wordLookupForSearch = wordlLookup.ToHashSet();
        }

        public void CheckingWordParallel()
        {

            var start = DateTime.Now;
            var errors = text
                .AsParallel()
                .Where(x => !wordLookupForSearch.Contains(x));

            foreach (var error in errors)
            {
                //Console.WriteLine($"{error}");
            }
            var stop = DateTime.Now;

            Console.WriteLine($"PLINQ: {stop - start}");
        }
        public void CheckingWord()
        {
            var start = DateTime.Now;
            var errors = text
                .Where(x => !wordLookupForSearch.Contains(x));

            foreach (var error in errors)
            {
                //Console.WriteLine($"{error}");
            }
            var stop = DateTime.Now;

            Console.WriteLine($"LINQ: {stop - start}");
        }
    }
}
