using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datamodel.Models
{
    public class ErrorLog
    {
        public int Id { get; set; }
        public String? Error { get; set; }
        
        public DateTime? TimeCreated { get; set; }
    }    
}
