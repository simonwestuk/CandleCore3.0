using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Candlev4.Models
{
    public class Candle
    {
        [Key]
        public int id { get; set; }

        public string desc { get; set; }

        public double price { get; set; }

    }
}
