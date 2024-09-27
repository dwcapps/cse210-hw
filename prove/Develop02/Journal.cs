public class Journal 
{
    public List<Entry> _entries = new List<Entry>();



    public void AddEntry(Entry newEntry)
    {
        PromptGenerator generator = new PromptGenerator();
        string prompt = generator.GetRandomPrompt();
        newEntry._date = DateTime.Now.ToShortDateString();
        newEntry._promptText = prompt;

        Console.Write(prompt + "\n> ");
        newEntry._entryText = Console.ReadLine();
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|||{entry._promptText}|||{entry._entryText}");
            }
        }
    }

    public void LoadFromFile(string file)
    { 
        string[] lines = System.IO.File.ReadAllLines(file);
        foreach (string entry in lines)
        {
            string[] entryParts = entry.Split("|||");
            Entry loadedEntry = new Entry();
            loadedEntry._date = entryParts[0];
            loadedEntry._promptText = entryParts[1];
            loadedEntry._entryText = entryParts[2];

            _entries.Add(loadedEntry);
        }
    }
}