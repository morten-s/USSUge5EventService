using System.ComponentModel.DataAnnotations.Schema;

namespace USSUge5EventService.Controllers
{
    public record Order(string PizzaTopping, int PizzaNumber, int TableNumber);
}
