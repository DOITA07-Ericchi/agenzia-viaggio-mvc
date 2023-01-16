using System.ComponentModel.DataAnnotations;

namespace bootstrap_travel_agency_MVC.Models
{
    public class Destinazione
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string CittaArrivo { get; set; }

        public string? PaeseArrivo { get; set; } //Null se uguale al paese di partenza

        List<Viaggio>? ViaggiPerDestinazione { get; set; }


    }
}
