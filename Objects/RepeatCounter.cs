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


//getters and setters for properties//

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
