# Sequence

You are tasked with writing a sequence generator object.
This class will require the use of constructor overloading, as it will
support 3 different constructors. Along with 3 methods associated.

* `SequenceGen(int start)` - Creates a SequenceGen object with a starting
    integer, the step will be set to 1 and is implied to never end.

* `SequenceGen(int start, int step)` - Creates a SequenceGen object with
    a starting integer and integer step. It is implied to never end.

* `SequenceGen(int start, int step, int end)` - Creates a SequenceGen object
    with a starting integer, integer step and end. The end integer is
    implied to provide a stop.

* `int Current()` - Returns the integer that the generator is at.

* `bool Finished()` - Outlines if the generator is finished, if
    an end was not specified, the method will return false, otherwise
    if the current number exceeds the `end` value.

* `int Next()` - Returns the current integer and moves to the next
    integer based on `step`. 


You may assume that the sequence only handles positive integers and that
the step integer is greater than 0 and end is greater than start.

## How to test

You can test your solution against your implemented class by calling
`dotnet test`.
