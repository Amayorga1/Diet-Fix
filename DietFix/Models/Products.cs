using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DietFix.Models
{
    public class UserAccount
    {
        public string UserID { get; set; }
        public string MealLog { get; set; }
        public string PastDietPlan { get; set; }

        public string CurrentDietPlan { get; set; }
        public string UserProgression { get; set; }


    }
    public class DietType
    {
        public string UserID { get; set; }
        public string KetoDesc { get;  set; }
        public string PaleoDesc { get; set; }

        public string PescDesc { get; set; }
        public string MediDesc { get; set; }

    }

    public class Meals
    {

        public string UserID { get; set; }
        public string Breakfast { get; set; }
        public string Lunch { get; set; }

        public string Dinner { get; set; }
        public string Extras { get; set; }

    }
    public class CostAnalysis
    {
        public string UserID { get; set; }
        public string CostOptions { get; set; }
        public int CurrentCost { get; set; }

        public string CurrentDietPlan { get; set; }
        public string UserProgression { get; set; }



    }



}
