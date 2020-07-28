using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LMSStudent.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {     
        // GET: api/users/
        [HttpGet]
        public string Get()
        {
            var salute = "Hello World! From GET: api/users/";
            return salute;
        }

        // GET: api/users/1
        [HttpGet("{id}")]
        public string GetUser(int id)
        {
            var salute = "Hello World! From GET: api/users/" + id;
            return salute;
        }

        // PUT: api/users/1
        [HttpPut("{id}")]
        public string PutUser(int id)
        {
            var salute = "Hello World! From PUT: api/users/" + id;
            return salute;
        }

        // POST: api/users
        [HttpPost]
        public string PostUser()
        {
            var salute = "Hello World! From POST: api/users";
            return salute;
        }

        // DELETE: api/users/5
        [HttpDelete("{id}")]
        public string DeleteUser(int id)
        {
            var salute = "Hello World! From DELETE: api/users/" + id;
            return salute;
        }
    }

    


}