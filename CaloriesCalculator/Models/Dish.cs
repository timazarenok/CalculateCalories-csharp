using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriesCalculator
{
    public class Dish
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int Calories { get; set; }
        public int Proteins { get; set; }
        public int Fats { get; set; }
        public int Carbohydrates { get; set; }
    }
}
