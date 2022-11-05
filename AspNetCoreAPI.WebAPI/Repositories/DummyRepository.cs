using AspNetCoreAPI.WebAPI.Interfaces;

namespace AspNetCoreAPI.WebAPI.Repositories
{
    public class DummyRepository : IDummyRepository
    {
        public string GetName()
        {
            return "Doganalp";
        }
    }
}
