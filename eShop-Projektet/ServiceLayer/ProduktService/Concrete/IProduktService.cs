using Datalayer.Entities;
using System.Linq;

namespace ServiceLayer.ProduktService.Concrete
{
    public interface IProduktService
    {
        IQueryable<ProduktDto> GetProdukts();
        IQueryable<ProduktDto> SortFilterPage(SortFilterPageOptions options);
        ProduktDto GetProduktById(int restaurantId);
    }
}