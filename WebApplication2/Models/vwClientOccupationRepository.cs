using System;
using System.Linq;
using System.Collections.Generic;
	
namespace WebApplication2.Models
{   
	public  class vwClientOccupationRepository : EFRepository<vwClientOccupation>, IvwClientOccupationRepository
	{

	}

	public  interface IvwClientOccupationRepository : IRepository<vwClientOccupation>
	{

	}
}