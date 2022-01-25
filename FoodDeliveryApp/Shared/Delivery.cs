using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryApp.Shared
{
    public class Delivery
    {
        public int Id { get; set; }
        public DateTime DeliveryDateTime { get; set; }
        public string DeliveryAddress { get; set; }
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }
    }
}
