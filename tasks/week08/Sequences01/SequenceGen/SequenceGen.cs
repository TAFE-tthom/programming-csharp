namespace SequenceGen;

public class SequenceGeneratorFinished : Exception {

}

public class SequenceGen
{

    public SequenceGen(int start) {

    }

    public SequenceGen(int start, int step) {

    }

    public SequenceGen(int start, int step, int end) {

    }

    public int Current() {

        return 0;
    }

    public bool Finished() {

        return false;
    }

    public int Next() {

        return 0;
    }

}
