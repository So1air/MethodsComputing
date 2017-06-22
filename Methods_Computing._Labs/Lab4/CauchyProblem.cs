using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DelegateGenerator;

namespace Lab4
{
    class CauchyProblem
    {
        public Func<double, double, double> DerivativeFunc { get; private set; }
        public string TextDerivativeFunc { get; private set; }
        public OneArgFuncPoint InitialValue { get; private set; }
        public double A { get; private set; }     //будет пока неиспользуемым параметром, а в качестве начала отрезка будем брать x0(первая координата InitialValue)
        public double B { get; private set; }

        public Func<double, double> ExactSolution { get; private set; }
        public string TextExactSolution { get; private set; }

        public OneArgFuncPoint[] ResultEulerMethod { get; private set; }
        public OneArgFuncPoint[] ResultEulerCauchyMethod { get; private set; }
        public OneArgFuncPoint[] ResultEulerMethodCorr { get; private set; }
        public OneArgFuncPoint[] ResultRungeKuttaMethod { get; private set; }
        public OneArgFuncPoint[] ResultAdamsMethod { get; private set; }

        public bool SetExactSolution(string y_x_)
        {
            if (y_x_ != null)
            {
                Func<double, double> exact = TextToFuncTranslater.CreateOneArgFuncFromText(y_x_);
                if ((exact != null) && (exact(this.InitialValue.Arg) == this.InitialValue.Func))
                {
                    this.ExactSolution = exact;
                    this.TextExactSolution = y_x_;
                    return true;
                }
            }

            return false;
        }

        public bool ReSolutionEulerMethod(ushort N)
        {
            if (N > 0)
            {
                OneArgFuncPoint[] res = new OneArgFuncPoint[N + 1];
                res[0] = InitialValue;
                double h = (this.B - this.InitialValue.Arg) / N;
                try
                {
                    for (int i = 0; i < N; i++)
                        res[i + 1] = new OneArgFuncPoint(res[i].Arg + h, res[i].Func + h * DerivativeFunc(res[i].Arg, res[i].Func));
                    this.ResultEulerMethod = res;
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            return false;
        }

        public bool ReSolutionEulerCauchyMethod(ushort N)
        {
            if (N > 0)
            {
                OneArgFuncPoint[] res = new OneArgFuncPoint[N + 1];
                res[0] = InitialValue;
                double h = (this.B - this.InitialValue.Arg) / N;
                try
                {
                    for (int i = 0; i < N; i++)
                        res[i + 1] = new OneArgFuncPoint(res[i].Arg + h, res[i].Func + h * DerivativeFunc(res[i].Arg, res[i].Func));
                    for (int i = 0; i < N; i++)
                        res[i + 1] = new OneArgFuncPoint(res[i + 1].Arg, res[i].Func + (h / 2) * (DerivativeFunc(res[i].Arg, res[i].Func) + DerivativeFunc(res[i + 1].Arg, res[i + 1].Func)));
                    this.ResultEulerCauchyMethod = res;
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            return false;
        }

        public bool ReSolutionEulerMethodCorr(ushort N, double eps, out uint k)
        {
            k = 0;
            if ((N > 0) && (eps > 0))
            {
                OneArgFuncPoint[] res0 = new OneArgFuncPoint[N + 1];
                OneArgFuncPoint[] res1 = new OneArgFuncPoint[N + 1];
                res0[0] = InitialValue;
                res1[0] = InitialValue;
                bool flag_last = false,
                     not_find_solution = true;
                double h = (this.B - this.InitialValue.Arg) / N;
                try
                {
                    for (int i = 0; i < N; i++)
                        res0[i + 1] = new OneArgFuncPoint(res0[i].Arg + h, res0[i].Func + h * DerivativeFunc(res0[i].Arg, res0[i].Func));
                    do
                    {
                        flag_last = !flag_last; k++;
                        if (flag_last)
                            for (int i = 0; i < N; i++)
                                res1[i + 1] = new OneArgFuncPoint(res0[i + 1].Arg,
                                    res1[i].Func + (h / 2) * (DerivativeFunc(res1[i].Arg, res1[i].Func) + DerivativeFunc(res0[i + 1].Arg, res0[i + 1].Func)));
                        else
                            for (int i = 0; i < N; i++)
                                res0[i + 1] = new OneArgFuncPoint(res1[i + 1].Arg,
                                    res0[i].Func + (h / 2) * (DerivativeFunc(res0[i].Arg, res0[i].Func) + DerivativeFunc(res1[i + 1].Arg, res1[i + 1].Func)));
                        not_find_solution = false;
                        for (int i = 1; (i <= N) && (!not_find_solution); i++)
                            not_find_solution = (Math.Abs(res1[i].Func - res0[i].Func) >= eps);
                    } while (not_find_solution);

                    this.ResultEulerMethodCorr = (flag_last) ? res1 : res0;
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            return false;
        }

        public bool ReSolutionRungeKutta(ushort N, double eps, bool autostep, out double[,] k) //3-го порядка точности
        {
            if ((N > 0) && (eps > 0))
                if (autostep)
                {
                    double h = this.B - this.InitialValue.Arg, 
                           h_half = h / 2;
                    double y1, y_half, y2,
                           k1, k2, k3,
                           delta;
                    List<OneArgFuncPoint> res = new List<OneArgFuncPoint>();
                    res.Add(InitialValue);
                    try
                    {
                        bool no_first;
                        for (int i = 0; res[i].Arg < this.B; i++)
                        {
                            if (res[i].Arg + h > this.B) //проверяем выход на точку B                                
                                h_half = (h = this.B - res[i].Arg) / 2; //вышли на точку B

                            no_first = false;
                            do
                            {
                                if (no_first) h_half = (h = h_half) / 2; //уменьшаем шаг
                                no_first = true;
                                #region для нечётного варианта
                                k1 = h * DerivativeFunc(res[i].Arg,         res[i].Func);
                                k2 = h * DerivativeFunc(res[i].Arg + h / 2, res[i].Func + (k1 / 2));
                                k3 = h * DerivativeFunc(res[i].Arg + h,     res[i].Func - k1 + (2 * k2));
                                y1 = res[i].Func + (k1 + 4 * k2 + k3) / 6;

                                k1 = h_half * DerivativeFunc(res[i].Arg,              res[i].Func);
                                k2 = h_half * DerivativeFunc(res[i].Arg + h_half / 2, res[i].Func + (k1 / 2));
                                k3 = h_half * DerivativeFunc(res[i].Arg + h_half,     res[i].Func - k1 + (2 * k2));
                                y_half = res[i].Func + (k1 + 4 * k2 + k3) / 6;

                                k1 = h_half * DerivativeFunc(res[i].Arg + h_half,              y_half);
                                k2 = h_half * DerivativeFunc(res[i].Arg + h_half + h_half / 2, y_half + (k1 / 2));
                                k3 = h_half * DerivativeFunc(res[i].Arg + h,                   y_half - k1 + (2 * k2));
                                y2 = y_half + (k1 + 4 * k2 + k3) / 6;
                                #endregion

                                #region для чётного варианта
                                /*k1 = h * DerivativeFunc(res[i].Arg,             res[i].Func);
                                k2 = h * DerivativeFunc(res[i].Arg + h / 3,     res[i].Func + (k1 / 3));
                                k3 = h * DerivativeFunc(res[i].Arg + 2 * h / 3, res[i].Func + (2 * k2 / 3));
                                y1 = res[i].Func + (k1 + 3 * k3) / 4;

                                k1 = h_half * DerivativeFunc(res[i].Arg,                  res[i].Func);
                                k2 = h_half * DerivativeFunc(res[i].Arg + h_half / 3,     res[i].Func + (k1 / 3));
                                k3 = h_half * DerivativeFunc(res[i].Arg + 2 * h_half / 3, res[i].Func + (2 * k2 / 3));
                                y_half = res[i].Func + (k1 + 3 * k3) / 4;

                                k1 = h_half * DerivativeFunc(res[i].Arg + h_half,                  y_half);
                                k2 = h_half * DerivativeFunc(res[i].Arg + h_half + h_half / 3,     y_half + (k1 / 3));
                                k3 = h_half * DerivativeFunc(res[i].Arg + h_half + 2 * h_half / 3, y_half + (2 * k2 / 3));
                                y2 = y_half + (k1 + 3 * k3) / 4;*/
                                #endregion
                            } while ((delta = Math.Abs(y2 - y1) / 7) >= eps);
                          
                            res.Add(new OneArgFuncPoint(res[i].Arg + h, y2 + (y2 - y1) / 7));
                            if (delta < eps / 16)
                                h = 2 * (h_half = h);  //увеличиваем шаг
                            
                        }
                        this.ResultRungeKuttaMethod = res.ToArray();
                        k = null;
                        return true;
                    }
                    catch(Exception)
                    {                        
                    }
                }
                else
                {
                    k = new double[N, 3];
                    OneArgFuncPoint[] res = new OneArgFuncPoint[N + 1];
                    res[0] = InitialValue;
                    double h = (this.B - this.InitialValue.Arg) / N;
                    try
                    {
                        for (int i = 0; i < N; i++)
                        {
                            k[i, 0] = h * DerivativeFunc(res[i].Arg, res[i].Func);
                            #region для нечётного варианта
                            /*k[i, 1] = h * DerivativeFunc(res[i].Arg + h / 2,  res[i].Func + (k[i, 0] / 2));
                              k[i, 2] = h * DerivativeFunc(res[i].Arg + h,      res[i].Func - k[i, 0] + 2 * k[i, 1]);
                              res[i + 1] = new OneArgFuncPoint(res[i].Arg + h,  res[i].Func + (k[i, 0] + 4 * k[i, 1] + k[i, 2]) / 6);*/
                            #endregion
                            #region для чётного варианта
                            k[i, 1] = h * DerivativeFunc(res[i].Arg + h / 3,      res[i].Func + (k[i, 0] / 3));
                            k[i, 2] = h * DerivativeFunc(res[i].Arg + 2 * h / 3,  res[i].Func + (2 * k[i, 1] / 3));
                            res[i + 1] = new OneArgFuncPoint(res[i].Arg + h,      res[i].Func + (k[i, 0] + 3 * k[i, 2]) / 4);
                            #endregion
                        }
                        this.ResultRungeKuttaMethod = res;
                        return true;
                    }
                    catch (Exception)
                    {                        
                    }
                }
            k = null;
            return false;
        }

        public bool ReSolutionAdams(ushort N, double eps)
        {
            if (N > 0 && eps > 0)
            {
                double h = this.B - this.InitialValue.Arg,
                            h_half = h / 2;
                double y1, y_half, y2,
                       k1, k2, k3,
                       delta;
                List<OneArgFuncPoint> res = new List<OneArgFuncPoint>();
                res.Add(InitialValue);
                try
                {
                    bool no_first;
                    for (int i = 0; (res[i].Arg < this.B) && (i < 2); i++)
                    {
                        if (res[i].Arg + h > this.B) //проверяем выход на точку B                                
                            h_half = (h = this.B - res[i].Arg) / 2; //вышли на точку B

                        no_first = false;
                        do
                        {
                            if (no_first) h_half = (h = h_half) / 2; //уменьшаем шаг
                            no_first = true;
                            #region для нечётного варианта
                            k1 = h * DerivativeFunc(res[i].Arg, res[i].Func);
                            k2 = h * DerivativeFunc(res[i].Arg + h / 2, res[i].Func + (k1 / 2));
                            k3 = h * DerivativeFunc(res[i].Arg + h, res[i].Func - k1 + (2 * k2));
                            y1 = res[i].Func + (k1 + 4 * k2 + k3) / 6;

                            k1 = h_half * DerivativeFunc(res[i].Arg, res[i].Func);
                            k2 = h_half * DerivativeFunc(res[i].Arg + h_half / 2, res[i].Func + (k1 / 2));
                            k3 = h_half * DerivativeFunc(res[i].Arg + h_half, res[i].Func - k1 + (2 * k2));
                            y_half = res[i].Func + (k1 + 4 * k2 + k3) / 6;

                            k1 = h_half * DerivativeFunc(res[i].Arg + h_half, y_half);
                            k2 = h_half * DerivativeFunc(res[i].Arg + h_half + h_half / 2, y_half + (k1 / 2));
                            k3 = h_half * DerivativeFunc(res[i].Arg + h, y_half - k1 + (2 * k2));
                            y2 = y_half + (k1 + 4 * k2 + k3) / 6;
                            #endregion

                            #region для чётного варианта
                            /*k1 = h * DerivativeFunc(res[i].Arg,             res[i].Func);
                            k2 = h * DerivativeFunc(res[i].Arg + h / 3,     res[i].Func + (k1 / 3));
                            k3 = h * DerivativeFunc(res[i].Arg + 2 * h / 3, res[i].Func + (2 * k2 / 3));
                            y1 = res[i].Func + (k1 + 3 * k3) / 4;

                            k1 = h_half * DerivativeFunc(res[i].Arg,                  res[i].Func);
                            k2 = h_half * DerivativeFunc(res[i].Arg + h_half / 3,     res[i].Func + (k1 / 3));
                            k3 = h_half * DerivativeFunc(res[i].Arg + 2 * h_half / 3, res[i].Func + (2 * k2 / 3));
                            y_half = res[i].Func + (k1 + 3 * k3) / 4;

                            k1 = h_half * DerivativeFunc(res[i].Arg + h_half,                  y_half);
                            k2 = h_half * DerivativeFunc(res[i].Arg + h_half + h_half / 3,     y_half + (k1 / 3));
                            k3 = h_half * DerivativeFunc(res[i].Arg + h_half + 2 * h_half / 3, y_half + (2 * k2 / 3));
                            y2 = y_half + (k1 + 3 * k3) / 4;*/
                            #endregion
                        } while ((delta = Math.Abs(y2 - y1) / 7) >= eps);

                        res.Add(new OneArgFuncPoint(res[i].Arg + h, y2 + (y2 - y1) / 7));
                        if (delta < eps / 16)
                            h = 2 * (h_half = h);  //увеличиваем шаг
                    }
                    if ((res.Count == 3) && (res[2].Arg < this.B))
                    {                       
                        h = (this.B - res[2].Arg) / N;
                        for (int i = 2, n = N + 2; i < n; i++)
                            res.Add(new OneArgFuncPoint(res[i].Arg + h, 
                                res[i].Func + h * (23 * DerivativeFunc(res[i].Arg, res[i].Func) - 16 * DerivativeFunc(res[i - 1].Arg, res[i - 1].Func) + 5 * DerivativeFunc(res[i - 2].Arg, res[i - 2].Func)) / 12));
                    }
                    
                    this.ResultAdamsMethod = res.ToArray();
                    return true;
                }
                catch (Exception)
                {
                }
            }
            return false;
        }

        public override string ToString()
        {
            return this.TextDerivativeFunc;
        }

        public static CauchyProblem CreateInstance(string rightPartEquation, double x0, double y0, double a, double b)
        {
            Func<double, double, double> derF = TextToFuncTranslater.CreateTwoArgFuncFromText(rightPartEquation);
            if ((derF != null) && (a < b) && (x0 >= a) && (x0 <= b))
                return new CauchyProblem(rightPartEquation, derF, x0, y0, a, b);
            else
                return null;
        }

        private CauchyProblem(string textDerivative, Func<double, double, double> derivative, double x0, double y0, double a, double b)
        {
            this.DerivativeFunc = derivative;
            this.TextDerivativeFunc = textDerivative;
            this.InitialValue = new OneArgFuncPoint(x0, y0);
            this.A = a;
            this.B = b;
        }
    }
}
