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
    public class LgProveedorService : ILgProveedorService

    {
        public IEnumerable<LgProveedor> GetAll(string nombre)
        {
            List<LgProveedor> result;

            using (var unitOfWork = new AppUnitOfWork())
            {
                result = unitOfWork.LgProveedorRepository.GetAll(
                    item => item.Des_Proveedor.Contains(nombre)
                    ).ToList();
            }

            return result;
        }

        public LgProveedor GetById(int id)
        {
            LgProveedor result;

            using (var unitOfWork = new AppUnitOfWork())
            {
                result = unitOfWork.LgProveedorRepository.GetById(id);
            }

            return result;
        }

        public bool Save(LgProveedor entity)
        {
            bool result = false;

            try
            {

                using (var unitOfWork = new AppUnitOfWork())
                {

                    if (entity.Cod_Proveedor  == "")//registro nuevo
                    {
                        unitOfWork.LgProveedorRepository.Add(entity);
                    }
                    else
                    {
                        unitOfWork.LgProveedorRepository.Update(entity);
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
