using System.Collections.Generic;
using System.Linq;

namespace Iterator.Iterator
{
    // KONKRETNY ITERATOR
    public class NewsWeekIterator : IIterator
    {
        private readonly List<string> _reporters;
        private int _current;

        public NewsWeekIterator(List<string> reporters)
        {
            _reporters = reporters;
            _current = 0;
        }

        public string CurrentItem()
        {
            return _reporters.ElementAt(_current);
        }

        public void First()
        {
            _current = 0;
        }

        public bool IsDone()
        {
            return _current >= _reporters.Count;
        }

        public string Next()
        {
            return _reporters.ElementAt(_current++);
        }
    }
}
