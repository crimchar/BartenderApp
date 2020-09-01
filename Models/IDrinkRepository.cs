using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BartenderApp.Models
{
    interface IDrinkRepository
    {
        IEnumerable<Drink> Drinks { get; }
    }
}
