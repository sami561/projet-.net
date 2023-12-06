using System;
namespace project.Models
{
	public class PFE_ETUDIANT
	{
        public int ID { get; set; }

        // Clés étrangères
        public int PFEID { get; set; }
        public int EtudiantId { get; set; }

        // Propriétés de navigation
        public PFE PFE { get; set; }
        public ETUDIANT Etudiant { get; set; }
    }
}

