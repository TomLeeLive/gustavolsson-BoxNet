using BoxNet;
using Microsoft.Xna.Framework;

namespace MyGameNamespace
{
    public static class BoxNetExtensions
    {
        public static void Write(this PacketWriter w, Color value)
        {
            w.Write(value.PackedValue);
        }

        public static void Write(this PacketWriter w, Matrix value)
        {
            w.Write(value.M11);
            w.Write(value.M12);
            w.Write(value.M13);
            w.Write(value.M14);
            w.Write(value.M21);
            w.Write(value.M22);
            w.Write(value.M23);
            w.Write(value.M24);
            w.Write(value.M31);
            w.Write(value.M32);
            w.Write(value.M33);
            w.Write(value.M34);
            w.Write(value.M41);
            w.Write(value.M42);
            w.Write(value.M43);
            w.Write(value.M44);
        }

        public static void Write(this PacketWriter w, Quaternion value)
        {
            w.Write(value.X);
            w.Write(value.Y);
            w.Write(value.Z);
            w.Write(value.W);
        }

        public static void Write(this PacketWriter w, Vector2 value)
        {
            w.Write(value.X);
            w.Write(value.Y);
        }

        public static void Write(this PacketWriter w, Vector3 value)
        {
            w.Write(value.X);
            w.Write(value.Y);
            w.Write(value.Z);
        }

        public static void Write(this PacketWriter w, Vector4 value)
        {
            w.Write(value.X);
            w.Write(value.Y);
            w.Write(value.Z);
            w.Write(value.W);
        }

        public static Color ReadColor(this PacketReader r)
        {
            Color value = Color.TransparentBlack;
            value.PackedValue = r.ReadUInt32();
            return value;
        }

        public static Matrix ReadMatrix(this PacketReader r)
        {
            Matrix value = Matrix.Identity;
            value.M11 = r.ReadSingle();
            value.M12 = r.ReadSingle();
            value.M13 = r.ReadSingle();
            value.M14 = r.ReadSingle();
            value.M21 = r.ReadSingle();
            value.M22 = r.ReadSingle();
            value.M23 = r.ReadSingle();
            value.M24 = r.ReadSingle();
            value.M31 = r.ReadSingle();
            value.M32 = r.ReadSingle();
            value.M33 = r.ReadSingle();
            value.M34 = r.ReadSingle();
            value.M41 = r.ReadSingle();
            value.M42 = r.ReadSingle();
            value.M43 = r.ReadSingle();
            value.M44 = r.ReadSingle();
            return value;
        }

        public static Quaternion ReadQuaternion(this PacketReader r)
        {
            return new Quaternion(r.ReadSingle(), r.ReadSingle(), r.ReadSingle(), r.ReadSingle());
        }

        public static Vector2 ReadVector2(this PacketReader r)
        {
            return new Vector2(r.ReadSingle(), r.ReadSingle());
        }

        public static Vector3 ReadVector3(this PacketReader r)
        {
            return new Vector3(r.ReadSingle(), r.ReadSingle(), r.ReadSingle());
        }

        public static Vector4 ReadVector4(this PacketReader r)
        {
            return new Vector4(r.ReadSingle(), r.ReadSingle(), r.ReadSingle(), r.ReadSingle());
        }
    }
}
