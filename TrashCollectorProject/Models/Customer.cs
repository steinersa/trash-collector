using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashCollectorProject.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Street")]
        public string Street { get; set; }

        [Display(Name = "City")]
        public string City { get; set; }

        [Display(Name = "State")]
        public string State { get; set; }

        [Display(Name = "Zip Code")]
        public int Zip { get; set; }

        [Display(Name = "Pickup Day")]
        public string PickupDay { get; set; }

        [Display(Name = "Extra Pickup Request")]
        public DateTime ExtraPickup { get; set; }

        [Display(Name = "Temporarily Suspend Start Date")]
        public DateTime TempSuspendStart { get; set; }

        [Display(Name = "Temporarily Suspend End Date")]
        public DateTime TempSuspendEnd { get; set; }

        [Display(Name = "Balance")]
        public double Balance { get; set; }
    }
}