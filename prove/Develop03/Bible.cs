// used geeksforgeeks.org/c-sharp-dictionary-with-examples/ for help with c# dictionaries.
// Bible data file provided from: kaggle.com/datasets/phyred23/bibleverses, edited to work for this program using onlinetools.com change csv delimiter and the built in VS code txt file editor.
using System.Collections.Generic;
using System.Data;
public class Bible
{
    private Dictionary<string, List<string>> _bible = new Dictionary<string, List<string>>();

    public void LoadFromFile(string fileName)
    {
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            List<string> scripture = new List<string>();
            string[] parts = line.Split("|");
            string reference = parts[0];
            string book = parts[1];
            string chapter = parts[2];
            string verse = parts[3];
            string text = parts[4];
            scripture.Add(book);
            scripture.Add(chapter);
            scripture.Add(verse);
            scripture.Add(text);
            _bible.Add(reference, scripture);
        }
    }
    public string GetScripture(string book, string chapter, string startVerse, string endVerse)
    {
        string reference;
        string verse = "";
        if (endVerse == "0")
        {
            reference = $"{book} {chapter}:{startVerse}";
            List<string> scripture = _bible[reference];
            verse = scripture[3];
        }
        else
        {
            int refVerse = int.Parse(startVerse);
            int endLoop = int.Parse(endVerse);
            while(refVerse != endLoop)
            {
                startVerse = refVerse.ToString();
                reference = $"{book} {chapter}:{startVerse}";
                List<string> scripture = _bible[reference];
                verse = verse + scripture[3];
                refVerse += 1;
            }
        }
        return verse;
    }

}