using Newtonsoft.Json;
using Pokemon.Core.Entities;
using Pokemon.Core.Helper;
using Pokemon.Core.interfaces;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.Core.Services
{
	public class PokemoneServices : IPokemon
	{
		PokeApi _api = new PokeApi();

		public async Task<Request> GetPokemones()
		{
			var Request = new Request();
			HttpClient client = _api.initial();
			HttpResponseMessage res = await client.GetAsync("?limit=1119&offset=1");

			if (res.IsSuccessStatusCode)
			{
				var results = res.Content.ReadAsStringAsync().Result;
				Request = JsonConvert.DeserializeObject<Request>(results);
			}
			return Request;
		}

		public async Task<Root> GetPokemon(int id)
		{
			var root = new Root();
			HttpClient client = _api.initial();
			HttpResponseMessage res = await client.GetAsync($"{id}");

			if (res.IsSuccessStatusCode)
			{
				var results = res.Content.ReadAsStringAsync().Result;
				root = JsonConvert.DeserializeObject<Root>(results);
			}
			
			return root;
		}
	}
}
