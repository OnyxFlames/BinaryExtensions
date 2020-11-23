using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BinaryExtensions
{
    public static class BinaryReaderExtensions
    {
        public static void Seek(this BinaryReader reader, uint offset)
        {
            reader.BaseStream.Position = (long)offset;
        }
        public static void Seek(this BinaryReader reader, long offset)
        {
            reader.BaseStream.Position = offset;
        }
        public static string ReadString(this BinaryReader reader, uint count)
        {
            string ret = string.Empty;
            for (uint i = 0; i < count; ++i)
                ret += (char)reader.ReadByte();
            return ret;
        }
        public static bool ReadBooleanAt(this BinaryReader reader, long offset)
        {
            var prev = reader.BaseStream.Position;
            reader.Seek(offset);
            bool ret = reader.ReadBoolean();
            reader.Seek(prev);
            return ret;
        }
        public static byte ReadByteAt(this BinaryReader reader, long offset)
        {
            var prev = reader.BaseStream.Position;
            reader.Seek(offset);
            byte ret = reader.ReadByte();
            reader.Seek(prev);
            return ret;
        }
        public static sbyte ReadSByteAt(this BinaryReader reader, long offset)
        {
            var prev = reader.BaseStream.Position;
            reader.Seek(offset);
            sbyte ret = reader.ReadSByte();
            reader.Seek(prev);
            return ret;
        }
        public static byte[] ReadBytesAt(this BinaryReader reader, int count, long offset)
        {
            var prev = reader.BaseStream.Position;
            reader.Seek(offset);
            byte[] ret = reader.ReadBytes(count);
            reader.Seek(prev);
            return ret;
        }
        public static short ReadInt16At(this BinaryReader reader, long offset)
        {
            var prev = reader.BaseStream.Position;
            reader.Seek(offset);
            short ret = reader.ReadInt16();
            reader.Seek(prev);
            return ret;
        }
        public static ushort ReadUInt16At(this BinaryReader reader, long offset)
        {
            var prev = reader.BaseStream.Position;
            reader.Seek(offset);
            ushort ret = reader.ReadUInt16();
            reader.Seek(prev);
            return ret;
        }
        public static int ReadInt32At(this BinaryReader reader, long offset)
        {
            var prev = reader.BaseStream.Position;
            reader.Seek(offset);
            int ret = reader.ReadInt32();
            reader.Seek(prev);
            return ret;
        }
        public static uint ReadUInt32At(this BinaryReader reader, long offset)
        {
            var prev = reader.BaseStream.Position;
            reader.Seek(offset);
            uint ret = reader.ReadUInt32();
            reader.Seek(prev);
            return ret;
        }
        public static long ReadInt64At(this BinaryReader reader, long offset)
        {
            var prev = reader.BaseStream.Position;
            reader.Seek(offset);
            long ret = reader.ReadInt64();
            reader.Seek(prev);
            return ret;
        }
        public static ulong ReadUInt64At(this BinaryReader reader, long offset)
        {
            var prev = reader.BaseStream.Position;
            reader.Seek(offset);
            ulong ret = reader.ReadUInt64();
            reader.Seek(prev);
            return ret;
        }
        public static float ReadSingleAt(this BinaryReader reader, long offset)
        {
            var prev = reader.BaseStream.Position;
            reader.Seek(offset);
            float ret = reader.ReadSingle();
            reader.Seek(prev);
            return ret;
        }
        public static double ReadDoubleAt(this BinaryReader reader, long offset)
        {
            var prev = reader.BaseStream.Position;
            reader.Seek(offset);
            double ret = reader.ReadDouble();
            reader.Seek(prev);
            return ret;
        }
    }
}
