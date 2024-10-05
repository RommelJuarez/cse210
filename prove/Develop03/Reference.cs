using System;

public class Reference
{
    public string _book { get; private set; }
    public int _chapter { get; private set; }
    public int _verse { get; private set; }
    public int _endVerse { get; private set; }

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = -1;
    }
    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public string DisplayReference()
    {
        if (_endVerse > 0)
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}:";
        }
        else
        {
            return $"{_book} {_chapter}:{_verse}:";
        }
    }

}