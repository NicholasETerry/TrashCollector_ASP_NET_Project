using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class Customers
    {
        [Key]
        public int Id { get; set; }
        [Display (Name = "First Name") ]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Address")]
        public string Address { get; set; }
        public string City { get; set; }
        [Display(Name = "Zip Code")]
        public int ZipCode { get; set; }
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

        [Display(Name ="Amount Owed")]
        public double AmountOwed { get; set; }

        [Display(Name = "Disposal Pickup Day")]
        [NotMapped]
        public SelectListItem ScheduledPickUp { get; set; }
        [Display(Name = "Special Disposal Pickup")]
        public DateTime SpecialPickUp { get; set; }
        [Display(Name = "Start Suspension Of Service")]
        public DateTime TempSuspendStart { get; set; }
        [Display(Name = "End Suspension Of Service")]
        public DateTime TempSuspendEnd { get; set; }

        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }
    }
}
