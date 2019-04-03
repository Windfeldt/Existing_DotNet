using Microsoft.Azure.Mobile.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace drinkmorecoffeeService.DataObjects
{
    public class CupOfCoffee : EntityData
    {
        public DateTime DateUtc { get; set; }
        public bool MadeAtHome { get; set; }
        public string os { get; set; }
    }
}