﻿using System;
using System.Collections.Generic;
using Weapsy.Core.Domain;

namespace Weapsy.Domain.Model.Menus
{
    public interface IMenuRepository : IRepository<Menu>
    {
        Menu GetById(Guid id);
        Menu GetById(Guid siteId, Guid id);
        Menu GetByName(Guid siteId, string name);
        ICollection<Menu> GetAll(Guid siteId);
        void Create(Menu menu);
        void Update(Menu menu);
    }
}
