using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS_ShapesProject {

    public class SquareComp {

        private Quad quad;//use the Class name that you want to use for the composition

        public int GetPerimeter() {
            return (int)quad.GetPerimeter();
        }

        public int GetArea() {
            return (int)(quad.side1 * quad.side1);

        }

        public SquareComp(int sides) {
            quad = new Quad(sides, sides, sides, sides);
            
        }
    }
}
