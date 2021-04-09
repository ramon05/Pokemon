using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pokemon.Core.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokemon.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PokemonController : ControllerBase
	{
		private readonly IPokemon _pokemon;

		public PokemonController(IPokemon pokemon)
		{
			_pokemon = pokemon;
		}

		[HttpGet]
		public async Task<IActionResult> Get()
		{
			var result = await _pokemon.GetPokemones();

			return Ok(result);
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetById(int id)
		{
			var result = await _pokemon.GetPokemon(id);

			return Ok(result);
		}
	}
}
