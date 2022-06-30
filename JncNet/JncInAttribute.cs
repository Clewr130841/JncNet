using JncNet.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace JncNet
{
    public class JncInAttribute : JncAttributeBase
    {
        public JncInAttribute(bool required = false) : base(required)
        {
        }
    }
}
