using Base.Entities;

namespace Entities.Dtos.ProductTypes
{
    public class ProductTypeCreateDto :IDto
    {
        public string ProductTypeName { get; set; }
    }
}
