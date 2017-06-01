using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class SystemOfLinearAlgebraicEquations
    {
        public enum MethodsForSolution { MethodOfGaussianElimination, Square_RootMethod, TridiagonalMatrixAlgorithm, MethodOfSuccessiveIteration, SeidelMethod }

        private Matrix2D _a;
        private Vector _f;      

        public Matrix2D A
        {
            get { return _a; }
        }

        public Vector F
        {
            get { return _f; }
        }

        private Vector MethodOfGaussianElimination()
        {
            throw new NotImplementedException();
        }

        private Vector Square_RootMethod()
        {
            throw new NotImplementedException();

        }

        private Vector TridiagonalMatrixAlgorithm()
        {
            throw new NotImplementedException();

        }

        private Vector MethodOfSuccessiveIteration()
        {
            throw new NotImplementedException();
        }

        private Vector SeidelMethod()
        {
            throw new NotImplementedException();
        }

        public Vector GetSolution()
        {
            throw new NotImplementedException();

        }

        public Vector GetSolution(MethodsForSolution method)
        {
            switch (method)
            {
                case MethodsForSolution.MethodOfGaussianElimination:
                    break;

                case MethodsForSolution.Square_RootMethod:
                    break;

                case MethodsForSolution.TridiagonalMatrixAlgorithm:
                    break;

                case MethodsForSolution.MethodOfSuccessiveIteration:
                    break;

                case MethodsForSolution.SeidelMethod:
                    break;

                default:
                    return null;
            }

            return Vector.CreateVector(0);
        }

        public SystemOfLinearAlgebraicEquations Copy()
        {
            return new SystemOfLinearAlgebraicEquations(this._a, this._f);
        }

        public static SystemOfLinearAlgebraicEquations CreateSystem(Matrix2D coefficientsOfTheSystem, Vector constantTerms)
        {
            if ((coefficientsOfTheSystem != null) && (constantTerms != null) && (coefficientsOfTheSystem.RowCount == constantTerms.Length))
                return new SystemOfLinearAlgebraicEquations(coefficientsOfTheSystem, constantTerms);
            else
                return null;
        }

        private SystemOfLinearAlgebraicEquations(Matrix2D coefficientsOfTheSystem, Vector constantTerms)
        {
            _a = coefficientsOfTheSystem.Copy();
            _f = constantTerms.Copy();
        }
    }
}
