using OnionArcProject.Domain.Models;
using OnionArcProject.Domain.ModelsDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArcProject.Interfaces.RepositoryInterfaces
{
    internal interface IVenderRepository
    {
        //Search by id
        Vender GetById(Guid id);
        //Get all Venders
        ICollection<Vender> GetAll();
        //Create Vender
        Guid CreateVender(VenderModelDTO venderDTO);
        //Update Vender
        bool UpdateVEnder(VenderModelDTO venderDTO);
        //Delete Vender
        bool DeleteVender(Guid id);
    }
}
