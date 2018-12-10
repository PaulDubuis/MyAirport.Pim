using MyAirport.Pim.Entities;
using MyAirport.Pim.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Sql
{
    public class Sql : AbstractDefinition
    {
        public override BagageDefinition GetBagage(int idBagage)
        {
            throw new NotImplementedException();
        }

        public override List<BagageDefinition> GetBagage(string codeIataBagage)
        {
            throw new NotImplementedException();
        }
    }
}
