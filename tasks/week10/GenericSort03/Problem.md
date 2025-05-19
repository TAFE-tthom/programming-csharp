# Generic Sort

You have been tasked with writing a generic sorting algorithm that will need to
utilise an interface called `IOrderable`. The interface `IOrderable` must outline
a method called `int Compare<T>(T a, T b)`, which will return 0 if they are the
same, 1 if A > B, -1 if B > A.

You will then need to provide a definition for the following method:

```
public static void Sort<T>(T[] array, IOrderable<T> comparator)
```

The `Sort` method will implement a sorting method that will use the `comparator`
object and leverage the `Compare` method to sort objects of type `T`. Since `T`
will be provided on use, the implementation of `Compare` will be done on a
case-by-case basis.

## How to test

You can test your implementation against a set of test cases
using `dotnet test`.
