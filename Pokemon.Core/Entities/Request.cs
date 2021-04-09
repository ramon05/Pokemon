using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon.Core.Entities
{
	public class Request
	{
		public int count { get; set; }
		public string next { get; set; }
		public string previous { get; set; }
		public ICollection<Pokemones> results { get; set; }
	}
}
