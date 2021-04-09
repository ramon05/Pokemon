using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Pokemon.Core.Entities;

namespace Pokemon.Core.interfaces
{
	public interface IPokemon
	{
		Task<Request> GetPokemones();	
		Task<Root> GetPokemon(int id);
	}
}
