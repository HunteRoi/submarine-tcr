namespace SubmarineTcrKata.Domain;

public class Submarine : ISubmarine
{
    public void ExecuteCommand(string command)
    {
        var splitCommand = command.Split(" ");
        var movement = splitCommand[0];
        var value = int.Parse(splitCommand[1]);
        
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