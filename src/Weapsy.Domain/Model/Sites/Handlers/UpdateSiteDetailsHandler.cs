﻿using System.Collections.Generic;
using FluentValidation;
using Weapsy.Core.Domain;
using Weapsy.Domain.Model.Sites.Commands;
using System;

namespace Weapsy.Domain.Model.Sites.Handlers
{
    public class UpdateSiteDetailsHandler : ICommandHandler<UpdateSiteDetails>
    {
        private readonly ISiteRepository _siteRepository;
        private readonly IValidator<UpdateSiteDetails> _validator;

        public UpdateSiteDetailsHandler(ISiteRepository siteRepository,
            IValidator<UpdateSiteDetails> validator)
        {
            _siteRepository = siteRepository;
            _validator = validator;
        }

        public ICollection<IEvent> Handle(UpdateSiteDetails cmd)
        {
            var site = _siteRepository.GetById(cmd.SiteId);

            if (site == null)
                throw new Exception("Site not found");

            site.UpdateDetails(cmd, _validator);

            _siteRepository.Update(site);

            return site.Events;
        }
    }
}
