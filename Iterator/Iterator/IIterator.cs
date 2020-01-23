namespace Iterator.Iterator
{
    // ITERATOR
    public interface IIterator
    {
        void First();           //  Ustaw aktualny element jako pierwszy w kolekcji
        string Next();          //  Przesuń aktualny element do następnej pozycji w kolekcji
        bool IsDone();          //  Sprawdź czy koniec kolekcji
        string CurrentItem();   //  Zwróć aktualny element
    }
}
