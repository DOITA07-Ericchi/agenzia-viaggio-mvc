using System.ComponentModel.DataAnnotations;

namespace bootstrap_travel_agency_MVC.Models
{
    public class Destinazione
    {
        [Key]
        public int DestinazioneId { get; set; }

        [Required]
        public string CittaArrivo { get; set; }

        public List<Viaggio> ViaggiPerDestinazione { get; set; }


        public override string ToString()
        {
            return $"{CittaArrivo}";
        }
    }
}
