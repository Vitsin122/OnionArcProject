using OnionArcProject.Domain.Models;
using OnionArcProject.Infrastruct.Data.DBContext;
using OnionArcProject.Interfaces.RepositoryInterfaces;

namespace OnionArcProject.Infrastruct.Data.Repositories
{
    public class VenderRepository : IVenderRepository
    {
        private SimpleTestDbContext _context;
        public VenderRepository(SimpleTestDbContext _context)
        {
            this._context = _context;
        }
        public Guid CreateVender(Vender vender)
        {
            _context.Venders.Add(vender);
            return vender.Id;
        }

        public bool DeleteVender(Guid id)
        {
            throw new NotImplementedException();
        }

        public ICollection<Vender> GetAll()
        {
            throw new NotImplementedException();
        }

        public Vender? GetById(Guid id)
        {
            return _context.Venders.FirstOrDefault(x => x.Id == id);
        }

        public bool UpdateVender(Vender vender)
        {
            throw new NotImplementedException();
        }
    }
}
