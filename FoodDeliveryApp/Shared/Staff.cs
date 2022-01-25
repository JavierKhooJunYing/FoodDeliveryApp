using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryApp.Shared
{
    public class Staff
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string ContactNumber { get; set; }
        public int BranchId { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual List<Order> Orders { get; set; }
        public virtual List<Delivery> Deliveries { get; set; }
    }
}
