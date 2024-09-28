class Entry
{
    public DateTime CurrentDate; 
    public string PromptText;     
    public string EntryText;      
    public Entry(string promptText, string entryText)
    {
        CurrentDate = DateTime.Now; 
        PromptText = promptText;
        EntryText = entryText;
    }
    public void Display()
    {
        Console.WriteLine($"Date: {CurrentDate}");
        Console.WriteLine($"Prompt: {PromptText}");
        Console.WriteLine($"Entry: {EntryText}\n");
    }
}