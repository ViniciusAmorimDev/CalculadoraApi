using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CalculadoraApi.Models;
using CalculadoraApi.Services;
using Microsoft.AspNetCore.Routing.Constraints;

namespace CalculadoraApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalculadoraController : ControllerBase
    {
        [HttpGet("Somar")]
        public IActionResult GetSomar(double primeiroValor, double segundoValor, int codigoSupervisor)
        {
            try
            {
                string autorizacao = new CalculadoraServices().AutorizarOperacao(codigoSupervisor);
                if (autorizacao != "Autorizado")
                {
                    return Unauthorized("Você não tem autorização para realizar essa operação.");
                }
                double soma = new CalculadoraModels(primeiroValor, segundoValor).Somar(primeiroValor, segundoValor);
                return Ok($"Você está Autorizado a realiazar o calculo. O valor total da soma é: {soma}");
            }
            catch (Exception e)
            {
                return BadRequest($"Não foi possível realizar a soma pelo motivo: {e.Message}");
            }
        }

        [HttpGet("Diminuir")]
        public IActionResult GetDiminuir(double primeiroValor, double segundoValor, int codigoSupervisor)
        {
            try
            {
                string autorizacao = new CalculadoraServices().AutorizarOperacao(codigoSupervisor);
                if (autorizacao != "Autorizado")
                {
                    return Unauthorized("Você não tem autorização para realizar essa operação.");
                }
                double diminui = new CalculadoraModels(primeiroValor, segundoValor).Diminuir(primeiroValor, segundoValor);
                return Ok($"Você está Autorizado a realiazar o calculo. O valor total da subtração é: {diminui}");
            }
            catch (Exception e)
            {
                return BadRequest($"Não foi possível realizar a subtração pelo motivo: {e.Message}");
            }
        }

        [HttpGet("Multiplicar")]
        public IActionResult GetMultiplicar(double primeiroValor, double segundoValor, int codigoSupervisor)
        {
            try
            {
                string autorizacao = new CalculadoraServices().AutorizarOperacao(codigoSupervisor);
                if (autorizacao != "Autorizado")
                {
                    return Unauthorized("Você não tem autorização para realizar essa operação.");
                }
                double multiplica = new CalculadoraModels(primeiroValor, segundoValor).Multiplicar(primeiroValor, segundoValor);
                return Ok($"Você está Autorizado a realiazar o calculo. O valor total da multiplicação é: {multiplica}");
            }
            catch (Exception e)
            {
                return BadRequest($"Não foi possível realizar a multiplicação pelo motivo: {e.Message}");
            }
        }

        [HttpGet("Dividir")]
        public IActionResult GetDividir(double primeiroValor, double segundoValor, int codigoSupervisor)
        {
            try
            {
                string autorizacao = new CalculadoraServices().AutorizarOperacao(codigoSupervisor);
                if (autorizacao != "Autorizado")
                {
                    return Unauthorized("Você não tem autorização para realizar essa operação.");
                }
                double dividi = new CalculadoraModels(primeiroValor, segundoValor).Dividir(primeiroValor, segundoValor);
                return Ok($"Você está Autorizado a realiazar o calculo. O valor total da multiplicação é: {dividi}");
            }
            catch (Exception e)
            {
                return BadRequest($"Não foi possível realizar a divisão pelo motivo: {e.Message}");
            }
        }
    }
}