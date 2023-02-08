using System;

class Entry
{
    private string _date;
    private string _prompt;
    private string _response;

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