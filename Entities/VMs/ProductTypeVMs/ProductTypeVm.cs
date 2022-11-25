using Base.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.VMs.ProductTypeVMs
{
    public class ProductTypeVm:IViewModel
    {
        public int Id { get; set; }
        public string ProductTypeName { get; set; }
        public override string ToString()
        {
            return this.ProductTypeName;
        }
    }
}
