using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Candlev4.Properties.Models
{
    public class Candle
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string desc { get; set; }

        [Required]
        public double price { get; set; }
    }
}
