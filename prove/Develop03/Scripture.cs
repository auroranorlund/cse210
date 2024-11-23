using System.Security.Cryptography;

public class Scripture
{
    private Reference _reference = new Reference("", 0, 0);
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] parts = text.Split(" ");
        foreach(string w in parts)
        {
            Word word = new Word(w);
            _words.Add(word);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random rnd = new Random();
        int listLength = _words.Count;
        while (numberToHide != 0)
        {
            int numberWordToHide = rnd.Next(0, listLength);
            bool isHidden = _words[numberWordToHide].IsHidden();
            if(isHidden == false)
            {
                _words[numberWordToHide].Hide();
                numberToHide = numberToHide - 1;
            }
        }
    }

    public string GetDisplayText()
    {
        string reference = _reference.GetDisplayText();
        string scripture = "";
        string word = "";
        int wordNumber = 0;
        foreach(Word w in _words)
        {
            word = w.GetDisplayText();
            if (wordNumber == 0)
            {
                scripture = scripture + word;
                wordNumber = 1;
            }
            else
            {
                scripture = scripture + " " + word;
            }
        }
        string text = $"{reference} - {scripture}";
        return text;
    }

    public bool IsCompletelyHidden()
    {
        bool wordHidden;
        bool IsCompletelyHidden = true;
        foreach (Word w in _words)
        {
            wordHidden = w.IsHidden();
            if (wordHidden == false)
            {
                IsCompletelyHidden = false;
            }
        }
        return IsCompletelyHidden;
    }
}