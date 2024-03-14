using dentistClinic.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace dentistClinic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TurnsController : ControllerBase
    {

        private static List<Turns> TurnsList = new List<Turns>()
            {
            new Turns {Turnid = "AGR23R", doctor = "red", time = "01/02/2004", TurnLength = 30}
        };

        // GET: api/<Turns>
        [HttpGet]
        public IEnumerable<Turns> Get()
        {
            return TurnsList;
        }

        // GET api/<Turns>/5
        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            try
            {
                var turn = TurnsList.FirstOrDefault(t => t.Turnid == id);
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
        public IActionResult Post([FromBody] Turns newTurn)
        {
            try
            {
                // הוספת ה-Turn החדש לרשימת ה-Turns
                TurnsList.Add(newTurn);

                // נחזיר תשובת הצלחה
                return Ok();
            }
            catch (Exception ex)
            {
                // במקרה של שגיאה, נחזיר תשובת שגיאה עם הודעת השגיאה
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }


        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] string value)
        {
            try
            {
                // ניתן לעדכן את הנתונים בהתאם ל-ID שנשלח ולנתונים החדשים שמתקבלים בבקשה
                // כאן נבצע פעולות עדכון הנתונים של התור בהתאם ל-ID שהתקבל

                return NoContent(); // חזרה עם קוד הצלחה 204 No Content
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }


        // DELETE Agent By Id
        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            try
            {
                var removeTurn = TurnsList.FirstOrDefault(a => a.Turnid == id);

                if (removeTurn == null)
                {
                    return NotFound();
                }

                TurnsList.Remove(removeTurn);

                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
