using System.Collections.Generic;

namespace TEMPLATES.Objects

{

  //variables//

    public class TEMPLATE
  {
      private string _TEMPLATEVARIABLE;
      private static List<TEMPLATE> _TEMPLATELIST = new List<TEMPLATE> {};

//construtor//

  public TEMPLATE(string TEMPLATEVARIABLE)
   {
     _TEMPLATEVARIABLE = TEMPLATEVARIABLE;
     _TEMPLATELIST.Add(this);
   }


//getters and setters for properties//

      public string GetVariable()
      {
      return _TEMPLATEVARIABLE;
      }

      public void SetVariable(string newVariable)
      {
        _TEMPLATEVARIABLE = newVariable;
      }

  }
}
