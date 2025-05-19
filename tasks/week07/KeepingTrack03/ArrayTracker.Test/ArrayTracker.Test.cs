namespace ArrayTracker.Test;

public class UnitTest1
{
    [Fact]
    public void ArrayTracker_Construct()
    {
        int[] array = { 1, 2, 3, 4, 5 };
        ArrayTracker<int> tracker = new ArrayTracker<int>(array);

        Assert.NotNull(tracker.Collection());

        Assert.Equal(tracker.Index, 0);


    }

    [Fact]
    public void ArrayTracker_ArrayEmpty()
    {
        int[] array = {};
        ArrayTracker<int> tracker = new ArrayTracker<int>(array);

        Assert.NotNull(tracker.Collection());
        Assert.Equal(tracker.Next(), default(int));


    }

    [Fact]
    public void ArrayTracker_ArrayEmpty_HasValue()
    {
        int[] array = {};
        ArrayTracker<int> tracker = new ArrayTracker<int>(array);


        Assert.Equal(tracker.Next(), default(int));
        Assert.False(tracker.HasValue());


    }

    [Fact]
    public void ArrayTracker_Array_Normal_1_Int()
    {
        int[] array = {1, 2, 3, 4};
        ArrayTracker<int> tracker = new ArrayTracker<int>(array);


        Assert.Equal(tracker.Next(), 1);
        Assert.Equal(tracker.Next(), 2);
        Assert.Equal(tracker.Next(), 3);
        Assert.Equal(tracker.Next(), 4);


    }

    [Fact]
    public void ArrayTracker_Array_Normal_2_String()
    {
        string[] array = {"H", "A", "M", "Z"};
        ArrayTracker<string> tracker = new ArrayTracker<string>(array);


        Assert.Equal("H", tracker.Next());
        Assert.Equal("A", tracker.Next());
        Assert.Equal("M", tracker.Next());
        Assert.Equal("Z", tracker.Next());


    }

    [Fact]
    public void ArrayTracker_Array_Normal_3_HasValue()
    {
        string[] array = {"H", "A", "M", "Z"};
        ArrayTracker<string> tracker = new ArrayTracker<string>(array);


        Assert.Equal("H", tracker.Next());
        Assert.True(tracker.HasValue());
        Assert.Equal("A", tracker.Next());
        Assert.True(tracker.HasValue());
        Assert.Equal("M", tracker.Next());
        Assert.True(tracker.HasValue());
        Assert.Equal("Z", tracker.Next());
        Assert.False(tracker.HasValue());
    }
}
