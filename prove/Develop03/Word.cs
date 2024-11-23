//I used this forum post to help me convert the word to underscores. https://stackoverflow.com/questions/75121857/replacing-a-string-with-an-equal-amount-of-underscores
using System;
using System.Text;
public class Word
{
    private string _text = "";
    private bool _isHidden = false;

    public Word(string text)
    {
        _text = text;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        bool hidden = _isHidden;
        return hidden;
    }

    public string GetDisplayText()
    {
        string text;
        if (_isHidden == true)
        {
            string underscores = new string('_', _text.Length);
            text = underscores;
        }
        else
        {
            text = _text;
        }
        return text;
    }
}