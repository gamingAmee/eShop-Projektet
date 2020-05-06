using Datalayer.Entities;
using System.Linq;

namespace ServiceLayer.ProduktService.Concrete
{
    public interface IListProduktService
    {
        IQueryable<ProduktListDto> GetProdukts();
        IQueryable<ProduktListDto> SortFilterPage(SortFilterPageOptions options);
        //Produkt GetProduktById(int restaurantId);
    }
}