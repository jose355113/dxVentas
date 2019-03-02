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
                                   
    public class LgFamIteService : ILgFamIteService
    {
        public IEnumerable<LgFamIte> GetAll(string nombre)
        {
            List<LgFamIte> result;

            using (var unitOfWork = new AppUnitOfWork())
            {
                result = unitOfWork.LgFamIteRepository.GetAll(
                    item => item.Des_Item.Contains(nombre)
                    ).ToList();
            }

            return result;
        }

        public LgFamIte GetById(int id)
        {

            LgFamIte result;

            using (var unitOfWork = new AppUnitOfWork())
            {
                result = unitOfWork.LgFamIteRepository.GetById(id);
            }

            return result;

        }

        public bool Save(LgFamIte entity)
        {

            bool result = false;

            try
            {

                using (var unitOfWork = new AppUnitOfWork())
                {

                    if (entity.cod_famitem== "")//registro nuevo
                    {
                        unitOfWork.LgFamIteRepository.Add(entity);
                    }
                    else
                    {
                        unitOfWork.LgFamIteRepository.Update(entity);
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
