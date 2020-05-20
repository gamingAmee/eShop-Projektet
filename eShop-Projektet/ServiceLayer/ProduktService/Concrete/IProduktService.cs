using Datalayer.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceLayer.ProduktService.Concrete
{
    public interface IProduktService
    {
        IQueryable<ProduktDto> GetProdukts();
        IQueryable<kategori> GetKategorier();
        IQueryable<Producent> GetProducenter();
        IQueryable<ProduktDto> SortFilterPage(SortFilterPageOptions options);
        Task<ProduktDto> GetProduktById(int produktId);
        Task<ProduktDto> Update(ProduktDto updatedProdukt);
        Task<ProduktDto> Delete(int produktId);
        Task<ProduktDto> Create(ProduktDto newProdukt);
    }
}