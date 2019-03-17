﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Entities.Base;



namespace App.Domain.Services.Interfaces
{
    public interface ILgItemService
    {

        IEnumerable<LgItem> GetAll(string nombre);
        bool Save(LgItem entity);
        LgItem GetById(string id);

    }
}
