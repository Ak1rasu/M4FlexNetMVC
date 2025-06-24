using Microsoft.AspNetCore.Mvc;
using stageapi.Models;

namespace stageapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StageController : ControllerBase
    {
        // ✅ Statische lijst met voorbeelddata
        private static List<Stage> stages = new List<Stage>
        {
            new Stage { Id = 1, BedrijfsNaam = "Tech Innovators BV", StageVergoeding = 500.00, Stad = "Amsterdam", Beschrijving = "Innovatieve softwareprojecten." },
            new Stage { Id = 2, BedrijfsNaam = "Green Solutions", StageVergoeding = 600.50, Stad = "Rotterdam", Beschrijving = "Duurzame technologie." },
            new Stage { Id = 3, BedrijfsNaam = "Future Designs", StageVergoeding = 450.75, Stad = "Utrecht", Beschrijving = "UX en UI design stages." },
            new Stage { Id = 4, BedrijfsNaam = "EduWorld", StageVergoeding = 400.00, Stad = "Den Haag", Beschrijving = "Onderwijs en technologie." },
            new Stage { Id = 5, BedrijfsNaam = "Code Creators", StageVergoeding = 550.00, Stad = "Eindhoven", Beschrijving = "Web en app development." }
        };

        // ✅ GET: /stage
        [HttpGet]
        public ActionResult<IEnumerable<Stage>> GetAll()
        {
            return Ok(stages);
        }

        // ✅ POST: /stage
        [HttpPost]
        public ActionResult<Stage> Create([FromBody] Stage stage)
        {
            stage.Id = stages.Count + 1;
            stages.Add(stage);
            return CreatedAtAction(nameof(GetAll), new { id = stage.Id }, stage);
        }
    }
}
