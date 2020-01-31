using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stadium_webapp.Models.Stadiums
{
	public class stadiums
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string ClubName { get; set; }
		public double TicketPrice { get; set; }
		public int Capacity { get; set; }
		
	}
}
