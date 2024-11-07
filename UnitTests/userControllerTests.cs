using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEBAPI;
using WEBAPI.Controllers;

namespace UnitTests
{
    public class userControllerTests
    {
        [Fact]
        public void GetAllReturnsListOfUsers()
        {
            ///Act
            var controller = new UsersController();
            var result = controller.Get();


            ///Assert
            Assert.IsType<List<User>>(result);
        }


        [Fact]
        public void GetById_ReturnsNotFound()
        {
            ///Arrange
            var id = 8;


            ///Act
            var controller = new UsersController();
            var result = controller.Get(id);

            ///Assert
            Assert.IsType<NotFoundResult>(result);
        }

        [Fact]
        public void GetById_ReturnsOk()
        {
            //Arrange
            var id = 1;

            //Act
            var controller = new UsersController();
            var result = controller.Get(id);

            //Assert
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void GetAll_ReturnsCount()
        {
            var controller = new UsersController();
            var result = controller.Get();

            Assert.Equal(1, result.Count());
        }

    }
}
