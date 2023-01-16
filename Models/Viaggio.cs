﻿using System.ComponentModel.DataAnnotations;

namespace bootstrap_travel_agency_MVC.Models
{
    public class Viaggio
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string NomeViaggio { get; set; }

        [Required]
        public List<Destinazione> ListaDestinazioni { get; set; } //Cambiata la relazione da 1 a n in n a n perché nell'esercizio base i viaggi potevano avere più destinazioni

        [Required]
        public DateTime DataPartenza { get; set; }

        [Required]
        [Range(1,15)] //Gestiamo viaggi di massimo 15 settimane
        public int SettimaneViaggio { get; set; }

        [Required]
        public double Prezzo { get; set; }

        public int ColorCard { get; set; }

        public string ImagePath { get; set; }


    }
}
