using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Entities.Base;


namespace App.Domain.Services.Interfaces
{
   public interface ILgProveedorService
    {
        IEnumerable<LgProveedor> GetAll(string nombre);
        bool Save(LgProveedor entity);
        LgProveedor GetById(int id);
    }
}
