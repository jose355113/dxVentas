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
    public class LgItemService : ILgItemService
    {
        public IEnumerable<LgItem> GetAll(string nombre)
        {
            List<LgItem> result;

            using (var unitOfWork = new AppUnitOfWork())
            {
                result = unitOfWork.LgItemRepository.GetAll(
                    item => item.Des_Item.Contains(nombre)
                    ).ToList();
            }

            return result;
        }

        public LgItem GetById(string id)
        {

            LgItem result;

            using (var unitOfWork = new AppUnitOfWork())
            {
                result = unitOfWork.LgItemRepository.GetById(id);
            }

            return result;

        }

        //public bool Remove(LgItem entity)
        //{

        //    bool result=false;

        //    using (var unitOfWork = new AppUnitOfWork())
        //    {
        //        result = unitOfWork.LgItemRepository.Remove(entity);
        //        unitOfWork.Complete();
        //    }
            
        //    return result;
        //}

        public bool Save(LgItem entity)
        {

            bool result = false;

            try
            {

                using (var unitOfWork = new AppUnitOfWork())
                {

                    if (entity.Cod_Item  == "")//registro nuevo
                    {
                        unitOfWork.LgItemRepository.Add(entity);
                    }
                    else
                    {
                        unitOfWork.LgItemRepository.Update(entity);
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
