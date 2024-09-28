
using System.Collections.Generic;
class Journal
{  private List<Entry> entries = new List<Entry>();
    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }
    public void DisplayAll()
    {
        foreach (var entry in entries)
        {
            entry.Display();
        }
    }
    public void SaveToFile(string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine($"{entry.CurrentDate}|{entry.PromptText}|{entry.EntryText}");
            }
        }
    }
    public void LoadFromFile(string filePath)
    {
        if (File.Exists(filePath))
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split('|');
                    if (parts.Length == 3)
                    {
                        DateTime currentDate = DateTime.Parse(parts[0]);
                        string promptText = parts[1];
                        string entryText = parts[2];
                        Entry entry = new Entry(promptText, entryText) { CurrentDate = currentDate };
                        entries.Add(entry);
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("404 File not Found");
        }
    }
}