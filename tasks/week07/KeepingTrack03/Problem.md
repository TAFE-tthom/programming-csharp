# Array Tracker

You have been tasked with creating an array that will keep track of
the current element in the array. You will need to implement the following
methods and properties with this class.

* `int Index` - Property that will have a public get but private set
* `ArrayTracker(T[] array)` - Constructor that accepts an array of T type (generics)
* `T[] Collection()` - Returns the array that is held by ArrayTracker
* `bool HasValue()` - If the Index is currently less than the size of the array, it will return true
    otherwise false

* `T? Next()` - Returns the next elements in the array, if the element is available, it will
    return the element to the caller, otherwise it will return null or `default(T)`.

The main idea of this task is create what is known as an `Iterator`, it is a simple object
that maintains the current state information when iterating through the array.

## How to test

You can test your implementation against the set of unit tests included. Use the
`dotnet test` command to execute these test cases.
