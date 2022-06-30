using JncNet.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace JncNet
{
    public class JncFlowAttribute: JncAttributeBase
    {
        public JncFlowAttribute(bool required = false) : base(required)
        {
        }
    }
}
