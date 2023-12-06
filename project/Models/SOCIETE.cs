using System;
using System.ComponentModel.DataAnnotations;

namespace project.Models
{
	public class SOCIETE
	{
        [Key]
        public int ID { get; set; }

        [Display(Name = "Libellé de la société")]
        public string Lib { get; set; }

        public string Adresse { get; set; }

        public string Tel { get; set; }

        // Propriété de navigation
        public ICollection<PFE> PFEs { get; set; }
    }
}

