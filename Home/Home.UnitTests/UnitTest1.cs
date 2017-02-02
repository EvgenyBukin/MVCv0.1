using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Home.Domain.Abstract;
using Moq;
using Home.Domain.Entities;
using System.Collections.Generic;
using Home.WebUI.Controllers;

namespace Home.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Can_Paginate()
        {/*
            Mock<IGeneralRepository> mock = new Mock<IGeneralRepository>();
            mock.Setup(m => m.Generals).Returns(new List<General>
            {
                new General { ModuleId = 1, Name = "Игра1"},
                new General { ModuleId = 2, Name = "Игра2"},
                new General { ModuleId = 3, Name = "Игра3"},
                new General { ModuleId = 4, Name = "Игра4"},
                new General { ModuleId = 5, Name = "Игра5"}
            });
            GeneralController controller = new GeneralController(mock.Object);
            controller.pageSize = 3;

            IEnumerable<General> result = (IEnumerable<General>)controller.List(2).Model;

            List<General> games = result.ToList();
            Assert.IsTrue(games.Count == 2);
            Assert.AreEqual(games[0].Name, "Игра4");
            Assert.AreEqual(games[1].Name, "Игра5");*/
        }
    }
}
