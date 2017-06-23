using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    /// <summary>
    /// Статический класс, предоставляющий методы для уточнения корня уравнения вида f(x) = 0 на задаваемом промежутке
    /// </summary>
    static class MethodsСorrectionValueZero_of_Function
    {
        /// <summary>
        /// Вспомагательная структура для сохранения информации о результатах конкретной итерации метода 
        /// </summary>
        public struct M_Info
        {
            /// <summary>
            /// Номер итерации
            /// </summary>
            public uint Iteration;
            /// <summary>
            /// Значение приближения на этой итерации
            /// </summary>
            public double Value_x;
            /// <summary>
            /// Оценка погрешности приближённого значения, полученного на этой итерации
            /// </summary>
            public double Estim;
           /* public bool ErrorInMethod { get; set; }*/

            public M_Info(uint i, double x, double est/*, bool err*/)
            {
                Iteration = i;
                Value_x = x;
                Estim = est;
                /*ErrorInMethod = err;*/
            }
        }

        private static double a = double.NaN, b = double.NaN, eps = 0.00001;

        /// <summary>
        /// Получает и задает значение левого(меньшего по значению) конца отрезка, на котором уточняется корень
        /// </summary>
        public static double A 
        {
            get
            {
                return a;
            }

            set
            {
                if ((double.IsNaN(b)) || (value < b))
                    a = value;
            }    
        }
        /// <summary>
        /// Получает и задает значение правого(большего по значению) конца отрезка, на котором уточняется корень
        /// </summary>
        public static double B 
        {
            get
            {
                return b;
            }
            set
            {
                if ((double.IsNaN(a)) || (value > a))
                    b = value;
            }    
        }
        /// <summary>
        /// Получает и задает значение точности, с которой требуется уточнить корень на заданном отрезке
        /// </summary>
        public static double Eps 
        { 
            get
            {
                return eps;
            }
            set
            {
                if (value > 0)
                    eps = value;
            }                
        }
        /// <summary>
        /// Метод половинного деления(дихотомии)
        /// </summary>
        /// <param name="f">функция вида f(x) в левой части уравнения</param>
        /// <param name="info">список информации о итерациях</param>
        /// <returns></returns>
        public static double M_HalfInterval(Func<double, double> f, out List<M_Info> info)
        {
            info = new List<M_Info>();
            
            if (double.IsNaN(b) || double.IsNaN(a) || (f == null) || (f(A) * f(B) > 0))
            {
                info.Add(new M_Info(0, double.NaN, double.NaN));
                return double.NaN;
            }

            if (f(A) == 0)
            {
                info.Add(new M_Info(0, A, 0));
                return A;
            }

            if (f(B) == 0)
            {
                info.Add(new M_Info(0, B, 0));
                return B;
            }

            uint count_iterations = 0;
            double c_k, a_k = A, b_k = B;
            do
            {
                count_iterations++;
                c_k = (a_k + b_k) / 2;
                if (f(c_k) == 0) //найдено точное значение
                {
                    info.Add(new M_Info(count_iterations, c_k, 0));
                    return c_k;
                }

                if (f(a_k) * f(c_k) < 0)
                    b_k = c_k;
                else a_k = c_k;

                info.Add(new M_Info(count_iterations, (a_k + b_k) / 2, Math.Abs(b_k - a_k)));
            } while (info[info.Count - 1].Estim > Eps);

            return info[info.Count - 1].Value_x;
        }
        /// <summary>
        /// Метод простой итерации
        /// </summary>
        /// <param name="iter_form">итерационная форма для функции вида f(x) в левой части уравнения</param>
        /// <param name="info">список информации о итерациях</param>
        /// <returns></returns>
        public static double M_FixedPointIteration(Func<double, double> iter_form, out List<M_Info> info)
        {
            info = new List<M_Info>();

            if (double.IsNaN(b) || double.IsNaN(a) || (iter_form == null))
            {
                info.Add(new M_Info(0, double.NaN, double.NaN));
                return double.NaN;
            }

            if (iter_form(A) == A)
            {
                info.Add(new M_Info(0, A, 0));
                return A;
            }

            if (iter_form(B) == B)
            {
                info.Add(new M_Info(0, B, 0));
                return B;
            }

            uint count_iterations = 0;
            double x_k = (A + B) / 2;
            double est;
            info.Add(new M_Info(0, x_k, double.NaN));
            do
            {
                count_iterations++;
                x_k = iter_form(x_k);
                if (x_k == iter_form(x_k)) //найдено точное значение
                {
                    info.Add(new M_Info(count_iterations, x_k, 0));
                    return x_k;
                }

                est = Math.Abs(x_k - info[info.Count - 1].Value_x);
                info.Add(new M_Info(count_iterations, x_k, est));
            } while (est > Eps);

            return x_k;
        }
        /// <summary>
        /// Метод хорд
        /// </summary>
        /// <param name="f">функция вида f(x) в левой части уравнения</param>
        /// <param name="der2f">вторая производная для функции f</param>
        /// <param name="info">список информации о итерациях</param>
        /// <returns></returns>
        public static double M_Chord(Func<double, double> f, Func<double, double> der2f, out List<M_Info> info) 
        {
            info = new List<M_Info>();

            if (double.IsNaN(b) || double.IsNaN(a) || (f == null) || (der2f == null) || (f(A) * f(B) > 0))
            {
                info.Add(new M_Info(0, double.NaN, double.NaN));
                return double.NaN;
            }

            if (f(A) == 0)
            {
                info.Add(new M_Info(0, A, 0));
                return A;
            }

            if (f(B) == 0)
            {
                info.Add(new M_Info(0, B, 0));
                return B;
            }

            uint count_iterations = 0;
            double t;           //неподвижный конец
            double x_k;         //приближения результата
            double est;         //оценка погрешности последнего результата
            if ((der2f((A + B) / 2) * f(A)) > 0){ 
                t = A;
                x_k = B;
            }
            else {
                t = B;
                x_k = A;
            }

            info.Add(new M_Info(0, x_k, double.NaN));
            do{
                count_iterations++;
                x_k -= (f(x_k) * (t - x_k)) / (f(t) - f(x_k));  
                if (f(x_k) == 0) //найдено точное значение
                {
                    info.Add(new M_Info(count_iterations, x_k, 0));
                    return x_k;
                }

                est = Math.Abs(x_k - info[info.Count - 1].Value_x);
                info.Add(new M_Info(count_iterations, x_k, est));
            } while (est > Eps);

            return x_k;
        }
        /// <summary>
        /// Метод касательных(метод Ньютона)
        /// </summary>
        /// <param name="f">функция вида f(x) в левой части уравнения</param>
        /// <param name="derf">первая производная для функции f</param>             
        /// <param name="der2f">вторая производная для функции f</param>        
        /// <param name="info">список информации о итерациях</param>
        /// <returns></returns>
        public static double M_Newton(Func<double, double> f, Func<double, double> derf, Func<double, double> der2f, out List<M_Info> info) 
        {
            info = new List<M_Info>();

            if (double.IsNaN(b) || double.IsNaN(a) || (f == null) || (derf == null) || (der2f == null) || (f(A) * f(B) > 0))
            {
                info.Add(new M_Info(0, double.NaN, double.NaN));
                return double.NaN;
            }

            if (f(A) == 0)
            {
                info.Add(new M_Info(0, A, 0));
                return A;
            }

            if (f(B) == 0)
            {
                info.Add(new M_Info(0, B, 0));
                return B;
            }

            uint count_iterations = 0;
            double x_k;         //приближения результата
            double est;         //оценка погрешности последнего результата
            x_k = (der2f(A) * f(A) > 0) ? A : B;

            info.Add(new M_Info(0, x_k, double.NaN));
            do{
                count_iterations++;
                x_k -= f(x_k)/derf(x_k);
                if (f(x_k) == 0)
                {
                    info.Add(new M_Info(count_iterations, x_k, 0));
                    return x_k;
                }

                est = Math.Abs(x_k - info[info.Count - 1].Value_x);
                info.Add(new M_Info(count_iterations, x_k, est));
            } while (est > Eps);

            return x_k;
        }
    }
}
