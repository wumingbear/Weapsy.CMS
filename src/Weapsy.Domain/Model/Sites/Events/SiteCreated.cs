﻿using Weapsy.Core.Domain;

namespace Weapsy.Domain.Model.Sites.Events
{
    public class SiteCreated : Event
    {
        public string Name { get; set; }
        public SiteStatus Status { get; set; }
    }
}
