namespace SubmarineTcrKata.Domain;

public class Submarine : ISubmarine
{
    public void ExecuteCommand(string command)
    {
        var splitCommand = command.Split(" ");
        var movement = splitCommand.First();
        var value = int.Parse(splitCommand.Last());
        
        if (movement == "down")
        {
            Aim += value;
        }
        else
        {
            Aim -= value;
        }
    }

    public int Aim
    {
        private set;
        get;
    } = 0;
    public int Position => 0;
    public int Depth => 0;
}