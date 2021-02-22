using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Guns_of_the_Old_West.Models
{
    public class Speler
    {
        [DisplayName("Voornaam")]
        [Required(ErrorMessage = "Dit veld is verplicht.")]
        public string Voornaam { get; set; }
        
        [DisplayName("Naam")]
        [Required(ErrorMessage = "Dit veld is verplicht.")]
        public string Naam { get; set; }
        
        [DisplayName("Email")]
        [Required(ErrorMessage = "Dit veld is verplicht.")]
        [EmailAddress(ErrorMessage = "Ongeldig email adres.")]
        public string Email { get; set; }
        
        [DisplayName("Telefoonnummer")]
        [Required(ErrorMessage = "Dit veld is verplicht.")]
        [StringLength(50, MinimumLength = 7,ErrorMessage = "Telefoonnummer moet minimum 7 cijfers bevatten.")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Telefoonnummer mag enkel uit cijfers bestaan.")]
        public string Telefoon { get; set; }
        public int Counter { get; set; }
    }
}