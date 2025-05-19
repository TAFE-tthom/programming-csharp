namespace WordCount.Test;

public class WordCountTest
{
    [Fact]
    public void WordCount_Construct_Test()
    {
        WordCount wc = new WordCount("");

        Assert.NotNull(wc);

    }

    [Fact]
    public void WordCount_EmptyCounts_1()
    {
        WordCount wc = new WordCount("");

        Assert.Equal(0, wc.Characters());

    }


    [Fact]
    public void WordCount_EmptyCounts_2()
    {
        WordCount wc = new WordCount("");

        Assert.Equal(0, wc.Lines());

    }

    [Fact]
    public void WordCount_EmptyCounts_3()
    {
        WordCount wc = new WordCount("");

        Assert.Equal(0, wc.Words());

    }

    [Fact]
    public void WordCount_EmptyCounts_4()
    {
        WordCount wc = new WordCount("");

        Assert.Equal((0, 0, 0), wc.All());

    }

    [Fact]
    public void WordCount_Check_1()
    {
        WordCount wc = new WordCount("test1.txt");

        Assert.Equal(81, wc.Characters());

    }


    [Fact]
    public void WordCount_Check_2()
    {
        WordCount wc = new WordCount("test1.txt");

        Assert.Equal(6, wc.Lines());

    }

    [Fact]
    public void WordCount_Check_3()
    {
        WordCount wc = new WordCount("test1.txt");

        Assert.Equal(12, wc.Words());

    }

    [Fact]
    public void WordCount_Check_4()
    {
        WordCount wc = new WordCount("test1.txt");

        Assert.Equal((12, 81, 6), wc.All());

    }
}
