using BuscaCep.Models;
using BuscaCep.Services;
using Microsoft.AspNetCore.Mvc;

namespace BuscaCep.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BuscaCepController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> ConsultaCep([FromBody] CepRequest cepRequest)
        {
            if (!ModelState.IsValid)
            {
                BadRequest();
            }

            var respostaCep = await ViaCep.BuscaCep(cepRequest.Cep);

            return Ok(respostaCep);
        }
    }
}
