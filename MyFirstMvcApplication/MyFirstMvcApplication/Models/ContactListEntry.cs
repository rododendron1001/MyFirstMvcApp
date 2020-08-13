using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MyFirstMvcApplication.Models
{
    public class ContactListEntry
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public ContactType ContactType { get; set; }

        [Required]
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DateOfBirth { get; set; }

        [StringLength(50)]
        public string PhoneNumber { get; set; }

        [StringLength(50)]
        public string Email { get; set; }
           
    }

    
}
