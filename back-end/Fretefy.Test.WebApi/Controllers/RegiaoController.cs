using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Domain.Interfaces;
using Fretefy.Test.Domain.Interfaces.Services;
using Fretefy.Test.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Fretefy.Test.WebApi.Controllers
{
    [Route("api/regiao")]
    [ApiController]
    public class RegiaoController : ControllerBase
    {
        private readonly IRegiaoService _regiaoService;

        public RegiaoController(IRegiaoService regiaoService)
        {
            _regiaoService = regiaoService;
        }


        [HttpGet]
        public IActionResult List()
        {
            IEnumerable<Regiao> regioes;

            regioes = _regiaoService.List();

            return Ok(regioes);
        }

        [HttpPost]
        public IActionResult Create(Regiao regiao)
        {

            var regionCreated = _regiaoService.Create(regiao);

            if (regionCreated.Any())
            {
                return Ok(regionCreated);
            }
            return BadRequest();
        }

        [HttpPut]
        public IActionResult Update(Regiao regiao)
        {

            var regionCreated = _regiaoService.Update(regiao);

            if (regionCreated.Any())
            {
                return Ok(regionCreated);
            }
            return BadRequest();
        }

    }
}
