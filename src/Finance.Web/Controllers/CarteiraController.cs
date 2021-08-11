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
    public class CarteiraController : Controller
    {
        private readonly AtivosCarteiraService _ativoCarteiraService;

        public CarteiraController(AtivosCarteiraService ativoCarteiraService)
        {
            _ativoCarteiraService = ativoCarteiraService;
        }

         [HttpGet]
         [Route("{id?}")]
         public ActionResult<Carteira> GetAtivosByCarteira(int id)
         {
             var carteira =  _ativoCarteiraService.GetAtivosCarteiraById(id);
             if (carteira == null)
             {
                 return NotFound(new { message = $"carteira de id={id} não encontrado ssss" });
             }
             return carteira;
         }
         
    }
}