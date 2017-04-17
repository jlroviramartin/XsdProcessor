using System.Linq;

namespace XmlSchemaProcessor
{
    public class Path
    {
        public static readonly Path Empty = new Path(new int[0]);

        public Path(params int[] value)
        {
            this.value = value;
        }

        public bool IsEmpty()
        {
            return this.value.Length == 0;
        }

        public int Head()
        {
            return this.value[0];
        }

        public Path Tail()
        {
            return new Path(this.value.Skip(1).ToArray());
        }

        public Path Sub(int i)
        {
            return new Path(this.value.Concat(new[] { i }).ToArray());
        }

        private readonly int[] value;
    }
}