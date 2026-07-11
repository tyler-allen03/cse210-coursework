// method 1 - add entry
// method 2 - display all - calls the entry display method
// method 3 - save to file
// method 4 - load from file
// attribute 1 - object list - a list of the entries 

using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public Journal()
    {
    }

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry e in _entries)
        {
            e.Display();
        }
    }

    public void SaveToFile(string file)
    {
        string usedFile = file;
        using (StreamWriter outputFile = new StreamWriter(usedFile))
        {
            foreach (Entry e in _entries)
            {
                outputFile.WriteLine($"{e._date}|{e._entryText}|{e._promptText}|{e._motivationText}");
            }
                
        }
    }

    public void LoadFromFile(string file)
    {
        string usedFile = file;
        string[] lines = System.IO.File.ReadAllLines(usedFile);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            string entryDate = parts[0];
            string entryText = parts[1];
            string entryPrompt = parts[2];
            string entryMotivation = parts[3];

            Entry tempEntry = new Entry();
            tempEntry._date = entryDate;
            tempEntry._entryText = entryText;
            tempEntry._promptText = entryPrompt;
            tempEntry._motivationText = entryMotivation;

            _entries.Add(tempEntry);
        }
    }
}