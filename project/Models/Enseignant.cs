using System;
using System.ComponentModel.DataAnnotations;

namespace project.Models
{
	public class ENSEIGNANT
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "Nom de l'enseignant")]
        public string Nom { get; set; }

        [Display(Name = "Prénom de l'enseignant")]
        public string Prenom { get; set; }

        // Propriété de navigation
        public ICollection<PFE> PFEsEncadres { get; set; }
    }
}

