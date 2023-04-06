using PracticaFosagroTask1.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaFosagroTask1.Model
{
    internal class Circle : PatternDetail
    {
        public override double V { get; set; }
        public override double material_mas { get; set; }
        private double R;
        public Circle(double R, double V,double N)
        {
            this.R = R;
            this.V = V;
            this.material_mas = N;
        }
    }
}
