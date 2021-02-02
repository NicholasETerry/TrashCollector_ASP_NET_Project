using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class Payment
    {
        [Key]
        [Display(Name ="Acount Number")]
        public int Id { get; set; }
        [Display(Name = "Balance Due")]
        public double AmountOwed { get; set; }
    }
}
