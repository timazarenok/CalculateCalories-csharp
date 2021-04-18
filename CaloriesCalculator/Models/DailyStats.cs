using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriesCalculator.Models
{
    public class DailyStats
    {
        public string Date { get; set; }
        public int Water { get; set; }
        public int Calories { get; set; }
        public int Proteins { get; set; }
        public int Fats { get; set; }
        public int Carbohydrates { get; set; }
    }
}
