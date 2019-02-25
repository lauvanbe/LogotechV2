using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LogotechV2.API.Models
{
    public class Patient
    {
        public Patient(int id, string nom, string prenom, DateTime dateNaissance, string email, string personneContact, string anamnese, string commentaire, string photoUrl, Adresse adresse, int adresseId)
        {
            this.Id = id;
            this.Nom = nom;
            this.Prenom = prenom;
            this.DateNaissance = dateNaissance;
            this.Email = email;
            this.PersonneContact = personneContact;
            this.Anamnese = anamnese;
            this.Commentaire = commentaire;
            this.PhotoUrl = photoUrl;
            this.Adresse = adresse;
            this.AdresseId = adresseId;

        }
        public int Id { get; set; }

        [Required(ErrorMessage = "Le nom du patient est requis.")]
        [StringLength(55)]
        [Display(Name = "Nom")]
        public string Nom { get; set; }

        [Required(ErrorMessage = "Le prénom du patient est requis.")]
        [StringLength(55)]
        [Display(Name = "Prénom")]
        public string Prenom { get; set; }

        [Required(ErrorMessage = "Date de naissance requise.")]
        [Display(Name = "Date de naissance")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateNaissance { get; set; }

        [Required(ErrorMessage = "Email du patient requis.")]
        [Display(Name = "Adresse Email")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "Téléphone fixe")]
        public int? TelFixe { get; set; }

        [Display(Name = "Gsm")]
        public int? Gsm { get; set; }

        [StringLength(55)]
        [Display(Name = "Personne de contact")]
        public string PersonneContact { get; set; }

        [Display(Name = "Téléphone personne de contact")]
        public int TelContact { get; set; }

        [Required(ErrorMessage = "Latéralité requise.")]
        [Display(Name = "Latéralité")]
        public String Lateralite { get; set; }

        [Required(ErrorMessage = "Pathologie requise.")]
        [Display(Name = "Pathologie")]
        public String Pathologie { get; set; }        

        [Required(ErrorMessage = "Anamnèse requise.")]
        [StringLength(2000)]
        [Display(Name = "Anamnèse")]
        public string Anamnese { get; set; }

        [StringLength(250)]
        [Display(Name = "Commentaire")]
        public string Commentaire { get; set; }

        public string PhotoUrl { get; set; }

        public Adresse Adresse { get; set; }

        [ForeignKey("Adresse")]
        public int AdresseId { get; set; }

        public Photo Photo { get; set; }

        [ForeignKey("Photo")]
        public int PhotoId { get; set; }
    }
}