using ASPTest.Models;

namespace ASPTest.Services
{
    public interface IBeer
    {
        public IEnumerable<Beer> Get(); //Nos devuelva toda la información de cerveza

        public Beer? Get(int id);
    }
}
