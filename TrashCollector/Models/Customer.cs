using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Display (Name = "First Name") ]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Address")]
        public string Address { get; set; }
        [Display(Name = "ZipCode")]
        public int ZipCode { get; set; }
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

        [ForeignKey("Payment")]
        [Display(Name = "Account Number")]
        public int PaymentId { get; set; }
        [Display(Name ="Amount Owed")]
        public double AmountOwed { get; set; }

        [ForeignKey("Calendar")]
        [Display(Name = "Calendar Year")]
        public int CalendarId { get; set; }
        [Display(Name = "Disposal Pickup Day")]
        public DateTime ScheduledPickUp { get; set; }
        [Display(Name = "Special Disposal Pickup")]
        public DateTime SpecialPickUp { get; set; }
    }
}
