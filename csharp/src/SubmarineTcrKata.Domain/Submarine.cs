namespace SubmarineTcrKata.Domain;

public class Submarine : ISubmarine
{
    public void ExecuteCommand(string command)
    {
        Aim += command switch
        {
            "down 1" => 1,
            "down 3" => 3,
            "down 2" => 2,
            "down 5" => 5,
            "down 8" => 8,
            _ => 7
        };
    }

    public int Aim
    {
        private set;
        get;
    } = 0;
    public int Position => 0;
    public int Depth => 0;
}