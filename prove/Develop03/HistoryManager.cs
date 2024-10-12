using System.Collections.Generic;

public class HistoryManager
{
    private Stack<List<bool>> _history;

    public HistoryManager()
    {
        _history = new Stack<List<bool>>();
    }

    public void SaveState(List<Word> words)
    {

        List<bool> currentState = new List<bool>();
        foreach (var word in words)
        {
            currentState.Add(word.isHidden());
        }
        _history.Push(currentState);
    }


    public bool RestorePreviousState(List<Word> words)
    {
        if (_history.Count == 0) return false;

        List<bool> previousState = _history.Pop();

        for (int i = 0; i < words.Count; i++)
        {
            words[i].SetHiddenState(previousState[i]);
        }

        return true;
    }
}
