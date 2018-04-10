using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; 

namespace HairDresserService.Data.Model
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string Street { get; set; }

        [Required]
        [StringLength(150)]
        public string City { get; set; }

        [Required]
        [StringLength(150)]
        public string Region { get; set; }

        [Required]
        [StringLength(150)]
        public string Country { get; set; }

        [Required]
        [StringLength(50)]
        public string PhoneNumber { get; set; }

        public User User { get; set; }
    }
}
