#nullable disable
using System;

namespace Matrix2dLib
{
    
    public class Matrix2d : IEquatable<Matrix2d>
    {
        private readonly int a, b, c, d; 

        /*
         Matrix representation:
         -------
         | a b |
         | c d |
         -------
        */

       
        public static readonly Matrix2d Id = new Matrix2d(1, 0, 0, 1);
        public static readonly Matrix2d Zero = new Matrix2d(0, 0, 0, 0);

   
        public Matrix2d(int a, int b, int c, int d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }

        public Matrix2d() : this(1, 0, 0, 1) { } 

       
        public override string ToString() => $"[[{a}, {b}], [{c}, {d}]]";

      
        public bool Equals(Matrix2d other)
        {
            if (other is null) return false;
            return a == other.a && b == other.b && c == other.c && d == other.d;
        }

        public override bool Equals(object obj) => obj is Matrix2d other && Equals(other);

        public override int GetHashCode() => HashCode.Combine(a, b, c, d);

        public static bool operator ==(Matrix2d left, Matrix2d right) => left.Equals(right);
        public static bool operator !=(Matrix2d left, Matrix2d right) => !(left == right);

        
        public static Matrix2d operator +(Matrix2d left, Matrix2d right)
            => new Matrix2d(left.a + right.a, left.b + right.b,
                             left.c + right.c, left.d + right.d);

        
        public static Matrix2d operator -(Matrix2d left, Matrix2d right)
            => new Matrix2d(left.a - right.a, left.b - right.b,
                             left.c - right.c, left.d - right.d);

      
        public static Matrix2d operator *(Matrix2d left, Matrix2d right)
            => new Matrix2d(left.a * right.a + left.b * right.c,
                             left.a * right.b + left.b * right.d,
                             left.c * right.a + left.d * right.c,
                             left.c * right.b + left.d * right.d);

        public static Matrix2d operator *(int k, Matrix2d m)
            => new Matrix2d(k * m.a, k * m.b, k * m.c, k * m.d);

        public static Matrix2d operator *(Matrix2d m, int k) => k * m;

        public static Matrix2d operator -(Matrix2d m)
            => new Matrix2d(-m.a, -m.b, -m.c, -m.d);

        public static Matrix2d Transpose(Matrix2d m)
            => new Matrix2d(m.a, m.c, m.b, m.d);

        public int Det() => a * d - b * c;

        public static int Determinant(Matrix2d m) => m.a * m.d - m.b * m.c;

        public static explicit operator int[,](Matrix2d m)
            => new int[2, 2] { { m.a, m.b }, { m.c, m.d } };

        public static Matrix2d Parse(string input)
        {
            try
            {
                input = input.Replace(" ", "").Replace("[[", "").Replace("]]", "");
                var parts = input.Split(new[] { "],[" }, StringSplitOptions.None);
                var row1 = parts[0].Split(',').Select(int.Parse).ToArray();
                var row2 = parts[1].Split(',').Select(int.Parse).ToArray();
                return new Matrix2d(row1[0], row1[1], row2[0], row2[1]);
            }
            catch
            {
                throw new FormatException("Invalid matrix format.");
            }
        }
    }
}