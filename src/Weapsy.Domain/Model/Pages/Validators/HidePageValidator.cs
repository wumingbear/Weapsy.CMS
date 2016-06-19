﻿using FluentValidation;
using System;
using Weapsy.Domain.Model.Pages.Commands;
using Weapsy.Domain.Model.Sites.Rules;

namespace Weapsy.Domain.Model.Pages.Validators
{
    public class HidePageValidator : AbstractValidator<HidePage>
    {
        private readonly ISiteRules _siteRules;

        public HidePageValidator(ISiteRules siteRules)
        {
            _siteRules = siteRules;

            RuleFor(c => c.SiteId)
                .NotEmpty().WithMessage("Site id is required.")
                .Must(BeAnExistingSite).WithMessage("Site does not exist.");
        }

        private bool BeAnExistingSite(Guid siteId)
        {
            return _siteRules.DoesSiteExist(siteId);
        }
    }
}