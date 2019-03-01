using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Entities.Base;


namespace App.Domain.Services.Interfaces
{
    public interface ITxClienteService
    {
        IEnumerable<TxCliente> GetAll(string nombre);
        bool Save(TxCliente entity);
        TxCliente GetById(int id);
    }
}
