using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class Days
    {
        [Key]
        public int Id { get; set; }
        SelectListItem Monday { get; set; }
        SelectListItem Tuesday { get; set; }
        SelectListItem Wednesday { get; set; }
        SelectListItem Thurday { get; set; }
        SelectListItem Friday { get; set; }

    }
}
