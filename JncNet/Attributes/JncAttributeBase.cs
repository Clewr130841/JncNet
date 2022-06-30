using System;
using System.Collections.Generic;
using System.Text;

namespace JncNet.Attributes
{
    public abstract class JncAttributeBase: Attribute
    {
        public JncAttributeBase(bool required = false)
        {
            Required = required;
        }

        public bool Required { get; private set; }
    }
}
