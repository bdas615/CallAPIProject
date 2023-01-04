using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Models
{
    public class GetAllDetails
    {
        [Required]
        public string TokenKey { get; set; } = "A12F7A58-842D-4111-A44D-5F8C4E1AA521";

        [Required]
        public int DevId { get; set; }
    }
}
