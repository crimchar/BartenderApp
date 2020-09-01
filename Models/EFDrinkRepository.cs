using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BartenderApp.Models
{
    public class EFDrinkRepository : IDrinkRepository
    {
        private ApplicationDbContext context;
        public EFDrinkRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IEnumerable<Drink> Drinks => context.Drinks;
    }
}
