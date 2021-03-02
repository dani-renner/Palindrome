using Microsoft.AspNetCore.Mvc;
using Palindrome.Models;

namespace Palindrome.Controllers
{
  public class HomeController : Controller
  {
  [Route("/answer")]
  public ActionResult Answer();
  {
    SameBothWays newWord = new SameBothWays();
    
  }
  }
}