using JonSnow.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;

namespace JonSnow.Unit.Tests
{
    public class HashwordSpec : BaseSpec
    {
        [Test]
        public void ShouldHideTheRealValue()
        {
            var pwd = new Hashword("test");
            pwd.ToString().Should().NotContain("test");
        }

        [Test]
        public void ShouldCompareToOtherPasswords()
        {
            var pwd = new Hashword("test");
            var pwd2 = new Hashword("test2");
            var pwd3 = new Hashword("test");

            pwd.IsSameAs(pwd2).Should().Be(false);
            pwd.IsSameAs(pwd3).Should().Be(true);
        }
    }
}
