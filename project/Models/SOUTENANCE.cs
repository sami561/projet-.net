using System;
using System.ComponentModel.DataAnnotations;

namespace project.Models
{
	public class SOUTENANCE
	{
        [Key]
        public int ID { get; set; }

        [Display(Name = "Date de la soutenance")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Display(Name = "Heure de la soutenance")]
        public string Heure { get; set; }

        // Clés étrangères
        public int PFEID { get; set; }
        public int PresidentId { get; set; }
        public int RapporteurID { get; set; }

        // Propriétés de navigation
        public PFE PFE { get; set; }
        public ENSEIGNANT President { get; set; }
        public ENSEIGNANT Rapporteur { get; set; }
    }
}

