namespace Construction.Test;

public class ConstructionTest
{
    [Fact]
    public void HouseSite_CheckBuilt_True()
    {
        HouseSite site = new HouseSite()
            .SupplyRoof(new Roof())
            .SupplyWall(new Wall("1"))
            .SupplyWall(new Wall("2"))
            .SupplyWall(new Wall("3"))
            .SupplyWall(new Wall("4"))
            .SupplyCarpet(new Carpet("Comfy"));

        bool valid = site.Built();
        Assert.True(valid);
    }

    [Fact]
    public void HouseSite_CheckBuilt_False_1()
    {
        HouseSite site = new HouseSite()
        .SupplyRoof(new Roof())
        .SupplyWall(new Wall("1"))
        .SupplyWall(new Wall("3"))
        .SupplyWall(new Wall("4"))
        .SupplyCarpet(new Carpet("Comfy"));

        bool valid = site.Built();
        Assert.False(valid);
    }

    [Fact]
    public void HouseSite_CheckBuilt_False_2()
    {
        HouseSite site = new HouseSite()
        .SupplyRoof(new Roof())
        .SupplyWall(new Wall("1"))
        .SupplyWall(new Wall("2"))
        .SupplyWall(new Wall("3"))
        .SupplyWall(new Wall("4"));

        bool valid = site.Built();
        Assert.False(valid);
    }

    [Fact]
    public void HouseSite_CheckBuilt_False_3()
    {
        HouseSite site = new HouseSite()
        .SupplyWall(new Wall("1"))
        .SupplyWall(new Wall("2"))
        .SupplyWall(new Wall("3"))
        .SupplyWall(new Wall("4"))
        .SupplyCarpet(new Carpet("Comfy"));

        bool valid = site.Built();
        Assert.False(valid);
    }

    [Fact]
    public void HouseSite_Check_Build()
    {
        HouseSite site = new HouseSite()
        .SupplyRoof(new Roof())
        .SupplyWall(new Wall("1"))
        .SupplyWall(new Wall("2"))
        .SupplyWall(new Wall("3"))
        .SupplyWall(new Wall("4"))
        .SupplyCarpet(new Carpet("Comfy"));

        House h = site.Build();
        Assert.NotNull(h);
    }
}
