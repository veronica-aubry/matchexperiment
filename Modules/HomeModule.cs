using Nancy;
using RepeatCount;
using System.Collections.Generic;

namespace Project
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View ["index.cshtml"];

      Post["/results"] = _ => {
      RepeatCounter newRepeatCounter = new RepeatCounter(Request.Form["word"], Request.Form["sentence"]);
      return View["results.cshtml", newRepeatCounter];
      };
    }
  }
}
