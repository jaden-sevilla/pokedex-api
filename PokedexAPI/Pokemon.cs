using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormAPI
{
	public class Pokemon
	{
		public string name { get; set; }
		public int id { get; set; }
		public double height { get; set; }
		public double weight { get; set; }
		public List<Stat> stats { get; set; }
		public List<Type> types { get; set; }
		public Sprites sprites { get; set; }

	}
}
