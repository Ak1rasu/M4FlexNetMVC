namespace stageapi.Models
{
    public class Stage
    {
        public int Id { get; set; }
        public string BedrijfsNaam { get; set; }
        public double StageVergoeding { get; set; }
        public string Stad { get; set; }
        public string Beschrijving { get; set; }  // Nieuw toegevoegd
    }
}
