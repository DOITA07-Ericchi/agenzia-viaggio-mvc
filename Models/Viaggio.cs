using System.ComponentModel.DataAnnotations;

namespace bootstrap_travel_agency_MVC.Models
{
    public class Viaggio
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string NomeViaggio { get; set; }

        [Required]
        public Destinazione Destinazione { get; set; }

        public int DestinazioneId { get; set; }

        [Required]
        public DateTime DataPartenza { get; set; }

        [Required]
        [Range(1,10)] //Gestiamo viaggi di massimo 10 settimane
        public int SettimaneViaggio { get; set; }

        [Required]
        public double Prezzo { get; set; }

        public int ColorCard { get; set; }

        public string ImagePath { get; set; }



    }
}
