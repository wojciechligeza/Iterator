using System.Collections.Generic;
using Iterator.Iterator;

namespace Iterator.Aggregate
{
    // KONKRETNY AGREGAT
    public class NewsWeek : INewspaper
    {        
        private List<string> _reporters;
        public NewsWeek()
        {
            _reporters = new List<string>
            {
                "Jacek Wróbel - NewsWeek",
                "Andrzej Półprzytomny - NewsWeek"
            };            
        }

        public IIterator CreateIterator()
        {
            return new NewsWeekIterator(_reporters); 
        }
    }
}
