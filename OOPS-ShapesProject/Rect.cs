using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS_ShapesProject {

    public class Rect : Quad {

        public Rect(int side_x, int side_y) : base(side_x, side_y,side_x, side_y) {

        }
        public override int GetArea() {

            return side1 * side2;
        }

    }
}
