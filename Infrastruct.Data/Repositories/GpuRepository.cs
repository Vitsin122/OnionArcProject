using OnionArcProject.Domain.Models;
using OnionArcProject.Infrastruct.Data.DBContext;
using OnionArcProject.Interfaces.RepositoryInterfaces;

namespace OnionArcProject.Infrastruct.Data.Repositories
{
    public class GpuRepository : IGpuRepository
    {
        private SimpleTestDbContext _context;
        public GpuRepository(SimpleTestDbContext _context)
        {
            this._context = _context;
        }
        public Guid CreateGPU(Gpu gpu)
        {
            _context.Gpus.Add(gpu);
            return gpu.Id;
        }

        public bool DeleteGPU(Guid id)
        {
            Gpu? gpu = _context.Gpus.FirstOrDefault(g => g.Id == id);

            if (gpu != null)
            {
                _context.Gpus.Remove(gpu);
                return true;
            }

            return false;
        }

        public ICollection<Gpu> GetAll()
        {
            return _context.Gpus.ToList();
        }

        public Gpu? GetById(Guid id)
        {
            return _context.Gpus.FirstOrDefault(g => g.Id == id);
        }

        public bool UpdateGPU(Gpu gpu)
        {
            Gpu? gpu1 = _context.Gpus.FirstOrDefault(gp => gp.Id == gpu.Id);

            if (gpu1 != null)
            {
                gpu1 = gpu;
                _context.Gpus.Update(gpu1);
                return true;
            }

            return false;
        }
    }
}
