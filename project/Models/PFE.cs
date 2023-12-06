using System;
using System.ComponentModel.DataAnnotations;
using System.Net.Sockets;

namespace project.Models
{
	public class PFE
	{
        [Key]
        public int PFEID { get; set; }

        [Display(Name = "Titre du PFE")]
        public string Titre { get; set; }

        [Display(Name = "Description du PFE")]
        public string Desc { get; set; }

        [Display(Name = "Date de début")]
        [DataType(DataType.Date)]
        public DateTime DateD { get; set; }

        [Display(Name = "Date de fin")]
        [DataType(DataType.Date)]
        public DateTime DateF { get; set; }

        // Clés étrangères
        public int EncadreurID { get; set; }
        public int SocieteID { get; set; }

        // Propriétés de navigation
        public ENSEIGNANT Encadrant { get; set; }
        public SOCIETE Societe { get; set; }

        public ICollection<PFE_ETUDIANT> PFE_Etudiants { get; set; }
        public ICollection<SOUTENANCE> Soutenances { get; set; }
    }
}

