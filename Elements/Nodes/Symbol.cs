using InkForms.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InkForms.Elements.Nodes
{
    internal class Symbol : Node
    {
        v2d _size;
        byte[] _data;

        public v2d Size
        {
            get=> _size;
            set => _size = value;
        }
        public byte[] Data
        {
            get => _data;
            set => _data = value;
        }
    }
}
