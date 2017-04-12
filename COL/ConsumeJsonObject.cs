using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chr.OnlineApp.COL
{
    public class ConsumeJsonObject
    {
        public int consumeId { get; set; }

        public int tableId { get; set; }

        public int frombookId { get; set; }

        public string username { get; set; }

        public List<Foods> foods { get; set; }

        public List<Coupons> coupons { get; set; }

        public int isMember { get; set; }

        public string memberCardNo { get; set; }

        public double totalPrice { get; set; }

        public double priceOff { get; set; }

        public double discount { get; set; }

        public double actualTotalPrice { get; set; }

        public string serviceNo { get; set; }

        public int payment { get; set; }
    }

    public class Foods
    {
        public int productId { get; set; }

        public int cnt { get; set; }

    }

    public class Coupons
    {
        public int typeId { get; set; }

        public int cnt { get; set; }

        public double amount { get; set; }

        public string no { get; set; }
    }
}
