using RentManagement.Utilities.Constants;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RentManagement.Domain.Models
{
    public class Advert:BaseModel
    {
        /// <summary>
        /// primery Key of Adverts entities.
        /// </summary>
        [Key]
        public Guid AdvartID { get; set; }

        /// <summary>
        /// Description of Tolate Rent house.
        /// </summary>
        [Required(ErrorMessage = MassageConstants.RequerdFileError)]
        [StringLength(500)]
        [DataType(DataType.MultilineText)]
        [Display(Name ="Poperty descriptions.")]
        public string Descriptions { get; set; }

        /// <summary>
        /// Contact Email address of property owner.
        /// </summary>
        [Required(ErrorMessage = MassageConstants.RequerdFileError)]
        [StringLength (60)]
        [Display(Name ="Enter your Email Address")]
        public string AdvertEmail { get; set; }

        /// <summary>
        /// AvailableDate of property.
        /// </summary>
       
        [Column(TypeName = "smalldatetime")]
        public DateTime AvailableDate { get; set; }

        /// <summary>
        /// Address of property.
        /// </summary>
        [Required(ErrorMessage = MassageConstants.RequerdFileError)]
        [StringLength(300)]
        [DataType(DataType.MultilineText)]
        [Display(Name ="Enter your Address")]
        public string Address { get; set; }

        /// <summary>
        /// The Key of master table.
        /// </summary>
        public int CID { get; set; }

        [ForeignKey("CID")]

        public virtual City City { get; set; }

    }
}