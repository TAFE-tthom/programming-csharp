namespace ArraySnip.Test;

public class ArraySnipTest
{
    [Fact]
    public void ArraySnip_Construct()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        ArrayCutter snipNumbers = new ArrayCutter(numbers);

        Assert.NotNull(snipNumbers);
    }

    [Fact]
    public void ArraySnip_InvalidCutArgument()
    {
        int[] numbers = { 1, 2, 3 };

        ArrayCutter snipNumbers = new ArrayCutter(numbers);



        int[][] result = snipNumbers.Cut(0);

        Assert.Null(result);


    }

    [Fact]
    public void ArraySnip_ArrayMoreCutsThanElements()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        ArrayCutter snipNumbers = new ArrayCutter(numbers);


        int[][] answer = {
            new int[] { 1 },
            new int[] { 2 },
            new int[] { 3 },
            new int[] { 4 },
            new int[] { 5 },
            new int[] { 6 },
            new int[] { 7 },
            new int[] { 8 },
            new int[] { 9 },
            new int[] { 10 },
        };

        int[][] result = snipNumbers.Cut(13);

        Assert.Equal(answer, result);


    }


    [Fact]
    public void ArraySnip_EmptyArray()
    {
        int[] numbers = { };

        ArrayCutter snipNumbers = new ArrayCutter(numbers);


        int[][] answer = {  };

        int[][] result = snipNumbers.Cut(1);

        Assert.Equal(answer, result);


    }

    [Fact]
    public void ArraySnip_Normal_1()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        ArrayCutter snipNumbers = new ArrayCutter(numbers);


        int[][] answer = { new int[] { 1, 2, 3, 4, 5 }, new int[] {6, 7, 8, 9, 10 } };

        int[][] result = snipNumbers.Cut(2);

        Assert.Equal(answer, result);


    }

    [Fact]
    public void ArraySnip_Normal_2()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };

        ArrayCutter snipNumbers = new ArrayCutter(numbers);


        int[][] answer = {
            new int[] { 1, 2 },
            new int[] { 3, 4 },
            new int[] { 5, 6 },
            new int[] { 7, 8 },
        };

        int[][] result = snipNumbers.Cut(4);

        Assert.Equal(answer, result);


    }

    [Fact]
    public void ArraySnip_Normal_3_WithRemainder()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        ArrayCutter snipNumbers = new ArrayCutter(numbers);


        int[][] answer = {
            new int[] { 1, 2, 3 },
            new int[] { 4, 5, 6 },
            new int[] { 7, 8 },
            new int[] { 9, 10 },
        };

        int[][] result = snipNumbers.Cut(4);

        Assert.Equal(answer, result);


    }
}
