using Iterator.Aggregate;
using Iterator.Iterator;
using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            INewspaper doRzeczy = new DoRzeczy();
            INewspaper newsWeek = new NewsWeek();

            IIterator doRzeczyIterator = doRzeczy.CreateIterator();
            IIterator newsWeekIterator = newsWeek.CreateIterator();

            Console.WriteLine("-------- DORZECZY --------");
            PrintReporters(doRzeczyIterator);

            Console.WriteLine("-------- NEWSWEEK --------");
            PrintReporters(newsWeekIterator);

            Console.ReadKey();
        }

        static void PrintReporters(IIterator iterator)
        {
            iterator.First();

            while(!iterator.IsDone())
            {
                Console.WriteLine(iterator.Next());
            }
        }
    }
}
