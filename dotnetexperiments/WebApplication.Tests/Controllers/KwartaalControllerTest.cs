using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.Results;
using dotnetexperiments;
using FluentAssertions;
using NSubstitute;
using NUnit.Framework;
using WebApplication.Controllers;
using WebApplication.Services;

namespace WebApplication.Tests.Controllers
{
    [TestFixture]
    public class KwartaalControllerTest
    {
        private KwartaalController _controller;
        private IKwartaalService _service;

        [SetUp]
        public void Setup()
        {
            _service = Substitute.For<IKwartaalService>();
            _controller = new KwartaalController(_service);
        }


        [Test]
        public void GetHuidigKwartaal()
        {
            _service.GetHuidigKwartaal().Returns(new Kwartaal(2016, 1));

            var result = (OkNegotiatedContentResult<Kwartaal>) _controller.HuidigKwartaal();
            result.Content.Should().Be(new Kwartaal(2016, 1));
        }

        [Test]
        public void IsHuidigKwartaal()
        {
            _service.IsHuidigKwartaal(new Kwartaal(2018,1)).Returns(true);

            _controller.IsHuidigKwartaal(new Kwartaal(2018,1)).Should().BeOfType<OkResult>();
        }

        [Test]
        public void IsNotHuidigKwartaal()
        {
            _service.IsHuidigKwartaal(Arg.Any<Kwartaal>()).Returns(false);

            _controller.IsHuidigKwartaal(new Kwartaal(2018,4)).Should().BeOfType<BadRequestResult>();
        }
    }
}
