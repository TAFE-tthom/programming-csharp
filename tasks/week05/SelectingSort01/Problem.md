You are tasked with writing a method which will sort an List of strings A based on the ranks provided in another List of Integer B using the selection sort algorithm. 

The method takes two List A and B of the same length as arguments and returns an List of Strings C containing all elements in A. Furthermore, the elements in C are ordered based on the ranks specified in B.

List A contains all Strings that need to be sorted. 

List B contains the ranks of each elements in A. Each rank is an Integer ranging from 1 to L where L is the length of A or B.

Example:
```
Input:
ArrayList A: ["One", "Three", "Five", "Nine", "Eight", "Two", "Four", "Seven", "Six"]
ArrayList B: [1, 3, 5, 9, 8, 2, 4, 7, 6]
Output:
ArrayList C: ["One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine"]

```

The method signature has been written for you. You will just need to program for this method and we will handle the rest. Please don't change the method signature. Otherwise, you may not be able to pass the tests.

Selecting sort works as followed:

If the length of the array you want to sort is n. You will need to iterate through the array n times. Each time, you will pick the smallest element and put it into the resulting array.

Example:
````
We have an input array [2,9,7,4,6]

In each iteration, we will select the smallest element in the array and put it into the resulting array.

Initially: the output array is [] (empty)

Step1: After iterating through the array, 2 is found as the smallest number in the array. 2 is put into the output array. ([2])

Step2: 4 is the second smallest number in the array. 4 is put into the output array.( [2, 4])

Step3: 6 is the third smallest. 6 is put into the output array. ([2, 4, 6])

Step4: 7 is the fourth smallest. 7 is put into the output array. ([2, 4, 6, 7])

Final step: 9 is the only element remaining. 9 is put into the output array. ([2, 4, 6, 7, 9])
```


Your method should return null if the sizes of the two ArrayLists differ or if either of the two ArrayLists are null.
