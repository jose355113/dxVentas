using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Entities.Base;



namespace App.Domain.Services.Interfaces
{
    public interface ILgFamIteService
    {
        IEnumerable<LgFamIte> GetAll(string nombre);
        bool Save(LgFamIte entity);
        LgFamIte GetById(int id);
    }
}
