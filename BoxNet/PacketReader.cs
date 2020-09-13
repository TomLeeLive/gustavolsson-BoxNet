using System;
using System.IO;

namespace BoxNet
{
    public class PacketReader : BinaryReader
    {
        public PacketReader() : base(new MemoryStream())
        { }

        public PacketReader(int capacity) : base(new MemoryStream(capacity))
        { }

        internal PacketReader(Stream stream) : base(stream)
        { }

        public int Length { get { return (int)BaseStream.Length; } }
        public int Position { get { return (int)BaseStream.Position; } set { BaseStream.Position = value; } }

        internal void ReadBytes(byte[] into, int offset, int count)
        {
            for (int i = offset; i < count; i++)
            {
                into[i] = ReadByte();
            }
        }

        public override double ReadDouble()
        {
            return base.ReadDouble();
        }
    }
}