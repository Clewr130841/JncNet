using JncNet.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace JncNet
{
    public class JncOutAttribute : JncAttributeBase
    {
        public JncOutAttribute(bool required = false) : base(required)
        {
        }
    }
}
