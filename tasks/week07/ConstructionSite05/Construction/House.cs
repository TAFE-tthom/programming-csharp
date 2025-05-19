namespace Construction;

public class House {

    public Roof Roof { get; set; }
    public Wall[] Walls { get; set; }
    public Carpet Carpet { get; set; }

    public House(Roof roof, Wall[] walls, Carpet carpet) {
        this.Roof = roof;
        this.Walls = walls;
        this.Carpet = carpet;
    }

}
