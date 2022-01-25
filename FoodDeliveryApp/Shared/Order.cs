using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryApp.Shared
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDateTime { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public int BranchId { get; set; }
        public virtual Branch Branch { get; set; }
    }
}
