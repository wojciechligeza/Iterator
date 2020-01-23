using Iterator.Iterator;

namespace Iterator.Aggregate
{
    // KONKRETNY AGREGAT
    public class DoRzeczy : INewspaper
    {        
        private string[] _reporters;
        public DoRzeczy()
        {
            _reporters = new[]
            {
                "Janusz Nowak - DoRzeczy",
                "Grażyna Kowalska - DoRzeczy"
            };
        }

        public IIterator CreateIterator()
        {
            return new DoRzeczyIterator(_reporters);
        }
    }
}
