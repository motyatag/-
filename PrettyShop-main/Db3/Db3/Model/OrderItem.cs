using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Db3.Model
{
    public class OrderItem
    {
        public string ProductName { get; set; }
        public string Quantity { get; set; }
        public int QuantityControl { get; set; }

        public OrderItem(string productName, string quantity, int quantityControl)
        {
            ProductName = productName;
            Quantity = quantity;
            QuantityControl = quantityControl;
        }
    }

}
