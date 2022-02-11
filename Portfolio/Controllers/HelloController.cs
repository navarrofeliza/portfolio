using Microsoft.AspNetCore.Mvc;
namespace Portfolio.Controllers     //be sure to use your own project's namespace!
{
    public class HelloController : Controller   //remember inheritance??
    {
        //for each route this controller is to handle:
        [HttpGet]       //type of request
        [Route("")]     //associated route string (exclude the leading /)
        public string Index()
        {
            return "This is my Index!";
        }

        // Other code
        [HttpGet]
        [Route("{projects}")]
        public string Projects(string projects)
        {
            return $"These are my projects";
        }
        [HttpGet]
        [Route("contact")]
        public string Contact(string contact)
        {
            return $"This is my contact!";
        }
    }

}

