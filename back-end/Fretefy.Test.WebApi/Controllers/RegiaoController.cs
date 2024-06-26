using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Domain.Entities.RequestModels;
using Fretefy.Test.Domain.Interfaces;
using Fretefy.Test.Domain.Interfaces.Services;
using Fretefy.Test.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        public async Task<IActionResult> List()
        {
            var regioes = await _regiaoService.ListAsync();
            return Ok(regioes);
        }

        [HttpPost]
        public async Task<IActionResult> Create(RegiaoRequest regiao)
        {

            var regionCreated = await _regiaoService.CreateAsync(regiao);

            if (regionCreated is null)
            {
               return BadRequest();
            }
            return Ok(regionCreated);
        }

        [HttpPut]
        public async Task<IActionResult> Update(RegiaoRequest regiao)
        {

            var regionUpdated = await _regiaoService.UpdateAsync(regiao);

            if (regionUpdated is null)
            {
                return BadRequest();
            }
            return Ok(regionUpdated);
        }

    }
}
