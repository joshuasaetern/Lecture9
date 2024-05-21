using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture9
{
    internal class Order
    {
        //Fields
        String orderName;
        bool isOverNight;
        bool isPerishable;

        //Constructors
        public Order(String orderName, bool isOverNight, bool isPerishable)
        {
            this.orderName = orderName;
            this.isOverNight = isOverNight;
            this.isPerishable = isPerishable;
        }

        //Properties
        public string OrderName { get => orderName; set => orderName = value; }
        public bool IsOverNight { get => isOverNight; set => isOverNight = value; }
        public bool IsPerishable { get => isPerishable; set => isPerishable = value; }

        //Methods
        public override String ToString()
        {
            return $"Name: {this.orderName}\nOvernight delivery: {this.isOverNight}\nPerishable: {this.isPerishable}";
        }

    }
}
