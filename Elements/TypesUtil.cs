using InkForms.Elements;
using InkForms.Elements.Nodes;
using Newtonsoft.Json.Converters;
using System;
using System.Diagnostics;
/*
 * Utilities for Node elements.
 * [v2d 2-dimensional vector object]
 * [t2d 2-dimensional transform object] (Maybe discard??)
*/

namespace InkForms.Utilities
{
    static class Iterator
    {
        static int _iterator;
        public static int GenerateID
        {
            get => _iterator++;
        }
    }
    public static class Nodes
    {
        public static Type[] Types = {typeof(Root), typeof(Text), typeof(Symbol), typeof(Element)};
    }
    public class v2d                                                               //  Vector 2D type
    {
        private int _x;                                                     //  Vector X-component
        private int _y;                                                     //  Vector Y-component
        public int X                                                        //  Handle for X
        {
            get => _x;
            set => _x = value;
        }
        public int Y                                                        //  Handle for Y
        {
            get => _y;
            set => _y = value;
        }
        public static v2d Zero
        {
            get { return new v2d {  X = 0, Y = 0 };}
        }
        public static v2d operator +(v2d v1, v2d v2)
        {
            v2d v = new v2d();
            v.X = (v1.X + v2.X);
            v.Y = (v1.Y + v2.Y);
            return v;
        }

        public static v2d operator *(v2d v1, v2d v2)
        {
            v2d v = new v2d();
            v.X = (v1.X * v2.X);
            v.Y = (v1.Y * v2.Y);
            return v;
        }
    }
}
