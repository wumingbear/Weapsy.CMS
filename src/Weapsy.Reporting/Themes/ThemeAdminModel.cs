﻿using System;
using Weapsy.Domain.Model.Themes;

namespace Weapsy.Reporting.Themes
{
    public class ThemeAdminModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Folder { get; set; }
        public int SortOrder { get; set; }
        public ThemeStatus Status { get; set; }
    }
}
