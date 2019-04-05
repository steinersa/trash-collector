using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        public string Zip { get; set; }

        [Display(Name = "Extra Pickup Request")]
        [DataType (DataType.Date)]
        public DateTime ? ExtraPickup { get; set; }

        [Display(Name = "Temporarily Suspend Start Date")]
        [DataType(DataType.Date)]
        public DateTime ? TempSuspendStart { get; set; }

        [Display(Name = "Temporarily Suspend End Date")]
        [DataType(DataType.Date)]
        public DateTime ? TempSuspendEnd { get; set; }

        [Display(Name = "Balance")]
        public double Balance { get; set; }

        [ForeignKey("Day")]
        [Display(Name = "Pickup Day")]
        public int DayId { get; set; }
        public Day Day { get; set; }

        public IEnumerable<Day> Days { get; set; }
    }
}