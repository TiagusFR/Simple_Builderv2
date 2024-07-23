using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Builderv2
{
     class HtmlBuilder
    {
        protected readonly string rootName;
        protected HtmlElement root = new HtmlElement();

        public HtmlBuilder(string rootName)
        {  
            this.rootName = rootName; 
            root.Name = rootName;
        }

        public HtmlBuilder AddChild (string childName, string childText)
        {
            var e = new HtmlElement(childName, childText);
            root.Elements.Add(e);
            return this;
        }

        //Build method to get the HtmlElement
        public HtmlElement Build() => root;

        //Implicit conversion from HtmlBuilder to HtmlElement
        public static implicit operator HtmlElement(HtmlBuilder builder)
        {
            return builder.root;
        }

        //Overriding ToString() to use HtmlElement's ToString method
        public override string ToString() => root.ToString();
    }
}
