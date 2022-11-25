using Base.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos.Product
{
    public class ProductDeleteDto:IDto
    {
        public int Id { get; set; }
    }
}
