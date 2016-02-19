using System;
using System.Linq;
using System.Collections.Generic;

namespace RepeatCount

{

    public class RepeatCounter
  {
    private int _wordTotal;
    private string _searcher;
    private string _searchSentence;

    public RepeatCounter(string searcher, string searchSentence )
    {
      _searcher = searcher.ToLower();
      _searchSentence = searchSentence.ToLower();
      _wordTotal = 0;
    }

      public string GetWord()
      {
        return _searcher;
      }

      public string GetSentence()
      {
        return _searchSentence;
      }

      public int CountRepeats()
      {
        _searchSentence = new string(_searchSentence.Where(c => !char.IsPunctuation(c)).ToArray());
        string [] splitSentence = _searchSentence.Split(' ');
        foreach (string word in splitSentence)
        {
           if (word == _searcher)
           {
            _wordTotal = _wordTotal + 1;
           }
        }
        return _wordTotal;
      }

  }
}
