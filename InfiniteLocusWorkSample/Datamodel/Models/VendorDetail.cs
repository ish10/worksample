using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datamodel.Models
{
   public class VendorDetail
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string DisplayName { get; set; }
        public string? Description { get; set; }
        public string? FamilyName { get; set; }

        public string? PrimaryEmailAddress { get; set; }

    }
}
