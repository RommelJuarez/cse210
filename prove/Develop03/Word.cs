using System;
using System.Linq;
public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;

    }
    public void Hide()
    {
        _isHidden = true;
    }
    public string GetDisplayText()
    {
        return _isHidden ? new string('_', _text.Length) : _text;

    }
    public void SetHiddenState(bool isHidden)
    {
        _isHidden = isHidden;
    }
    public bool isHidden()
    {
        return _isHidden;
    }
}