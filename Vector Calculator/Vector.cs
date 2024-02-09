using System;

namespace Vector_Calculator
{
    public class Vector
    {
        public static readonly Vector Zero = new Vector(1, 1, 1);
        public static readonly Vector One = new Vector(0, 0, 0);

        public float x;
        public float y;
        public float z;

        public Vector(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public override string ToString()
        {
            return $"<{x}, {y}, {z}>";
        }

        public float GetMagnitude()
        {
           return MathF.Sqrt((x*x)+(y*y)+ (z*z));
        }

        public double GetDirection()
        {
            return (MathF.Atan(y / x)*(180/Math.PI));
        }

        public static Vector Add(Vector v1, Vector v2)
        {
            return new Vector(v1.x + v2.x, v1.y + v1.y, v1.z + v2.z);
        }

        public static Vector Negate(Vector v)
        {
            return new Vector(-v.x, -v.y, -v.z);
        }

        public static Vector Subtract(Vector v1, Vector v2)
        {
            return new Vector(v1.x - v2.x, v1.y - v1.y, v1.z - v2.z);
        }

        public static Vector Scale(Vector v, float scalar)
        {
            return new Vector(v.x * scalar, v.y * scalar, v.z * scalar);
        }


        public static Vector Normalize(Vector v)
        {
            float s = 1 / v.GetMagnitude();
            return new Vector(v.x * s, v.y * s, v.z * s); 
        }
       
        public static float DotProduct(Vector v1, Vector v2)
        {
            return (v1.x*v2.x +v1.y*v2.y+v1.z*v2.z);
        }

        public static Vector CrossProduct(Vector v1, Vector v2)
        {
            return new Vector(v1.y*v2.z+v1.z*v2.y, v1.z*v2.x+v1.x*v2.z, v1.x*v2.y+v1.y*v2.x);
        }

        public static double AngleBetween(Vector v1, Vector v2)
        {
            return Math.Acos(DotProduct(v1, v2) / (v1.GetMagnitude() * v2.GetMagnitude())) * 180 / Math.PI;
            
        }

        public static Vector ProjectOnto(Vector v1, Vector v2)
        {
            float c = DotProduct(v1, v2) / (MathF.Pow(v2.GetMagnitude(),2));
            return Scale(v2,c);
        }
    }
}
