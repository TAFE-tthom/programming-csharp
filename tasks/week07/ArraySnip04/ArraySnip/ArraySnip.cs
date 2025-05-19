namespace ArraySnip;

public class ArrayCutter
{

    private int[] array;

    public ArrayCutter(int[] array) {
            this.array = array;
    }

    public int[][]? Cut(int pieces) {

        if(array.Count() == 0) {
            return new int[][] { };

        }
        if(pieces <= 0) {

            return null;
        }

        int arrayCuts = 0;
        int remainder = 0;

        if(pieces > array.Count()) {
            //Can't split it into
            pieces = array.Count();
            arrayCuts = 1;

        } else {
          arrayCuts = array.Count() / pieces;
          remainder = array.Count() % pieces;
        }

        int[][] chunks = new int[pieces][];

        int counter = 0;

        for(int i = 0; i < pieces; i++) {

            int offsetExtra = 0;
            if(remainder > 0) {
                offsetExtra = 1;
                remainder--;
            }

            chunks[i] = new int[arrayCuts + offsetExtra];
            for(int j = 0; j < arrayCuts+offsetExtra; j++) {

                chunks[i][j] = array[counter];
                counter++;

            }
        }

        return chunks;

    }

}
