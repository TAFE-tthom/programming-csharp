# LoadInfo

You are tasked with writing a program that will read until the end of a file.
The file itself will be in a comma separated format.
Use the example from the session scraps channels to get up to speed with reading a csv and splitting values.

Each line will contain information related to an Employee.

The first line outlines the properties and should be ignored when constructing an employee.

Example of the file:

```
FirstName,LastName,EmployeeId,Age,Occupation
Jeff,Jeffington,1223,43,Engineer
David,Davidson,99,24,Support
Jake,Jakobson,54,55,Architect
```

Your program should detect how many employees are contained within the file and attempt to load each one into an Employee class and add them to an array of type Employee.
