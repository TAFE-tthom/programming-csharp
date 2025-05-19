namespace SequenceGen.Test;

public class UnitTest1
{
    [Fact]
    public void Sequence_Construct_1()
    {
        SequenceGen gen = new SequenceGen(0);

        Assert.NotNull(gen);
        Assert.Equal(0, gen.Current());
        Assert.False(gen.Finished());

    }

    [Fact]
    public void Sequence_Construct_2()
    {
        SequenceGen gen = new SequenceGen(1, 1);

        Assert.NotNull(gen);
        Assert.Equal(1, gen.Current());
        Assert.False(gen.Finished());

    }

    [Fact]
    public void Sequence_Construct_3()
    {
        SequenceGen gen = new SequenceGen(10, 2, 20);

        Assert.NotNull(gen);
        Assert.Equal(10, gen.Current());
        Assert.False(gen.Finished());

    }

    [Fact]
    public void Sequence_One_Arg_1()
    {
        SequenceGen gen = new SequenceGen(1);

        Assert.NotNull(gen);
        Assert.Equal(1, gen.Current());
        Assert.Equal(1, gen.Next());
        Assert.Equal(2, gen.Next());
        Assert.Equal(3, gen.Next());
        Assert.Equal(4, gen.Next());

    }

    [Fact]
    public void Sequence_One_Arg_2()
    {
        SequenceGen gen = new SequenceGen(1);

        Assert.NotNull(gen);
        Assert.Equal(1, gen.Current());
        Assert.Equal(1, gen.Next());
        Assert.Equal(2, gen.Current());
        Assert.Equal(2, gen.Next());
        Assert.Equal(3, gen.Current());
        Assert.Equal(3, gen.Next());
        Assert.Equal(4, gen.Current());
        Assert.Equal(4, gen.Next());

    }

    [Fact]
    public void Sequence_Two_Arg_1()
    {
        SequenceGen gen = new SequenceGen(12, 2);

        Assert.NotNull(gen);
        Assert.Equal(12, gen.Current());
        Assert.Equal(12, gen.Next());
        Assert.Equal(14, gen.Next());
        Assert.Equal(16, gen.Next());
        Assert.Equal(18, gen.Next());


    }

    [Fact]
    public void Sequence_Two_Arg_2()
    {
        SequenceGen gen = new SequenceGen(1, 2);

        Assert.NotNull(gen);
        Assert.Equal(1, gen.Current());
        Assert.Equal(1, gen.Next());
        Assert.Equal(3, gen.Current());
        Assert.Equal(3, gen.Next());
        Assert.Equal(5, gen.Current());
        Assert.Equal(5, gen.Next());
        Assert.Equal(7, gen.Current());
        Assert.Equal(7, gen.Next());

    }

    [Fact]
    public void Sequence_Three_Arg_1()
    {
        SequenceGen gen = new SequenceGen(10, 5, 30);

        Assert.NotNull(gen);
        Assert.Equal(10, gen.Current());
        Assert.Equal(10, gen.Next());
        Assert.Equal(15, gen.Next());
        Assert.Equal(20, gen.Next());
        Assert.Equal(25, gen.Next());
        Assert.Equal(30, gen.Next());


    }

    [Fact]
    public void Sequence_Three_Arg_3_Finished()
    {
        SequenceGen gen = new SequenceGen(10, 5, 30);

        Assert.NotNull(gen);
        Assert.Equal(10, gen.Current());
        Assert.Equal(10, gen.Next());
        Assert.Equal(15, gen.Next());
        Assert.Equal(20, gen.Next());
        Assert.Equal(25, gen.Next());
        Assert.Equal(30, gen.Next());
        Assert.True(gen.Finished());


    }

    [Fact]
    public void Sequence_Three_Arg_2_Throws_Exception()
    {
        SequenceGen gen = new SequenceGen(10, 5, 30);

        Assert.NotNull(gen);
        Assert.Equal(10, gen.Current());
        Assert.Equal(10, gen.Next());
        Assert.Equal(15, gen.Next());
        Assert.Equal(20, gen.Next());
        Assert.Equal(25, gen.Next());
        Action act = () => gen.Next();
        Assert.Throws<SequenceGeneratorFinished>(act);


    }
}
