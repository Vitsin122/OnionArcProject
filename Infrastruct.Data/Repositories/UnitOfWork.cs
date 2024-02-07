using Microsoft.EntityFrameworkCore.Diagnostics;
using OnionArcProject.Infrastruct.Data.DBContext;
using OnionArcProject.Interfaces.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArcProject.Infrastruct.Data.Repositories
{
    public class UnitOfWork : IDisposable
    {
        private SimpleTestDbContext _context;
        private IGpuRepository _gpuRepository;
        private IVenderRepository _VenderRepository;

        public UnitOfWork(SimpleTestDbContext _context, IGpuRepository gpuRepository, IVenderRepository venderRepository)
        {
            this._context = _context;
            _gpuRepository = gpuRepository;
            _VenderRepository = venderRepository;
        }
        public IGpuRepository GpuRepository { get { return _gpuRepository; } }
        public IVenderRepository VenderRepository { get { return _VenderRepository; } }

        public void Save()
        {
            _context.SaveChanges();
        }
        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
