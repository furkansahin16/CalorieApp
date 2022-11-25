using Base.Entities;

namespace Entities.Dtos.ProductTypes
{
    public class ProductTypeUpdateDto : IDto
    {
        public int Id { get; set; }
        public string ProductTypeName { get; set; }
    }
}
