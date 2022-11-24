namespace SubmarineTcrKata.Domain;

public class Submarine : ISubmarine
{
    public void ExecuteCommand(string command)
    {
        var splitCommand = command.Split(" ");
        var movement = splitCommand.First();
        var value = int.Parse(splitCommand.Last());
        
        switch (movement)
        {
            case "down":
                Aim += value;
                break;
            case "up":
                Aim -= value;
                break;
            default:
                Position += value;
                Depth += Aim * value;
                break;
        }
    }

    public int Aim { private set; get; } = 0;
    public int Position { private set; get; } = 0;
    public int Depth { private set; get; } = 0;
}