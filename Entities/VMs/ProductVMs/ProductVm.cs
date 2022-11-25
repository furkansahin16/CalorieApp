using Base.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.VMs.ProductVMs
{
    public class ProductVm:IViewModel
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public double? UnitCalorie { get; set; }
        public string ProductTypeName { get; set; }
        public byte[] Image { get; set; }
        public bool isActive { get; set; }
        public override string ToString()
        {
            return this.ProductName;
        }
    }
}
