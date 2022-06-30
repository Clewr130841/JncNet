  
using System;
using System.Collections.Generic;
using System.Text;

namespace JncNet.Blocks.Math
{
    public class AddInt : IJncBlock
    {
        [JncIn(required:true)]
        public int A { get; set; }

        [JncIn(required:true)]
        public int B { get; set; }

        [JncOut(required:true)]
        public int Result { get; set; }

        public void Execute()
        {
            Result = (int)(A + B);
        }
    }
    public class AddUInt : IJncBlock
    {
        [JncIn(required:true)]
        public uint A { get; set; }

        [JncIn(required:true)]
        public uint B { get; set; }

        [JncOut(required:true)]
        public uint Result { get; set; }

        public void Execute()
        {
            Result = (uint)(A + B);
        }
    }
    public class AddLong : IJncBlock
    {
        [JncIn(required:true)]
        public long A { get; set; }

        [JncIn(required:true)]
        public long B { get; set; }

        [JncOut(required:true)]
        public long Result { get; set; }

        public void Execute()
        {
            Result = (long)(A + B);
        }
    }
    public class AddULong : IJncBlock
    {
        [JncIn(required:true)]
        public ulong A { get; set; }

        [JncIn(required:true)]
        public ulong B { get; set; }

        [JncOut(required:true)]
        public ulong Result { get; set; }

        public void Execute()
        {
            Result = (ulong)(A + B);
        }
    }
    public class AddDouble : IJncBlock
    {
        [JncIn(required:true)]
        public double A { get; set; }

        [JncIn(required:true)]
        public double B { get; set; }

        [JncOut(required:true)]
        public double Result { get; set; }

        public void Execute()
        {
            Result = (double)(A + B);
        }
    }
    public class AddDecimal : IJncBlock
    {
        [JncIn(required:true)]
        public decimal A { get; set; }

        [JncIn(required:true)]
        public decimal B { get; set; }

        [JncOut(required:true)]
        public decimal Result { get; set; }

        public void Execute()
        {
            Result = (decimal)(A + B);
        }
    }
    public class AddByte : IJncBlock
    {
        [JncIn(required:true)]
        public byte A { get; set; }

        [JncIn(required:true)]
        public byte B { get; set; }

        [JncOut(required:true)]
        public byte Result { get; set; }

        public void Execute()
        {
            Result = (byte)(A + B);
        }
    }
    public class AddSingle : IJncBlock
    {
        [JncIn(required:true)]
        public float A { get; set; }

        [JncIn(required:true)]
        public float B { get; set; }

        [JncOut(required:true)]
        public float Result { get; set; }

        public void Execute()
        {
            Result = (float)(A + B);
        }
    }
    public class MinusInt : IJncBlock
    {
        [JncIn(required:true)]
        public int A { get; set; }

        [JncIn(required:true)]
        public int B { get; set; }

        [JncOut(required:true)]
        public int Result { get; set; }

        public void Execute()
        {
            Result = (int)(A - B);
        }
    }
    public class MinusUInt : IJncBlock
    {
        [JncIn(required:true)]
        public uint A { get; set; }

        [JncIn(required:true)]
        public uint B { get; set; }

        [JncOut(required:true)]
        public uint Result { get; set; }

        public void Execute()
        {
            Result = (uint)(A - B);
        }
    }
    public class MinusLong : IJncBlock
    {
        [JncIn(required:true)]
        public long A { get; set; }

        [JncIn(required:true)]
        public long B { get; set; }

        [JncOut(required:true)]
        public long Result { get; set; }

        public void Execute()
        {
            Result = (long)(A - B);
        }
    }
    public class MinusULong : IJncBlock
    {
        [JncIn(required:true)]
        public ulong A { get; set; }

        [JncIn(required:true)]
        public ulong B { get; set; }

        [JncOut(required:true)]
        public ulong Result { get; set; }

        public void Execute()
        {
            Result = (ulong)(A - B);
        }
    }
    public class MinusDouble : IJncBlock
    {
        [JncIn(required:true)]
        public double A { get; set; }

        [JncIn(required:true)]
        public double B { get; set; }

        [JncOut(required:true)]
        public double Result { get; set; }

        public void Execute()
        {
            Result = (double)(A - B);
        }
    }
    public class MinusDecimal : IJncBlock
    {
        [JncIn(required:true)]
        public decimal A { get; set; }

        [JncIn(required:true)]
        public decimal B { get; set; }

        [JncOut(required:true)]
        public decimal Result { get; set; }

        public void Execute()
        {
            Result = (decimal)(A - B);
        }
    }
    public class MinusByte : IJncBlock
    {
        [JncIn(required:true)]
        public byte A { get; set; }

        [JncIn(required:true)]
        public byte B { get; set; }

        [JncOut(required:true)]
        public byte Result { get; set; }

        public void Execute()
        {
            Result = (byte)(A - B);
        }
    }
    public class MinusSingle : IJncBlock
    {
        [JncIn(required:true)]
        public float A { get; set; }

        [JncIn(required:true)]
        public float B { get; set; }

        [JncOut(required:true)]
        public float Result { get; set; }

        public void Execute()
        {
            Result = (float)(A - B);
        }
    }
    public class MultiplyInt : IJncBlock
    {
        [JncIn(required:true)]
        public int A { get; set; }

        [JncIn(required:true)]
        public int B { get; set; }

        [JncOut(required:true)]
        public int Result { get; set; }

        public void Execute()
        {
            Result = (int)(A * B);
        }
    }
    public class MultiplyUInt : IJncBlock
    {
        [JncIn(required:true)]
        public uint A { get; set; }

        [JncIn(required:true)]
        public uint B { get; set; }

        [JncOut(required:true)]
        public uint Result { get; set; }

        public void Execute()
        {
            Result = (uint)(A * B);
        }
    }
    public class MultiplyLong : IJncBlock
    {
        [JncIn(required:true)]
        public long A { get; set; }

        [JncIn(required:true)]
        public long B { get; set; }

        [JncOut(required:true)]
        public long Result { get; set; }

        public void Execute()
        {
            Result = (long)(A * B);
        }
    }
    public class MultiplyULong : IJncBlock
    {
        [JncIn(required:true)]
        public ulong A { get; set; }

        [JncIn(required:true)]
        public ulong B { get; set; }

        [JncOut(required:true)]
        public ulong Result { get; set; }

        public void Execute()
        {
            Result = (ulong)(A * B);
        }
    }
    public class MultiplyDouble : IJncBlock
    {
        [JncIn(required:true)]
        public double A { get; set; }

        [JncIn(required:true)]
        public double B { get; set; }

        [JncOut(required:true)]
        public double Result { get; set; }

        public void Execute()
        {
            Result = (double)(A * B);
        }
    }
    public class MultiplyDecimal : IJncBlock
    {
        [JncIn(required:true)]
        public decimal A { get; set; }

        [JncIn(required:true)]
        public decimal B { get; set; }

        [JncOut(required:true)]
        public decimal Result { get; set; }

        public void Execute()
        {
            Result = (decimal)(A * B);
        }
    }
    public class MultiplyByte : IJncBlock
    {
        [JncIn(required:true)]
        public byte A { get; set; }

        [JncIn(required:true)]
        public byte B { get; set; }

        [JncOut(required:true)]
        public byte Result { get; set; }

        public void Execute()
        {
            Result = (byte)(A * B);
        }
    }
    public class MultiplySingle : IJncBlock
    {
        [JncIn(required:true)]
        public float A { get; set; }

        [JncIn(required:true)]
        public float B { get; set; }

        [JncOut(required:true)]
        public float Result { get; set; }

        public void Execute()
        {
            Result = (float)(A * B);
        }
    }
    public class DevideInt : IJncBlock
    {
        [JncIn(required:true)]
        public int A { get; set; }

        [JncIn(required:true)]
        public int B { get; set; }

        [JncOut(required:true)]
        public int Result { get; set; }

        public void Execute()
        {
            Result = (int)(A / B);
        }
    }
    public class DevideUInt : IJncBlock
    {
        [JncIn(required:true)]
        public uint A { get; set; }

        [JncIn(required:true)]
        public uint B { get; set; }

        [JncOut(required:true)]
        public uint Result { get; set; }

        public void Execute()
        {
            Result = (uint)(A / B);
        }
    }
    public class DevideLong : IJncBlock
    {
        [JncIn(required:true)]
        public long A { get; set; }

        [JncIn(required:true)]
        public long B { get; set; }

        [JncOut(required:true)]
        public long Result { get; set; }

        public void Execute()
        {
            Result = (long)(A / B);
        }
    }
    public class DevideULong : IJncBlock
    {
        [JncIn(required:true)]
        public ulong A { get; set; }

        [JncIn(required:true)]
        public ulong B { get; set; }

        [JncOut(required:true)]
        public ulong Result { get; set; }

        public void Execute()
        {
            Result = (ulong)(A / B);
        }
    }
    public class DevideDouble : IJncBlock
    {
        [JncIn(required:true)]
        public double A { get; set; }

        [JncIn(required:true)]
        public double B { get; set; }

        [JncOut(required:true)]
        public double Result { get; set; }

        public void Execute()
        {
            Result = (double)(A / B);
        }
    }
    public class DevideDecimal : IJncBlock
    {
        [JncIn(required:true)]
        public decimal A { get; set; }

        [JncIn(required:true)]
        public decimal B { get; set; }

        [JncOut(required:true)]
        public decimal Result { get; set; }

        public void Execute()
        {
            Result = (decimal)(A / B);
        }
    }
    public class DevideByte : IJncBlock
    {
        [JncIn(required:true)]
        public byte A { get; set; }

        [JncIn(required:true)]
        public byte B { get; set; }

        [JncOut(required:true)]
        public byte Result { get; set; }

        public void Execute()
        {
            Result = (byte)(A / B);
        }
    }
    public class DevideSingle : IJncBlock
    {
        [JncIn(required:true)]
        public float A { get; set; }

        [JncIn(required:true)]
        public float B { get; set; }

        [JncOut(required:true)]
        public float Result { get; set; }

        public void Execute()
        {
            Result = (float)(A / B);
        }
    }
}
