using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BinaryExtensions
{
    public static class BinaryWriterExtensions
    {
        public static void Seek(this BinaryWriter writer, uint offset)
        {
            writer.Seek((long)offset);
        }
        public static void Seek(this BinaryWriter writer, long offset)
        {
            if (writer.BaseStream.Length <= offset)
                throw new ArgumentOutOfRangeException("offset");
            writer.BaseStream.Position = offset;
        }
        public static void WriteAt(this BinaryWriter writer, char c, long offset)
        {
            var prev = writer.BaseStream.Position;
            writer.Seek(offset);
            writer.Write(c);
            writer.Seek(prev);
        }
        public static void WriteAt(this BinaryWriter writer, bool b, long offset)
        {
            var prev = writer.BaseStream.Position;
            writer.Seek(offset);
            writer.Write(b);
            writer.Seek(prev);
        }
        public static void WriteAt(this BinaryWriter writer, byte b, long offset)
        {
            var prev = writer.BaseStream.Position;
            writer.Seek(offset);
            writer.Write(b);
            writer.Seek(prev);
        }
        public static void WriteAt(this BinaryWriter writer, byte[] b, long offset)
        {
            var prev = writer.BaseStream.Position;
            writer.Seek(offset);
            writer.Write(b);
            writer.Seek(prev);
        }
        public static void WriteAt(this BinaryWriter writer, sbyte sb, long offset)
        {
            var prev = writer.BaseStream.Position;
            writer.Seek(offset);
            writer.Write(sb);
            writer.Seek(prev);
        }
        public static void WriteAt(this BinaryWriter writer, short s, long offset)
        {
            var prev = writer.BaseStream.Position;
            writer.Seek(offset);
            writer.Write(s);
            writer.Seek(prev);
        }
        public static void WriteAt(this BinaryWriter writer, ushort us, long offset)
        {
            var prev = writer.BaseStream.Position;
            writer.Seek(offset);
            writer.Write(us);
            writer.Seek(prev);
        }
        public static void WriteAt(this BinaryWriter writer, int i, long offset)
        {
            var prev = writer.BaseStream.Position;
            writer.Seek(offset);
            writer.Write(i);
            writer.Seek(prev);
        }
        public static void WriteAt(this BinaryWriter writer, uint ui, long offset)
        {
            var prev = writer.BaseStream.Position;
            writer.Seek(offset);
            writer.Write(ui);
            writer.Seek(prev);
        }
        public static void WriteAt(this BinaryWriter writer, long l, long offset)
        {
            var prev = writer.BaseStream.Position;
            writer.Seek(offset);
            writer.Write(l);
            writer.Seek(prev);
        }
        public static void WriteAt(this BinaryWriter writer, ulong ul, long offset)
        {
            var prev = writer.BaseStream.Position;
            writer.Seek(offset);
            writer.Write(ul);
            writer.Seek(prev);
        }
    }
}
