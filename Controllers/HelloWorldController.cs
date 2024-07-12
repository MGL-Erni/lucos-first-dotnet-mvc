using Microsoft.AspNetCore.Mvc;
//using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class HelloWorldController : Controller
{
    // GET: /HelloWorld/
    public string Index()
    {
        return "This is my default action...";
    }
    // GET: /HelloWorld/Welcome/ 
    // args must be explicitly specified as query params?? yes.
    // ^ e.g. http://localhost:5117/HelloWorld/Welcome/?name=Matt&id=10
    public string Welcome(string name, int id = 1)
    {
        //return "This is the Welcome action method...";
        //return HtmlEncoder.Default.Encode($"Hello: {name}, ID is {id}");
        return $"Hello {name}, NumTimes is: {id}";
        // you can make params optional with `?` at the end of them
    }
}

// cont. Add a View w/ VSCode
// https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/adding-view?view=aspnetcore-8.0&tabs=visual-studio-code#add-a-view