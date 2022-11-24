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
        else if (movement == "up")
        {
            Aim -= value;
        }
        else
        {
            Position += value;
            Depth += Aim * value;
        }
    }

    public int Aim { private set; get; } = 0;
    public int Position { private set; get; } = 0;
    public int Depth { private set; get; } = 0;
}