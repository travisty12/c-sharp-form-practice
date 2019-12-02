using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;

namespace FriendLetter.Controllers
{
  public class HomeController : Controller
  {
    [Route("/hello")]
    public string Hello() { return "Hello friend!"; }

    [Route("/goodbye")]
    public string GoodBye() { return "Goodbye friend."; }

    [Route("/")]
    public ActionResult Letter() { 
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.Recipient = "Travis";
      myLetterVariable.Sender = "Rex";
      return View(myLetterVariable); 
    }

    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/card")]
    public ActionResult Card(string recipient, string sender)
    {
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.Recipient = recipient;
      myLetterVariable.Sender = sender;
      return View(myLetterVariable);
    }
  }
}