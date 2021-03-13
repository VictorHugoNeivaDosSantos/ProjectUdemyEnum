using System;
using System.Collections.Generic;
using System.Text;
using ProjectUdemyEnum.Entities.Enums;

namespace ProjectUdemyEnum.Entities
{
    class Order
    {
        public int IdOrder { get; set; }
        public DateTime DateOrder { get; set; }

        public OrderStatus Status { get; set; }

        public Order(int idPedido, DateTime date, string status)
        {

            IdOrder = idPedido;
            date = date;
            Status = Enum.Parse<OrderStatus>(status);

        }

        public override string ToString()
        {
            return IdOrder + "," + DateOrder+", "+Status ;
        }


    }


}
