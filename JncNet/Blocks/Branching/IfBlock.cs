using System;
using System.Collections.Generic;
using System.Text;

namespace JncNet.Blocks
{
    public class IfBlock : IJncBlock
    {
        [JncIn(required: true)]
        public bool Condition { get; set; }

        [JncFlow(required: true)]
        public IJncBlock Then { get; set; }

        [JncFlow]
        public IJncBlock Else { get; set; }

        public void Execute()
        {
            if (Condition)
            {
                Then.Execute();
            }
            else if (Else != null)
            {
                Else.Execute();
            }
        }
    }
}
