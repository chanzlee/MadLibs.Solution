using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult Form()
    {
      return View();
    }

    [Route("/madlib_result")]
    public ActionResult MadLibsResult()
    {
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.SetPerson1(Request.Query["person1"]);
      myLetterVariable.SetPerson2(Request.Query["person2"]);
      myLetterVariable.SetAnimal(Request.Query["animal"]);
      myLetterVariable.SetExclamation(Request.Query["exclamation"]);
      myLetterVariable.SetVerb(Request.Query["verb"]);
      myLetterVariable.SetNoun(Request.Query["noun"]);

      return View("MadLibsResult", myLetterVariable);
    }
  }
}
