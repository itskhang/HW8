using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW8.Models
{
    public class Animal
    {
        public int AnimalID { get; set; }
        public string AnimalName { get; set; }
        public string AnimalDescription { get; set; }
        public DateTime DateReceived { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }


    }
}