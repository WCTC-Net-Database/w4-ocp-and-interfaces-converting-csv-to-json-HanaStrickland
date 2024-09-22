namespace W4_assignment_template.Services;

public class CharcaterClassManager
{
    public string[] CharacterClassOptions {get;set;} = {"Cleric", "Fighter", "Rogue", "Wizard"};

    public void DisplayCharacterClassMenu()
    {
        for (int i = 0; i < CharacterClassOptions.Length; i++)
        {
            Console.WriteLine($"{i+1}: {CharacterClassOptions[i]}");
        }
    }
}