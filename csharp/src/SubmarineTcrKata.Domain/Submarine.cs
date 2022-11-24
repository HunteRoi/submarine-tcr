namespace SubmarineTcrKata.Domain;

public class Submarine : ISubmarine
{
    public void ExecuteCommand(string command)
    {
        var splitCommand = command.Split(" ");
        var movement = splitCommand[0];
        if (movement == "down")
        {
            Aim += int.Parse(splitCommand[1]);    
        }
        else
        {
            Aim -= int.Parse(splitCommand[1]);
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