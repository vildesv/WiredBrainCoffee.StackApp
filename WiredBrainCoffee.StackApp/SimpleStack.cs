namespace WiredBrainCoffee.StackApp
{
    public class SimpleStack<T>  // T or TypePlaceholder is a so-called generic type parameter 
    {
        private T[] _items;
        private int _currentIndex = -1;

        public SimpleStack() => _items = new T[10];        // => - expression body for the constuctor (without curly breackets)

        public int Count => _currentIndex + 1;

        public void Push(T item) => _items[++_currentIndex] = item;
        //  { _currentIndex += 1; _items[++_currentIndex] = item; }
    
        public T Pop() => _items[_currentIndex--];
    }
}