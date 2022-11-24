namespace SubmarineTcrKata.Domain;

public class Submarine : ISubmarine
{
    public void ExecuteCommand(string command)
    {
        Aim = 1;
    }

    public int Aim
    {
        private set;
        get;
    } = 0;
    public int Position => 0;
    public int Depth => 0;
}