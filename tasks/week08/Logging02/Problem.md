# Logging

You are tasked with constructing a class that will record the inputted lines
to a file and also return the line similarly to `Console.ReadLine`.

The class `Logging` will need to implement the following:

* `Logging(string path)` - Provides a path string for a file to be loaded by the object

* `string ReadLine()` - Logs a string to a file constructed within the constructor. A line
    will be logged and the string will be returned. Use `Console.Readline()` within this method.


## How to test

You can test your implementation using `dotnet test`.
