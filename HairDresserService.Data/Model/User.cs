using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HairDresserService.Data.Model
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(100)]
        public string Surname { get; set; }
         
        [Required]
        public string SSN { get; set; }

        public IList<Contact> Contacts { get; set; }
    }
}
