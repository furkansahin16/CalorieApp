using Base.Entities;
using Entities.Concrete;

namespace Entities.Dtos.Meal
{
    public class MealCreateDTO : IDto
    {
        public string MealTypeName { get; set; }
        public string UserName { get; set; }
    }
}
