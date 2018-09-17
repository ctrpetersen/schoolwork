using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public static class MathLibrary
    {
        /// <summary>
        /// Adds 2 ints together.
        /// </summary>
        public static int Add(int x, int y)
        {
            return x + y;
        }

        /// <summary>
        /// Adds 3 ints together.
        /// </summary>
        public static int Add(int x, int y, int z)
        {
            return x + y + z;
        }

        /// <summary>
        /// Adds 4 ints together.
        /// </summary>
        public static int Add(int x, int y, int z, int n)
        {
            return x + y + z + n;
        }

        /// <summary>
        /// Adds 2 doubles together.
        /// </summary>
        public static double Add(double x, double y)
        {
            return x + y;
        }

        /// <summary>
        /// Adds 3 doubles together.
        /// </summary>
        public static double Add(double x, double y, double z)
        {
            return x + y + z;
        }

        /// <summary>
        /// Adds 4 doubles together.
        /// </summary>
        public static double Add(double x, double y, double z, double n)
        {
            return x + y + z + n;
        }


        /// <summary>
        /// Int - Subtracts y from x.
        /// </summary>
        public static int Subtract(int x, int y)
        {
            return x - y;
        }

        /// <summary>
        /// Int - Subtracts (y-z) from x.
        /// </summary>
        public static int Subtract(int x, int y, int z)
        {
            return x - (y - z);
        }

        /// <summary>
        /// Int - Subtracts (y-z-n) from x.
        /// </summary>
        public static int Subtract(int x, int y, int z, int n)
        {
            return x - (y - z - n);
        }

        /// <summary>
        /// Double - Subtracts y from x.
        /// </summary>
        public static double Subtract(double x, double y)
        {
            return x - y;
        }

        /// <summary>
        /// Double - Subtracts (y-z) from x.
        /// </summary>
        public static double Subtract(double x, double y, double z)
        {
            return x - (y - z);
        }

        /// <summary>
        /// Double - Subtracts (y-z-n) from x.
        /// </summary>
        public static double Subtract(double x, double y, double z, double n)
        {
            return x - (y - z - n);
        }

        /// <summary>
        /// Int - Multiplies x with y.
        /// </summary>
        public static int Multiply(int x, int y)
        {
            return x * y;
        }

        /// <summary>
        /// Int - Multiplies x with (y*z).
        /// </summary>
        public static int Multiply(int x, int y, int z)
        {
            return x * (y * z);
        }

        /// <summary>
        /// Int - Multiplies x with (y*z*n)
        /// </summary>
        public static int Multiply(int x, int y, int z, int n)
        {
            return x * (y * z * n);
        }

        /// <summary>
        /// Double - Multiplies x with y.
        /// </summary>
        public static double Multiply(double x, double y)
        {
            return x * y;
        }

        /// <summary>
        /// Double - Multiplies x with (y*z).
        /// </summary>
        public static double Multiply(double x, double y, double z)
        {
            return x * (y * z);
        }

        /// <summary>
        /// Double - Multiplies x with (y*z*n)
        /// </summary>
        public static double Multiply(double x, double y, double z, double n)
        {
            return x * (y * z * n);
        }

        /// <summary>
        /// Int - Divides x by y
        /// </summary>
        public static int Divide(int x, int y)
        {
            return x / y;
        }

        /// <summary>
        /// Int - Divides x by (y/z)
        /// </summary>
        public static int Divide(int x, int y, int z)
        {
            return x / (y / z);
        }

        /// <summary>
        /// Int - Divides x by (y/z/n)
        /// </summary>
        public static int Divide(int x, int y, int z, int n)
        {
            return x / (y / z / n);
        }

        /// <summary>
        /// Double - Divides x by y
        /// </summary>
        public static double Divide(double x, double y)
        {
            return x / y;
        }

        /// <summary>
        /// Double - Divides x by (y/z)
        /// </summary>
        public static double Divide(double x, double y, double z)
        {
            return x / (y / z);
        }

        /// <summary>
        /// Double - Divides x by (y/z/n)
        /// </summary>
        public static double Divide(double x, double y, double z, double n)
        {
            return x / (y / z / n);
        }
    }
}
