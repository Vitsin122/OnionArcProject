using OnionArcProject.Domain.Models;
using OnionArcProject.Interfaces.ServiceInterfaces;
using OnionArcProject.Infrastruct.Data;
using OnionArcProject.Infrastruct.Data.Repositories;
using OnionArcProject.Infrastruct.Data.DBContext;
using OnionArcProject.Interfaces.RepositoryInterfaces;

namespace OnionArcProject.Infrastruct.Services
{
    public class ServiceZatichka1 : IServiceZatichka1
    {
        private UnitOfWork unitOfWork;
        public ServiceZatichka1(SimpleTestDbContext _context, IGpuRepository gpuRepository, IVenderRepository venderRepository)
        {
            unitOfWork = new UnitOfWork(_context, gpuRepository, venderRepository);
        }
        //Create Scufidon
        public void CreateVender(Vender vender)
        {
            unitOfWork.VenderRepository.CreateVender(vender);
            unitOfWork.Save();
        }
    }
}
