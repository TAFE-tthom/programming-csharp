namespace CSVLoader;

public class CSVLoader
{

    public int Rows { get; private set; }



    public CSVLoader(string path, bool hasHeader) {

    }


    public string[] Header() {
        string[] headers = new string[0];

        return headers;
    }

    public string[] Row(int rowId) {
        string[] row = new string[0];

        if(rowId >= 0) {

        }


        return row;
    }

    public string? Entry(int row, int column)
    {
        string ent = string.Empty;

        return ent;
    }

}
