public class SimpleStack<T>
{
    private List<T> item = new List<T>();

    public void Push(T item)
    {
        this.item.Add(item);
    }

    public T Pop()
    {
        T lastItem = item[item.Count - 1];
        item.RemoveAt(item.Count - 1);
        return lastItem;

        
    }

    public T Peek()
    {
        return item[item.Count - 1];
    }

    public int Count
    {
        get

        {
            return item.Count;
        }

    }
}
