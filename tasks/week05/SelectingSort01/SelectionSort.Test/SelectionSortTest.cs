namespace SelectionSort.Test;

public class SelectionSort_TestSet
{
    [Fact]
    public void SampleTest()
    {
        string[] arr = {"One", "Three", "Five", "Nine", "Eight", "Two", "Four", "Seven", "Six"};
		int[] arr2 = {1, 3, 5, 9, 8, 2, 4, 7, 6};
		string[] arr3 = {"One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine"};
		List<String> input = new List<String>(arr.ToList()); 
		List<Integer> ranks = new List<Integer>(arr2.ToList());
		List<String> result = SelectionSort.SelectingSort(input, ranks);
		List<String> expected = new List<String>(arr3.ToList());
		Assert.Equals(expected, result);
    }
    [Fact]
    public void DifferentSizesTest()
    {
        string[] arr = {"One", "Three", "Five", "Nine", "Eight", "Two", "Four", "Seven", "Six"};
        int[] arr2 = {1, 3, 5, 9, 8, 2, 4, 7, 6};
		string[] arr3 = {"One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine"};
		List<String> input = new List<String>(arr.ToList()); 
		List<Integer> ranks = new List<Integer>(arr2.ToList());
		List<String> result = SelectionSort.SelectingSort(input, ranks);
		List<String> expected = new List<String>(arr3.ToList());
		Assert.Equals(expected, result);
        Assert.NotNull(result)
    }
}
