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

    }

    public string Serialize(int foo)
    {
        return "";
    }

    public void Deserialize(string line)
    {

    }
}