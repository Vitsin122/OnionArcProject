using OnionArcProject.Domain.Models;

namespace OnionArcProject.Interfaces.RepositoryInterfaces
{
    public interface IGpuRepository
    {
        //Search by id
        Gpu? GetById(Guid id);
        //Get all Gpus
        ICollection<Gpu> GetAll();
        //Create Gpu
        Guid CreateGPU(Gpu gpu);
        //Update Gpu
        bool UpdateGPU(Gpu gpu);
        //Delete Gpu
        bool DeleteGPU(Guid id);
    }
}
