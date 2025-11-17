using InkForms.Utilities;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics;

namespace InkForms.Elements
{
    public class Node
    {
        byte _id;
        byte _type;
        string _name;
        v2d _nPos;                                  //  Root transform (before inheriting parent position)
        List<Node> _children = new List<Node>();
        byte _parentID;

        public Node()
        {
            ID = (byte)Iterator.GenerateID;
        }
        public byte ID
        {
            get => _id;
            set => _id = value;
        }
        public byte Type
        {
            get => _type;
            set => _type = value;
        }
        public string Name
        {
            get => _name;
            set => _name = value;
        }
        public v2d Transform
        {
            get => _nPos;
            set => _nPos = value;
        }
        public byte Parent
        {
            get => _parentID;
            set => _parentID = value;
        }
        public List<Node> Children
        { 
            get => _children;
        }

        public virtual void UpdateContent(byte b1 = 0, string s1 = "")
        {

        }

        public void UpdatePos(v2d t)
        {
            v2d _vPos = _nPos + t;
            foreach (Node child in Children)
            {
                child.UpdatePos(_vPos);
            }

        }

        public void AddChild(Node child)
        {
            _children.Add(child);
        }
        public void RemoveChild(Node child)
        {
            _children.Remove(child);
        }
    }
}
