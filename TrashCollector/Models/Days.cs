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
        SelectListItem Monday = new SelectListItem() { Text = "Monday", Value = "0", Selected = true };
        SelectListItem Tuesday = new SelectListItem() { Text = "Tuesday", Value = "1", Selected = false };
        SelectListItem Wednesday = new SelectListItem() { Text = "Wednesday", Value = "2", Selected = false };
        SelectListItem Thurday = new SelectListItem() { Text = "Thursday", Value = "3", Selected = false };
        SelectListItem Friday = new SelectListItem() { Text = "Friday", Value = "4", Selected = false };

    }
}
