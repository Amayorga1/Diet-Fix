using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DietFix.Models
{
    public interface IUser
    {

        IQueryable<UserAccount> UserAccounts { get; set; }
        IQueryable<Meals> meals { get; set; }
        IQueryable<DietType> dietTypes { get; set; }
        IQueryable<CostAnalysis> costAnalyses { get; set; }

    }
}
