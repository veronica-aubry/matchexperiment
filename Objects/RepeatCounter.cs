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
    private List<string> _puncSentence;
    private string matchSentence;
    private string strippedSentence;

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

      public string GetMatchSentence()
      {
        matchSentence = String.Join(" ", _puncSentence);
        return matchSentence;
      }

      public int CountRepeats()
      {
        _puncSentence = _searchSentence.Split(' ').ToList();
        strippedSentence = new string(_searchSentence.Where(c => !char.IsPunctuation(c)).ToArray());
        List<string> splitSentence = strippedSentence.Split(' ').ToList();
        for (int i = 0; i <= (splitSentence.Count - 1); i++)
          {
           if (splitSentence[i] == _searcher)
           {
            _wordTotal = _wordTotal + 1;
            _puncSentence.RemoveAt(i);
            _puncSentence.Insert(i, "<span class='match'>" + _searcher + "</span>");
           }
        }
        return _wordTotal;
      }

  }
}
