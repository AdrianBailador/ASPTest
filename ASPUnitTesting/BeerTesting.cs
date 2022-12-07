using ASPTest.Controllers;
using ASPTest.Models;
using ASPTest.Services;
using Microsoft.AspNetCore.Mvc;

namespace ASPUnitTesting
{
    public class BeerTesting
    {

        private readonly BeerController _controller;
        private readonly IBeerService _service;

        public BeerTesting()
        {
            _service = new BeerService();
            _controller = new BeerController(_service);
        }

        [Fact]
        public void Get_Ok()
        {
            var result = _controller.Get();//accion que vamos a evaluar, preparacion, ejecución y si es correcto o no es correcto

            Assert.IsType<OkObjectResult>(result);//mandamos el resultado
        }

        [Fact]
        public void Get_Quantity()
        {
            var result = (OkObjectResult)_controller.Get();

            var beers = Assert.IsType<List<Beer>>(result.Value);
            Assert.True(beers.Count>0);
        }
    }
}