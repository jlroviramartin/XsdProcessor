namespace XmlSchemaProcessor
{
    public struct ValueObject<T> where T : struct
    {
        public ValueObject(T t)
        {
            this.@base = t;
        }

        public static implicit operator T(ValueObject<T> vo)
        {
            return vo.@base;
        }

        public static implicit operator ValueObject<T>(T t)
        {
            return new ValueObject<T>(t);
        }

        #region private

        private readonly T @base;

        #endregion

        #region object

        public override bool Equals(object obj)
        {
            T other;
            if (obj is T)
            {
                other = (T)obj;
            }
            else if (obj is ValueObject<T>)
            {
                other = (ValueObject<T>)obj;
            }
            else
            {
                return false;
            }
            return this.@base.Equals(other);
        }

        public override int GetHashCode()
        {
            return this.@base.GetHashCode();
        }

        public override string ToString()
        {
            return this.@base.ToString();
        }

        #endregion
    }
}