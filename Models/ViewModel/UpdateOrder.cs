using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Passionproject2.Models.ViewModel
{//reference:This code is done by reviewing christine's code 
    public class UpdateOrder
    {
        //when we need to update an order
        //we need the Order info as well as a list of customer

        public Order Order { get; set; }
        public List<Customer> Customers { get; set; }
    }
}