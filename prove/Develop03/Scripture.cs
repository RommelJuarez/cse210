using System;
public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] _wordsArray = text.Split(" ");
        foreach (string wordItem in _wordsArray)
        {
            _words.Add(new Word(wordItem));
        }

    }
    public List<Word> GetWords()
    {
        return _words;
    }
    public void HideWords(int count)
    {
        Random random = new Random();
        int _flag = 0;
        do
        {
            int index = random.Next(_words.Count);
            if (!_words[index].isHidden())
            {
                _words[index].Hide();
                _flag++;
            }
        } while (_flag <= count);
    }

    public void Display()
    {
        Console.Clear();
        Console.WriteLine("");
        Console.WriteLine(_reference.DisplayReference());
        foreach (var word1 in _words)
        {
            Console.Write($"{word1.GetDisplayText()} ");
        }

    }

    public bool AllWordsHidden()
    {
        foreach (var word in _words)
        {
            if (!word.isHidden())
            {
                return false;
            }
        }
        return true;
    }

}