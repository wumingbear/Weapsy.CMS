﻿using System;
using Weapsy.Core.Domain;

namespace Weapsy.Domain.Model.ModuleTypes.Rules
{
    public interface IModuleTypeRules : IRules<ModuleType>
    {
        bool DoesModuleTypeExist(Guid id);
        bool IsModuleTypeIdUnique(Guid id);
        bool IsModuleTypeNameValid(string name);
        bool IsModuleTypeNameUnique(string name, Guid id = new Guid());
        bool IsModuleTypeViewComponentNameUnique(string viewName, Guid id = new Guid());
        bool IsModuleTypeInUse(Guid id);
    }
}
