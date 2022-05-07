using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NKAYM.Models
{
    public class Slider
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength:35)]
        public string Title { get; set; }
        [Required]
        [StringLength(maximumLength: 120)]
        public string Description { get; set; }
        public string Image { get; set; }

        public string More{ get; set; }
        public int Order { get; set; }
    }
}
