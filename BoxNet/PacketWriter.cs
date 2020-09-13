using System.IO;

namespace BoxNet
{
    public class PacketWriter : BinaryWriter
    {
        public PacketWriter() : base(new MemoryStream())
        { }

        public PacketWriter(int capacity) : base(new MemoryStream(capacity))
        { }

        public int Length { get { return (int)BaseStream.Length; } }
        public int Position { get { return (int)BaseStream.Position; } set { BaseStream.Position = value; } }

        public override void Write(double value)
        {
            base.Write(value);
        }
    }
}
