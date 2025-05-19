# Word Count

You are tasked with writing a class called `WordCount` that will count.

* Number of words in a file
* Number of lines in a file
* Number of characters in a file

A file path string will be provided to the constructor and will be
used to load the file. Your class will need to implement the following methods:


* `WordCount(string path)` - Constructor for the class, creates the file
    using the path string.

* `bool Ready()` - true, if the file can be opened, false if the
    file does not exist or can't be opened.

* `int Words()` -> Returns the number of words within the file

* `int Characters()` -> Returns the number of characters in the file.

* `int Lines()` -> Returns the number of lines in the file.

* `(int, int, int) All()` -> Returns a tuple that contains the counts for:
    Words, Characters, Lines


## How to test?

Run `dotnet test` to execute the unit tests against your class. Alternatively
you can create your own console application that will load a file with your
class and return the relevant information when executing it.
