using System.ComponentModel.DataAnnotations;

namespace bootstrap_travel_agency_MVC.Models
{
    public class Viaggio
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string NomeViaggio { get; set; }

        /* Questa roba non si fa più. Niente relazioni per ora, pls.
         * 
        [Required]
        public List<Destinazione> ListaDestinazioni { get; set; } //Cambiata la relazione da 1 a n in n a n perché nell'esercizio base i viaggi potevano avere più destinazioni
        */

        [Required]
        public int NumDestinazioni { get; set; }

        [Required]
        [Range(1,90)] //Gestiamo viaggi di massimo 90 giorni
        public int GiorniViaggio { get; set; }

        [Required]
        public double Prezzo { get; set; }

        public int ColorCard { get; set; }

        public string ImagePath { get; set; }


    }
}
