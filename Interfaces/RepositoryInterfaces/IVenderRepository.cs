using OnionArcProject.Domain.Models;
using OnionArcProject.Domain.ModelsDTO;

namespace OnionArcProject.Interfaces.RepositoryInterfaces
{
    public interface IVenderRepository
    {
        //Search by id
        Vender? GetById(Guid id);
        //Get all Venders
        ICollection<Vender> GetAll();
        //Create Vender
        Guid CreateVender(Vender vender);
        //Update Vender
        bool UpdateVender(Vender vender);
        //Delete Vender
        bool DeleteVender(Guid id);
    }
}
