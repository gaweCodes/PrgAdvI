using System;

namespace Vector
{
    internal class Vector
    {
        protected bool Equals(Vector other)
        {
            return _x.Equals(other._x) && _y.Equals(other._y) && _z.Equals(other._z);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == this.GetType() && Equals((Vector) obj);
        }
        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = _x.GetHashCode();
                hashCode = (hashCode * 397) ^ _y.GetHashCode();
                hashCode = (hashCode * 397) ^ _z.GetHashCode();
                return hashCode;
            }
        }

        private double _x;
        private double _y;
        private double _z;
        public Vector()
        {
            _x = 0;
            _y = 0;
            _z = 0;
        }
        public Vector(double x, double y, double z)
        {
            _x = x;
            _y = y;
            _z = z;
        }
        public double this[int index]
        {
            get {
                switch (index)
                {
                    case 1: return _x;
                    case 2: return _y;
                    case 3: return _z;
                    default: throw new ArgumentOutOfRangeException(nameof(index));
                }
            }
            set
            {
                switch (index)
                {
                    case 1: _x = value; break;
                    case 2: _y = value; break;
                    case 3: _z = value; break;
                    default: throw new ArgumentOutOfRangeException(nameof(index));
                }
            }
        }
        public static Vector operator + (Vector v1, Vector v2)
        {
            return new Vector(v1._x + v2._x, v1._y + v2._y, v1._z + v2._z);
        }
        public static Vector operator -(Vector v1, Vector v2)
        {
            return new Vector(v1._x - v2._x, v1._y - v2._y, v1._z - v2._z);
        }
        public static Vector operator *(Vector v1, double multiplier)
        {
            return new Vector(v1._x * multiplier, v1._y * multiplier, v1._z * multiplier);
        }
        public static Vector operator *(double multiplier, Vector v1)
        {
            return new Vector(v1._x * multiplier, v1._y * multiplier, v1._z * multiplier);
        }
        public static Vector operator *(Vector v1, Vector v2)
        {
            return new Vector(v1._y * v2._z - v1._z*v2._y, v1._z * v2._x - v1._x * v2._z, v1._x * v2._y - v1._y * v2._x);
        }
        public static explicit operator double (Vector v)
        {
            return Amount(v);
        }
        public static implicit operator Vector (double value)
        {
            return new Vector(value,0,0);
        }

        public static bool operator ==(Vector v1, Vector v2)
        {
            return v1.Equals(v2);
        }
        public static bool operator !=(Vector v1, Vector v2)
        {
            return !(v1 == v2);
        }
        private static double Amount(Vector v)
        {
            return Math.Sqrt(v._x * v._x + v._y + v._y + v._z * v._z);
        }
        public override string ToString()
        {
            return $"X= {_x}{Environment.NewLine}Y= {_y}{Environment.NewLine}Z= {_z}{Environment.NewLine}";
        }
    }
}
