using System;
using System.Collections.Generic;
using Weapsy.Domain.Model.Menus;

namespace Weapsy.Domain.Data.Entities
{
    public class Menu : IDbEntity
    {
        public Guid Id { get; set; }
        public Guid SiteId { get; set; }
        public string Name { get; set; }
        public MenuStatus Status { get; set; }

        public ICollection<MenuItem> MenuItems { get; set; } = new HashSet<MenuItem>();

        public virtual Site Site { get; set; }
    }
}