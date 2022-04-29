using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2
{
    class CaesarStream : Stream
    {
        private Stream stream;
        private int shift;
        public CaesarStream(Stream stream, int shift)
        {
            this.stream = stream;
            this.shift = shift;
        }

        public override bool CanRead => stream.CanRead;
        public override bool CanSeek => stream.CanSeek;
        public override bool CanWrite => stream.CanWrite;
        public override long Length => stream.Length;
        public override long Position { get => stream.Position; set => stream.Position = value; }
        public override void Flush(){ stream.Flush(); }
        public override long Seek(long offset, SeekOrigin origin) { return stream.Seek(offset, origin); }
        public override void SetLength(long value){stream.SetLength(value); }
        
        
        public override void Write(byte[] buffer, int offset, int count)
        {
            var newBuffer = new byte[buffer.Length];
            for (int i = offset; i < buffer.Length; i++)
            {
                newBuffer[i] = (byte)(((int)buffer[i] + this.shift) % 255);
            }
            this.stream.Write(newBuffer, offset, count);
        }
        public override int Read(byte[] buffer, int offset, int count)
        {
            var result = this.stream.Read(buffer, offset, count);
            for (int i = offset; i < buffer.Length; i++)
            {
                buffer[i] = (byte)(((int)buffer[i] + this.shift) % 255);
            }
            return result;
        }
    }
}
