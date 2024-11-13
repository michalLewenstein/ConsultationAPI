using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CounselingSessionsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        //  ניתן לאתחל אותו (להכניס לו ערך) רק ב CTOR
        private readonly IDataContext _context;

        public ClientsController(IDataContext context)
        {
            _context = context;
        }

        // GET: api/<ClientsController>
        [HttpGet]
        public IEnumerable<Client> Get()
        {
            return _context.Clients;
        }

        // GET api/<ClientsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ClientsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ClientsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ClientsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
