using JonSnow.Controllers;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using FluentAssertions;

namespace JonSnow.Unit.Tests
{
    public class UsersControllerSpec : BaseSpec
    {
        [Test]
        public void ShouldRedirectNonAuthentiecatedUsersToSignUp()
        {
            var controller = new UsersController();
            var res = controller.Index() as RedirectToRouteResult;

            res.Should().NotBeNull();
            
        }
    }
}
