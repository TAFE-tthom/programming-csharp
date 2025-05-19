namespace ArrayTracker;

public class ArrayTracker<T>
{

    public int Index { get; private set; }


    private T[] arrayRef;


    public ArrayTracker(T[] array) {
        arrayRef = array;
        Index = 0;

    }

    public T[] Collection() {
        return arrayRef;
    }

    public bool HasValue()
    {
        return Index < arrayRef.Count();
    }


    public T? Next()
    {
        if(Index >= arrayRef.Count()) {
            return default(T);
        } else {
            T v = arrayRef[Index];
            Index++;

            return v;
        }
    }


}
