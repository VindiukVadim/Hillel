using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiUser.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UserController : ControllerBase
    {

        public static List<User> users = new List<User>();
        

        [HttpGet]
        [Route("Get")]
        public ActionResult<IEnumerable<User>> Get()
        {
            return Ok(users);
        }


        [HttpGet("{id}")]
        public ActionResult<User> Get(int id)
        {
            User user = users.FirstOrDefault(u => u.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }


        [HttpPost]
        [Route("Post")]
        public ActionResult<User> Post(User user)
        {
            users.Add(user);
            return Ok(user);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, User updatedUser)
        {
            User user = users.FirstOrDefault(u => u.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            user.Name = updatedUser.Name;
            user.Age = updatedUser.Age;
            return Ok(user);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            User user = users.FirstOrDefault(u => u.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            users.Remove(user);
            return Ok(user);
        }
    }
}
