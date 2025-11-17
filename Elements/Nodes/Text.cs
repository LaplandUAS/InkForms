using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InkForms.Elements.Nodes
{
    internal class Text : Node
    {
        string _content;
        byte _font;
        public string Content
        {
            get => _content;
            set => _content = value;
        }

        public byte Font
        {
            get => _font;
            set => _font = value;
        }

        public override void UpdateContent(byte b1, string s1)
        {
            _content = s1;
            _font = b1;
            Debug.WriteLine($"{this.Name}: [Font: {_font} Text: {_content}]");
        }
        public string GetText()
        {
            return _content;
        }
    }
}