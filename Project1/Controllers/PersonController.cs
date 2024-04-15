using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Project1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController(ApplicationDbContext applicationDbContext) : ControllerBase
    {
        private readonly ApplicationDbContext _applicationDbContext = applicationDbContext;

        [HttpGet]
        public IEnumerable<Person> Get()
        {
            return _applicationDbContext.Persons;
        }


        [HttpPost]
        public void Post()
        {
            GenerateRandomData(1000);
        }

        private void GenerateRandomData(int numberOfRecords)
        {

            Random _random = new();

            for (int i = 0; i < numberOfRecords; i++)
            {
                // Generate random age between 0 and 120
                int age = _random.Next(0, 121);

                // Generate random gender (30% female, 70% male)
                var gender = _random.Next(1, 101) <= 30 ? Gender.FeMale : Gender.Male;

                // Generate random LastSeenTime within the last 10 days
                DateTime lastSeenTime = DateTime.Now.AddDays(-_random.Next(1, 11));

                // Create Person object
                var person = new Person
                {
                    Age = age,
                    Gender = gender,
                    LastSeenTime = lastSeenTime
                };

                _applicationDbContext.Persons.Add(person);
            }

            _applicationDbContext.SaveChanges();
        }
    }
}
