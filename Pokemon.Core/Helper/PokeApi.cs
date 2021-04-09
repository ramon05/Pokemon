using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Pokemon.Core.Helper
{
	public class PokeApi
	{
		public HttpClient initial()
		{
			var client = new HttpClient();
			client.BaseAddress = new Uri("https://pokeapi.co/api/v2/pokemon/");

			return client;
		}
	}
}
