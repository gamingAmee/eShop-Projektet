using System;
using System.Collections.Generic;
using System.Text;
using ServiceLayer.ProduktService;

namespace ServiceLayer.OrderService
{
    public class OrderDto
    {
        public List<ProduktDto> Produkts { get; set; }

        public OrderDto()
        {
            Produkts = new List<ProduktDto>();
        }
    }
}
