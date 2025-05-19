# Construction Site

We start looking into patterns and being a little creative with our classes.
This task will also test your understanding of the `this` keyword beyond
resolving ambiguity in a constructor.

You are tasked with implementing a class called `HouseSite`, a `HouseSite` class
will have the following fields and methods.

* `bool Built()` - represents if the `HouseSite` is built or not
    You will need to check if:
        * 4 Walls
        * Roof
        * Carpet

* `HouseSite SupplyRoof(Roof roof)` - provides a roof object to the housesite
    to be built with.

* `HouseSite SupplyWall(Wall wall)` - provides a wall object to the housesite, if
    there are 4 or more walls supplied, this will meet part of the criteria necessary
    for a house to be built.

* `HouseSite SupplyCarpet(Carpet c)` - provides Carpet for the housesite, only a single
    kind of carpet is to be used.


* `House? Build()` - Returns a `House` object, make sure all of the required objects
    have been supplied to build a house.


## Why do some of the methods return `HouseSite`?

In short, you are being introduced to a design pattern that is fairly common
in a lot of software. It is best to consider how things can be ordered
with these methods as well as chained.

There is a convenience to constructing objects this way instead of
constructer overloading. Implement the methods and outline
your observation.

## How to test your code?

As with previous challenges, use the `dotnet test` command to test your class
implementation against the tests given.
