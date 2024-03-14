using dentistClinic.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace dentistClinic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {

        private static List<Doctors> DoctorList = new List<Doctors>()
            {
            new Doctors {DoctorId = "1", DoctorName = "red", DoctorStutus = "dfgh", DoctorAge =20} };
        // GET: api/<Turns>
        [HttpGet]
        public IEnumerable<Doctors> Get()
        {
            return DoctorList;
        }

        // GET api/<Turns>/5
        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            try
            {
                var turn = DoctorList.FirstOrDefault(t => t.DoctorId == id);
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
        public IActionResult Post([FromBody] Doctors newDoctor)
        {
            try
            {
                // הוספת ה-Turn החדש לרשימת ה-Turns
                DoctorList.Add(newDoctor);

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
        public IActionResult Put(string id, [FromBody] Doctors updateDoctor)
        {
            try
            {
                var doctor = DoctorList.FirstOrDefault(a => a.DoctorId == id);

                if (doctor == null)
                {
                    return NotFound();
                }

                doctor.DoctorAge = updateDoctor.DoctorAge;


                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }


     

    }
}
