﻿using Moq;
using NUnit.Framework;
using System;
using Weapsy.Core.Caching;
using Weapsy.Domain.Model.Themes;
using Weapsy.Reporting.Data.Themes;
using Weapsy.Reporting.Themes;

namespace Weapsy.Reporting.Data.Default.Tests
{
    [TestFixture]
    public class ThemeFacadeTests
    {
        private IThemeFacade sut;
        private Guid themeId;

        [SetUp]
        public void Setup()
        {
            themeId = Guid.NewGuid();

            var themeRepositoryMock = new Mock<IThemeRepository>();
            var cacheManagerMock = new Mock<ICacheManager>();

            var mapperMock = new Mock<AutoMapper.IMapper>();
            mapperMock.Setup(x => x.Map<ThemeAdminModel>(It.IsAny<Theme>())).Returns(new ThemeAdminModel());

            sut = new ThemeFacade(themeRepositoryMock.Object, cacheManagerMock.Object, mapperMock.Object);
        }
    }
}
