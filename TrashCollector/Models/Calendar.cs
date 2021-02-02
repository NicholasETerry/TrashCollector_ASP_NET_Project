using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class Calendar
    {
        [Key]
        public int Id { get; set; }
        public DateTime ScheduledPickUp { get; set; }

        public DateTime SpecialPickUp { get; set; }
    }
}
