namespace Contains.Test;

public class ContainsTest
{
    
    [Fact]
	public void testContainsNull() {
		Assert.Equal(false, Checker.Contains(null, 1));
		
	}

    [Fact]
	public void testContainsOne() {
		Assert.Equal(true, Checker.Contains(new int[] {1}, 1));
		
	}
	
    [Fact]
	public void testNotContainsOne() {
		Assert.Equal(false, Checker.Contains(new int[] {1}, 2));
        
		
	}
	
    [Fact]
	public void testContainsDup() {
		Assert.Equal(true, Checker.Contains(new int[] {1, 2, 3, 4, 1, 2}, 2));
		
	}
	
    [Fact]
	public void testContainsVariable() {
		Assert.Equal(true, Checker.Contains(new int[] {3,54,21,34,76,23,5,213,8,2,3,98,23,1,5}, 5));
        
		
	}}
