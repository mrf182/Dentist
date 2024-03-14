using dentistClinic.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace dentistClinic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        private static List<Clients> ClientList = new List<Clients>()
            {
            new Clients {ClientId = "AGR23R", ClientName = "red", stutus = "dfgh", Insurance = "family"}
        };
        // GET: api/<Clients>

        [HttpGet]
    public IEnumerable<Clients> Get()
    {
        return ClientList;
    }

        // GET api/<Turns>/5
        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            try
            {
                var turn = ClientList.FirstOrDefault(t => t.ClientId == id);
                return Ok(turn);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        // POST api/<Turns>
        // POST api/<CarsController>
        [HttpPost]
        public IActionResult Post([FromBody] Clients newClient)
        {
            try
            {
                // הוספת ה-Turn החדש לרשימת ה-Turns
                ClientList.Add(newClient);

                // נחזיר תשובת הצלחה
                return Ok();
            }
            catch (Exception ex)
            {
                // במקרה של שגיאה, נחזיר תשובת שגיאה עם הודעת השגיאה
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        // PUT edit Agent By ID
        [HttpPut("{id}")]
        public IActionResult Put(string id, [FromBody] Clients updatedInsurance)
        {
            try
            {
                var client = ClientList.FirstOrDefault(a => a.ClientId == id);

                if (client == null)
                {
                    return NotFound();
                }

                client.Insurance = updatedInsurance.Insurance;


                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }


      

    }
}

