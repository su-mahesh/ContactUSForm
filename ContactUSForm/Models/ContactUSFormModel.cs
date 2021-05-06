using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ContactUSForm.Models
{
    public class ContactUSFormModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [RegularExpression("^[1-9][0-9]{9}$", ErrorMessage = "PhoneNumber must be numeric")]
        public long PhoneNumber { get; set; }
        public string Message { get; set; }
        public string ContactPurpose { get; set; }
    }
    public enum ContactPurpose
    {
        Information,
        Complaint,
        Other
    }
}
