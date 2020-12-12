using System;
using Microsoft.AspNetCore.Mvc;
using Xunit;
using Lab14.Tests;
using System.Text;
using System.Collections.Generic;
using Lab14.Controllers;
using Moq;
using Lab14.Models;

namespace Lab14.Tests
{
    public class UnitTest1
    {
        public void Add_ReturnsTwoViewDataDictionaryItems()
        {
            var unit = GetAddUnitOfWork();
            var controller = new ContactController(unit);
            int expectedCount = 2;
            string expectedAction = "Add";

            ViewResult result = controller.Add();
            int actualCount = result.ViewData.Count;
            string actualAction = result.ViewData["Action"].ToString();
            var categories = (List<Category>)result.ViewData["Categories"];
        }

        [Fact]
        public void Edit_POST_InvalidData_ReturnsViewResult()
        {
            var unit = GetEditUnitOfWork();
            var controller = new ContactController(unit);
            controller.ModelState.AddModelError("", "Error");

            var result = controller.Edit();
        }

        [Fact]
        public void Index_ModelIsACollectionOfContactObjectst()
        {
            var rep = new Mock<IRepository<Contact>>();
            rep.Setup(m => m.List(It.IsAny<QueryOptions<Contact>>()))(new List<Contact>());
            var controller = new HomeController(rep.Object);

            var viewResult = (ViewResult)controller.Index();
            var model = viewResult.ViewData.Model as List<Contact>;
            Assert.IsType<List<Contact>>();
        }

        [Fact]
        public void Index_ReturnsViewResult()
        {
            var rep = new Mock<IRepository<Contact>>();
            var controller = new HomeController();

            var result = controller.Index();

            Assert.IsType<ViewResult>(result);
        }
    }
}