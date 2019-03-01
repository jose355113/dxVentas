using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Data.Repository;
using App.Domain.Services.Interfaces;
using App.Entities.Base;

namespace App.Domain.Services
{
    public class TxClienteService : ITxClienteService
    {
        public IEnumerable<TxCliente> GetAll(string nombre)
        {
            List<TxCliente> result;

            using (var unitOfWork = new AppUnitOfWork())
            {
                result = unitOfWork.TxClienteRepository.GetAll(
                    item => item.Nom_Cliente.Contains(nombre)
                    ).ToList();
            }

            return result;
        }

        public TxCliente GetById(int id)
        {

            TxCliente result;

            using (var unitOfWork = new AppUnitOfWork())
            {
                result = unitOfWork.TxClienteRepository.GetById(id);
            }

            return result;
        }

        public bool Save(TxCliente entity)
        {

            bool result = false;

            try
            {

                using (var unitOfWork = new AppUnitOfWork())
                {

                    if (entity.Cod_Cliente_Tex == "")//registro nuevo
                    {
                        unitOfWork.TxClienteRepository.Add(entity);
                    }
                    else
                    {
                        unitOfWork.TxClienteRepository.Update(entity);
                    }

                    unitOfWork.Complete();

                }

                result = true;
            }
            catch (Exception ex)
            {
                return false;
            }

            return result;
        }
    }
}
