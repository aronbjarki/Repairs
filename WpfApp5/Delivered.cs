using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp5
{
    class Delivered
    {
        [Key]
        public string Name { get; set; }
        [Required]
        public string Kennitala { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public string Tegund { get; set; }
        public string Aukahlutir { get; set; }
        public string Password { get; set; }
        public string Bilunarlýsing { get; set; }
    }
}
