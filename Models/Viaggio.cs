using System.ComponentModel.DataAnnotations;

namespace bootstrap_travel_agency_MVC.Models
{
    public class Viaggio
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public Destinazione Destinazione { get; set; }

        [Required]
        public DateTime DataPartenza { get; set; }

        [Required]
        [Range(1,10)] //Gestiamo viaggi di massimo 10 settimane
        public int SettimaneViaggio { get; set; }


    }
}
