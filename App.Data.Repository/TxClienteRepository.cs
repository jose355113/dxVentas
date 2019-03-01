using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Data.Repository.Interfaces;
using App.Entities.Base;
using System.Data.Entity;


namespace App.Data.Repository
{
    public class TxClienteRepository : GenericRepository<TxCliente>,ITxClienteRepository
    {
        public TxClienteRepository(DbContext context) : base(context)
        {

        }
    }
}
