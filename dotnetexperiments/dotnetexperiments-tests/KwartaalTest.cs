using System;
using System.Collections.Generic;
using System.Linq;
using dotnetexperiments;
using FluentAssertions;
using NUnit.Framework;

namespace dotnetexperiments_tests
{
    [TestFixture]
    public class KwartaalTest
    {
        [Test]
        public void Kwartaal_ToString()
        {
            var kwartaal = new Kwartaal(2018, 1);
            Assert.AreEqual("2018/1", kwartaal.ToString());
        }

        [Test]
        public void KwartaalByDate_ToString()
        {
            var kwartaal = new Kwartaal(new DateTime());
            Assert.AreEqual("2018/1", kwartaal.ToString());
        }

        //TODO test all methods of kwartaal class



        [Test]
        public void Kwartaal_FindMaximumKwartaal()
        {
            var kwartalen = new List<Kwartaal>()
            {
                new Kwartaal(2018, 1),
                new Kwartaal(2018, 2),
                new Kwartaal(2018, 3),
                new Kwartaal(2017, 2),
                new Kwartaal(2019, 1),
            };

            kwartalen.Max().Should().Be(new Kwartaal(2019, 1));

        }
    }
}
