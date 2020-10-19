using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.BusinessLayer
{
    class OrderItem
    {
        public OrderItem()
        {

        }
        public OrderItem(int orderItemId)
        {
            orderItemId = orderItemId;
        }
        public int OrderItemId { get; private set; }
        public string ProductId { get; private set; }
        public decimal? PurchasePrice { get; set; }
        public int Quantity { get; set; }

    }
}
