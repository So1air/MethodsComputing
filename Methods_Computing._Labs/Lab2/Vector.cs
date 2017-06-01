using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Vector
    {
        public const int MAXCOUNTCOORDINATS = ushort.MaxValue;

        private double[] _vectorElements;

        public double this[int i]
        {
            get 
            {
                return _vectorElements[i];
            }
            set 
            {
                _vectorElements[i] = value;
            }
        }

        public int Length
        {
            get
            {
                return _vectorElements.Length;
            }
        }

        public static Vector operator -(Vector v)
        {
            Vector result = new Vector(v._vectorElements.Length);
            for(int i = 0; i < result.Length; i++)
                result._vectorElements[i] = - v._vectorElements[i];

            return result;
        }

        public static Vector operator *(double alfa, Vector v)
        {
            Vector result = new Vector(v._vectorElements);
            for (int i = 0; i < result.Length; i++)
                result[i] *= alfa;
            return result;
        }

        public static double operator *(Vector v1, Vector v2)
        {
            double result = 0;
            for (int i = 0; i < v1.Length; i++)
                result += v1._vectorElements[i] * v2._vectorElements[i];

            return result;
        }

        public static Vector operator +(Vector v1, Vector v2)
        {
            Vector result = new Vector(v1.Length);
            for (int i = 0; i < result.Length; i++)
                result._vectorElements[i] = v1._vectorElements[i] + v2._vectorElements[i];
            
            return result;
        }

        public Vector Copy()
        {
            return new Vector(this._vectorElements);
        }

        public static Vector CreateVector(int length)
        {
            if ((length > 0) && (length <= MAXCOUNTCOORDINATS))
                return new Vector(length);
            else
                return null;
        }             

        public static Vector CreateVector(double[] coordinats)
        {
            if ((coordinats != null) && (coordinats.Length <= MAXCOUNTCOORDINATS))
                return new Vector(coordinats);
            else
                return null;
        }

        private Vector(int len)
        {
            _vectorElements = new double[len];
        }

        private Vector(double[] coordinats)
            :this(coordinats.Length)
        {
            coordinats.CopyTo(_vectorElements, 0);
        }
    }
}
