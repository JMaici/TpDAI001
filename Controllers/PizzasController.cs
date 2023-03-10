using Microsoft.AspNetCore.Mvc;
using TPDAI001.Models;
namespace TPDAI001.Controllers{
    [ApiController]
    [Route("[controller]")]
    public class PizzasController : ControllerBase
    {
       
       
        [HttpGet]
        public IActionResult GetAll()
        {
            List<Pizza> listaP = BD.ListarPizzas();
            return Ok(listaP);
           
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
             if (id < 1)
        {
            return BadRequest();
        }

        Pizza p = BD.ObtenerPizzaPorID(id);

        if (p == null)
        {
            return NotFound();
        }

        return Ok(p);
       
        }
        [HttpPost]
        public IActionResult Create(Pizza pizza)
        {
        if (pizza.Nombre == null || pizza.Nombre == "")
        {
            return BadRequest();
        }
      
        BD.AgregarPizza(pizza);
        return Ok();
           
        }
        [HttpPut("{id}")]
        public IActionResult Update(int id, Pizza pizza)
        {
            if(id != pizza.Id){
                return BadRequest();
            }
            if(BD.ObtenerPizzaPorID(id) == null){
                return NotFound();
            }
            BD.ModificarPizza(id, pizza);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteById(int id)
        {
            if(id <= 0){
                return BadRequest();
            }
            if(BD.ObtenerPizzaPorID(id) == null){
                return NotFound();
            }
            BD.EliminarPizza(id);
            return Ok();
            

           
        }

    }


}
