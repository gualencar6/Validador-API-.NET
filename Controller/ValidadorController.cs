using Microsoft.AspNetCore.Mvc;
using ValidadorApi.Services;
using ValidadorApi.Models;

namespace ValidadorApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValidadorController : ControllerBase
    {
        private readonly ValidadorService _service;

        public ValidadorController()
        {
            _service = new ValidadorService();
        }

        [HttpPost("cpf")]
        public IActionResult ValidarCpf([FromBody] CpfRequest request)
        {
            if (request == null || string.IsNullOrWhiteSpace(request.Cpf))
                return BadRequest(new { mensagem = "CPF não informado" });

            var resultado = _service.ValidarCpf(request.Cpf);

            if (!resultado)
                return BadRequest(new { mensagem = "CPF inválido" });

            return Ok(new { mensagem = "CPF válido" });
        }

        [HttpPost("ip")]
        public IActionResult ValidarIp([FromBody] IpRequest request)
        {
            if (request == null || string.IsNullOrWhiteSpace(request.Ip))
                return BadRequest(new { mensagem = "IP não informado" });

            var resultado = _service.ValidarIp(request.Ip);

            if (!resultado)
                return BadRequest(new { mensagem = "IP inválido" });

            return Ok(new { mensagem = "IP válido" });
        }

        [HttpPost("senha")]
        public IActionResult ValidarSenha([FromBody] SenhaRequest request)
        {
            if (request == null || string.IsNullOrWhiteSpace(request.Senha))
                return BadRequest(new { mensagem = "Senha não informada" });

            var resultado = _service.ValidarSenha(request.Senha);

            if (!resultado)
                return BadRequest(new { mensagem = "Senha inválida" });

            return Ok(new { mensagem = "Senha válida" });
        }
    }
}