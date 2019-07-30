using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS_ShapesProject {

    public class Quad {

        public double side1 { get; set; }
        public double side2 { get; set; }
        public double side3 { get; set; }
        public double side4 { get; set; }

        public double GetPerimeter() {

          return side1 + side2 + side3 + side4;
        
        }

        public virtual int GetArea() {

            throw new NotImplementedException("Cannot calculate Area of a Quad");
        }

        public Quad(int side_a, int side_b, int side_c, int side_d) {//constructors do NOT have a TYPE, most often public
            this.side1 = side_a;
            this.side2 = side_b;
            this.side3 = side_c;
            this.side4 = side_d;


        }
    }
}
