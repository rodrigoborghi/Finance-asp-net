using System;
using System.Collections.Generic;
using System.Linq;
using Finance.Domain.Interfaces;
using Finance.Domain.Models;
using Finance.Web.DTOs;
using Microsoft.AspNetCore.Mvc;
namespace Finance.Web.Controllers
{
 [Route("api/[controller]")]
    public class AtivoController : Controller
    {
        private readonly AtivoService _ativoService;
        private readonly IRepository<Ativo> _ativoRepository;
        public AtivoController(AtivoService ativoService,
            IRepository<Ativo> ativoRepository)
        {
            _ativoService = ativoService;
            _ativoRepository = ativoRepository;
        }
        [HttpGet("Index")]
         public ActionResult Index()
         {
             _ativoRepository.Save(new Ativo("A",1));

              return View();
         }

         [HttpGet("Ativos")]
         public IEnumerable<Ativo> GetAtivos()
         {
              var ativos = _ativoRepository.GetAll();
              return ativos;
         }
         [HttpGet("{id}")]
         public ActionResult<Ativo> GetAtivo(int id)
         {
             var ativo =  _ativoRepository.GetById(id);
             if (ativo == null)
             {
                 return NotFound(new { message = $"ativo de id={id} não encontrado ssss" });
             }
             return ativo;
         }
    }
}