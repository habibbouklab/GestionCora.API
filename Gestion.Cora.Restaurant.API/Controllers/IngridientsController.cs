using Gestion.Cora.Restaurant.Application.Contracts;
using Gestion.Cora.Restaurant.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Gestion.Cora.Restaurant.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngridientsController : ControllerBase
    {
        private readonly IGererAssiettes _gererAssiettes;

        public IngridientsController(IGererAssiettes gererAssiettes)
        {
           _gererAssiettes = gererAssiettes;
        }
        // GET: api/<IngridientsController>
        [HttpGet]
        public IEnumerable<Ingridient> Get()
        {
            return _gererAssiettes.GetListIngridients();
        }

        // GET api/<IngridientsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<IngridientsController>
        [HttpPost]
        public int Post([FromBody] Assiette assiette)
        {
            return _gererAssiettes.CalculateCalories(assiette);
        }

        // PUT api/<IngridientsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<IngridientsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
