using OnionArcProject.Domain.Models;
using OnionArcProject.Domain.ModelsDTO;

namespace OnionArcProject.Interfaces.RepositoryInterfaces
{
    internal interface IGpuRepository
    {
        //Search by id
        Gpu GetById(Guid id);
        //Get all Gpus
        ICollection<Gpu> GetAll();
        //Create Gpu
        Guid CreateGPU(GpuModelDTO gpuDTO);
        //Update Gpu
        bool UpdateGPU(GpuModelDTO gpuDTO);
        //Delete Gpu
        bool DeleteGPU(Guid id);
    }
}
