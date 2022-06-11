using System.ComponentModel.DataAnnotations.Schema;

namespace RentManagement.Domain.Models
{
    /// <summary>
    /// Contains common properties for all models
    /// </summary>
    public class BaseModel
    {

        /// <summary>
        /// Entry the created date
        /// </summary>
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreatedDate { get; set; }
        /// <summary>
        /// Modified Date of the row.
        /// </summary>
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModifiedDate { get; set; }

    }
}