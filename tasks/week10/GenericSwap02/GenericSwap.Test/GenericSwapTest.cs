namespace GenericSwap.Test;

public class GenericSwapTest
{
    [Fact]
    public void GenericSwap_Test_1()
    {
	int[] nums1 = { 1, 2, 3, 4, 5 };
	int[] nums2 = { 5, 4, 3, 2, 1 };
	
	GenericSwap.Swap<int>(nums1, nums2);

	int[] res2 = { 1, 2, 3, 4, 5 };
	int[] res1 = { 5, 4, 3, 2, 1 };



	Assert.Equal(res1, nums1);
	Assert.Equal(res2, nums2);

    }
    
    [Fact]
    public void GenericSwap_Test_2()
    {
	int[] nums1 = { 1, 2, 3, 4, 5 };
	int[] nums2 = { 5, 4, 3 };
	
	GenericSwap.Swap<int>(nums1, nums2);

	int[] res1 = { 1, 2, 3, 4, 5 };
	int[] res2 = { 5, 4, 3 };

	Assert.Equal(res1, nums1);
	Assert.Equal(res2, nums2);

    }

    [Fact]
    public void GenericSwap_Test_3()
    {
	string[] words1 = { "1", "2", "3", "4", "5" };
	string[] words2 = { "5", "4", "3", "2", "1" };
	
	GenericSwap.Swap<string>(words1, words2);

	string[] res2 = { "1", "2", "3", "4", "5" };
	string[] res1 = { "5", "4", "3", "2", "1" };

	Assert.Equal(res1, words1);
	Assert.Equal(res2, words2);

    }



}
