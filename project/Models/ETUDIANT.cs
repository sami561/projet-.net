using System;
using System.ComponentModel.DataAnnotations;

namespace project.Models
{
	public class ETUDIANT
	{
        [Key]
        public int ID { get; set; }

        [Display(Name = "Nom de l'étudiant")]
        public string Nom { get; set; }

        [Display(Name = "Prénom de l'étudiant")]
        public string Prenom { get; set; }

        [Display(Name = "Date de naissance")]
        [DataType(DataType.Date)]
        public DateTime DateNaiss { get; set; }

        // Propriété de navigation
        public ICollection<PFE_ETUDIANT> PFE_Etudiants { get; set; }
    }
}

