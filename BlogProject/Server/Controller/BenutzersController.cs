using BlogProject.Server.DBModels;
using BlogProject.Server.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject.Server.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class BenutzersController : ControllerBase
    {
        private readonly DataBaseContext _context;
        public List<BlogPost> posts;
        public List<Benutzers> benutzers;

        public BenutzersController(DataBaseContext context, List<BlogPost> posts, List<Benutzers> benutzers)
        {
            _context = context;
            posts = posts;
            benutzers = benutzers;
        }

        [HttpGet]
        void loginFor(string user, string psw)
        {
            testc 
        }
    }
}
