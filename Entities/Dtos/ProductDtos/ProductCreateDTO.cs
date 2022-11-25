using Base.Entities;

namespace Entities.Dtos.Product
{
    public class ProductCreateDTO : IDto
    {
        public string ProductName { get; set; }
        public double UnitCalorie { get; set; }
        public string ProductType { get; set; }
        public byte[] Image { get; set; }
        public bool isActive { get; set; }
    }
}
