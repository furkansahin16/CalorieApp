using Base.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos.ProductTypes
{
    public class ProductTypeDeleteDto : IDto
    {
        public int Id { get; set; }
        public string ProductTypeName { get; set; }
    }
}
