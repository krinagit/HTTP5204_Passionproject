

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Passionproject2.Models.ViewModel
{//reference:This code is done by reviewing christine's code 
    public class ShowOrder
    {
        //information about a signle order
        public Order Order { get; set; }

        //information about multiple Customers
        public List<Customer> Customers { get; set; }
    }

  
}
