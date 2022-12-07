using ASPTest.Controllers;
using ASPTest.Services;

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
        public void Test1()
        {

        }
    }
}