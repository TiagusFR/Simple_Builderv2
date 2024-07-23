using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Builderv2
{
     class HtmlElement
    {
        public string Name, Text;
        public List<HtmlElement> Elements = new List<HtmlElement>();
        protected const int indentSize = 2;


        //Hidden constructors
        internal HtmlElement() { }
        internal HtmlElement(string name, string text)
        {
            Name = name;
            Text = text;
        }


        //Factory Method to create a builder
        public static HtmlBuilder Create(string name) => new HtmlBuilder(name);



        //Overriding ToString() to display the HTML element properly
        public override string ToString()
        {
            return ToStringImpl(0);
        }

        private string ToStringImpl(int indent)
        {
            var indentStr = new string (' ', indentSize * indent);
            var result = $"`{indentStr}<{Name}>\n`";

            if (!string.IsNullOrEmpty(Text))
            {
                result += new string(' ', indentSize * (indent + 1)) + Text + "\n";
            }

            foreach (var e in Elements)
            {
                result += e.ToStringImpl(indent + 1);
            }

            result += $"{indent}</{Name}\n";
            return result;
        }
    }
}
