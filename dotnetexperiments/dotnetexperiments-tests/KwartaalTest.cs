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
            new Kwartaal(2018, 1).ToString().Should().Be("2018/1");
            new Kwartaal(2018, 2).ToString().Should().Be("2018/2");
            new Kwartaal(2018, 3).ToString().Should().Be("2018/3");
            new Kwartaal(2018, 4).ToString().Should().Be("2018/4");
            new Kwartaal(2019, 1).ToString().Should().Be("2019/1");
        }

        [Test]
        public void Kwartaal_KanGeenFoutKwartaalAanmaken()
        {
            Assert.Throws<ArgumentException>(() => new Kwartaal(2018, 0));
            Assert.Throws<ArgumentException>(() => new Kwartaal(2018, 5));
        }

        [Test]
        public void KwartaalByDate_ToString()
        {
            var kwartaal = new Kwartaal(DateTime.Now);
            Assert.AreEqual("2018/1", kwartaal.ToString());
        }

        [Test]
        public void Kwartaal_Equals()
        {
            new Kwartaal(2018, 1).Equals(new Kwartaal(2018,1)).Should().BeTrue();
            new Kwartaal(2018, 1).Equals(new Kwartaal(2018,2)).Should().BeFalse();
        }

        [Test]
        public void Kwartaal_Volgende()
        {
            new Kwartaal(2018, 1).Volgende().Should().Be(new Kwartaal(2018, 2));
            new Kwartaal(2018, 2).Volgende().Should().Be(new Kwartaal(2018, 3));
            new Kwartaal(2018, 3).Volgende().Should().Be(new Kwartaal(2018, 4));
            new Kwartaal(2018, 4).Volgende().Should().Be(new Kwartaal(2019, 1));
            new Kwartaal(2019, 1).Volgende().Should().Be(new Kwartaal(2019, 2));
        }

        [Test]
        public void Kwartaal_Vorige()
        {
            new Kwartaal(2018, 1).Vorige().Should().Be(new Kwartaal(2017, 4));
            new Kwartaal(2018, 2).Vorige().Should().Be(new Kwartaal(2018, 1));
            new Kwartaal(2018, 3).Vorige().Should().Be(new Kwartaal(2018, 2));
            new Kwartaal(2018, 4).Vorige().Should().Be(new Kwartaal(2018, 3));
            new Kwartaal(2019, 1).Vorige().Should().Be(new Kwartaal(2018, 4));
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
                null
            };

            kwartalen.Max().Should().Be(new Kwartaal(2019, 1));
        }

        [Test]
        public void Linq()
        {
            var nummers = new List<int>()
            {
                1,2,3,4,5,8
            };

            nummers.Any(n => n % 2 == 0).Should().BeTrue();

            nummers.Max().Should().Be(8);
            nummers.Where(n => n % 2 == 0).Should().ContainInOrder(2, 4, 8);
            nummers.Select(n => n * 2).Should().ContainInOrder(2, 4, 6, 8, 10, 16);
            nummers.Any().Should().BeTrue();
            nummers.Sum().Should().Be(23);

            nummers.First().Should().Be(1);
            nummers.Last().Should().Be(1);

            
        }
    }
}
