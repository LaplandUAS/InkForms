using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InkForms.Elements.Nodes
{
    internal class Root : Node
    {
        byte _orientation = 0;
        public Byte Orientation
        {
            get => _orientation;
            set => _orientation = value;
        }
    }
}
