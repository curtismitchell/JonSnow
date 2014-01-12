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
        UsersController controller;

        public override void BeforeEachSpec()
        {
            controller = new UsersController();
            base.BeforeEachSpec();
        }

        [Test]
        public void ShouldRedirectUsersToSignUp()
        {
            var res = controller.Index() as RedirectToRouteResult;

            res.Should().NotBeNull();
            res.RouteValues["action"].Should().Be("SignUp");

        }

        [Test]
        public void ShouldShowTheSignUpView()
        {
            var res = controller.SignUp() as ViewResult;
            res.ViewName.Should().BeEmpty(); //Convention will use action name (SignUp) as the name of the view
        }
    }
}
