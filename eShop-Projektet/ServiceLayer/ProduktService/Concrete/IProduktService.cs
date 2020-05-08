using Datalayer.Entities;
using System.Linq;

namespace ServiceLayer.ProduktService.Concrete
{
    public interface IProduktService
    {
        IQueryable<ProduktDto> GetProdukts();
        IQueryable<kategori> GetKategorier();
        IQueryable<Producent> GetProducenter();
        IQueryable<ProduktDto> SortFilterPage(SortFilterPageOptions options);
        ProduktDto GetProduktById(int produktId);
        ProduktDto Update(ProduktDto updatedProdukt);
        ProduktDto Delete(int produktId);
        ProduktDto Create(ProduktDto newProdukt);
    }
}