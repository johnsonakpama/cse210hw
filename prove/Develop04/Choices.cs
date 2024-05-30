using System;

public class Choices
{
    private string _choices = $@"
    Menu Options
    ================================================
    Please select one of the following options to begin:
    1. Start breathing activity
    2. Start reflecting activity
    3. Start listing activitt
    4. Quit
    ==================================================
    Select an option from the menu above: ";

    public string _userInput;
    private int _userChoice = 0;

    public int UserChoice()
    {
        Console.Clear();
        Console.Write(_userChoice);

        _userInput = Console.ReadLine();
        _userChoice = 0;

        try
        {
            _userChoice = int.Parse(_userInput);
        }

        catch (FormatException)
        {
            _userChoice = 0;
        }
        catch (Exception exception)
        {
            Console.WriteLine(
                $"Unexpected error:  {exception.Message}");
        }
        return _userChoice;
    }

    
    
}



