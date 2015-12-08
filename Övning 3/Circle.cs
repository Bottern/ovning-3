using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_3
{
    public class Circle
    {
        private double diameter;
        private Point point;

        public double GetDiameter()
        {
            return diameter;
        }
        public void SetDiameter (double diameter)
        {
            this.diameter = diameter;
        }
        public double GetCircumference()
        {
            return diameter * 3.1416;
        }
        public Point GetCenter()
        {
            return point;
        }
        public void SetCenter(Point point)
        {
            this.point = point;
        }
        
    }
}
