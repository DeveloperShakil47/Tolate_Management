using RentManagement.Utilities.Constants;
using System.ComponentModel.DataAnnotations;

namespace RentManagement.Domain.Models
{
    public class City
    { /// <summary>
    /// Primery Key of  cities entitis
    /// </summary>
        [Key]
        public int CID { get; set; }

        /// <summary>
        /// City Name of master table.
        /// </summary>
        [Required(ErrorMessage = MassageConstants.RequerdFileError)]
        [StringLength(60)]
        [Display(Name ="City Name")]
        public string CityName { get; set; }
        //public virtual List<Advert> Adverts { get; set; }
    }
}