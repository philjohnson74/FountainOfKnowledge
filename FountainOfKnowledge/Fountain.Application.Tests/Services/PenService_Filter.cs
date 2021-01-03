using AutoMapper;
using Fountain.Application.AutoMapper;
using Fountain.Application.Filters;
using Fountain.Application.Interfaces;
using Fountain.Application.Services;
using Fountain.Application.ViewModels;
using Fountain.Domain.Core.Bus;
using Fountain.Domain.Interfaces;
using Fountain.Domain.Models;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fountain.Application.Tests.Services
{
    [TestFixture]
    public class PenService_Filter
    {
        IQueryable<Pen> _listOfPens;
        IMapper _mapper;
        IPenRepository _mockPenRepository;
        IMediatorHandler _bus;
        IPenService _penService;

        [SetUp]
        public void SetUp()
        {
            SetupAutoMapper();
            SetUpListOfPens();
            SetUpCommonMocks();
            _penService = new PenService(_mockPenRepository, _bus, _mapper);
        }

        private void SetupAutoMapper()
        {
            var mapperConfiguration = AutoMapperConfiguration.RegisterMappings();
            _mapper = mapperConfiguration.CreateMapper();
        }

        private void SetUpListOfPens()
        {
            var listOfPens = new List<Pen>();
            listOfPens.Add(new Pen()
            {
                Manufacturer = "Montblanc",
                Model = "Meisterstuck No 149"
            });
            listOfPens.Add(new Pen()
            {
                Manufacturer = "Pelikan",
                Model = "M1000"
            });
            listOfPens.Add(new Pen()
            {
                Manufacturer = "Pelikan",
                Model = "M800"
            });
            _listOfPens = listOfPens.AsQueryable<Pen>();
        }

        private void SetUpCommonMocks()
        {
            var penRepository = new Mock<IPenRepository>();
            penRepository.Setup(x => x.GetPens()).Returns(_listOfPens);
            _mockPenRepository = penRepository.Object;

            _bus = new Mock<IMediatorHandler>().Object;
        }

        [Test]
        public void FilterExists_Manufacturer_Montblanc_ReturnsOnePen()
        {
            //  Arrange
            var penServiceFilterMontblanc = new PenServiceFilter()
            {
                Manufacturer = "Montblanc"
            };     

            //  Act
            var pens = _penService.GetPens(penServiceFilterMontblanc);

            //  Assert
            Assert.AreEqual(1, pens.Count());
        }

        [Test]
        public void FilterExists_Manufacturer_Montblanc_ReturnsMontblancPen()
        {
            //  Arrange
            var penServiceFilterMontblanc = new PenServiceFilter()
            {
                Manufacturer = "Montblanc"
            };

            //  Act
            var pens = _penService.GetPens(penServiceFilterMontblanc);

            //  Assert
            Assert.AreEqual("Montblanc", pens.First().Manufacturer);
        }

        [Test]
        public void FilterExists_Manufacturer_Pelikan_ReturnsTwoPens()
        {
            //  Arrange
            var penServiceFilterPelikan = new PenServiceFilter()
            {
                Manufacturer = "Pelikan"
            };

            //  Act
            var pens = _penService.GetPens(penServiceFilterPelikan);

            //  Assert
            Assert.AreEqual(2, pens.Count());
        }

        [Test]
        public void FilterExists_Manufacturer_ConroyStewart_ReturnsNoPens()
        {
            //  Arrange
            var penServiceFilterConroyStewart = new PenServiceFilter()
            {
                Manufacturer = "Conroy Stewart"
            };

            //  Act
            var pens = _penService.GetPens(penServiceFilterConroyStewart);

            //  Assert
            Assert.AreEqual(0, pens.Count());
        }
    }
}
