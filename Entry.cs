using System;

class Entry
{
    private string _date;
    private string _prompt;
    private string _response;

    public Entry()
    {
        _date = DateTime.Now.ToShortDateString();
        // _prompt = PromptGenerator.GetPrompt(); // TODO: Add line when this is written
        _prompt = "What is your favorite program to write?";
        Console.WriteLine(_prompt);
        _response = Console.ReadLine();
    }

    public Entry(string line)
    {
        Deserialize(line);
    }

    public Entry(string date, string prompt, string response)
    {
        _date = date;
        _prompt = prompt;
        _response = response;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}\n{_response}");
    }

    public string Serialize()
    {
        return $"{_date}~|~{_prompt}~|~{_response}";
    }

    public void Deserialize(string line)
    {
        string[] parts = line.Split("~|~");
        if (parts.Length < 3) 
        {
            Console.WriteLine("Badly formed line.");
        }
        else
        {
            _date = parts[0];
            _prompt = parts[1];
            _response = parts[2];
        }
    }
}