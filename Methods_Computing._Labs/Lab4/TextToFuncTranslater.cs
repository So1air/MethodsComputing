using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateGenerator
{
    class TextToFuncTranslater
    {
        private const string NAME_FUNCTION = "Function";

        private static string GetSourceCodeOneArgFunction(string textFunc) 
        {
            //тут должно быть преобразование более удобного текста функции в исходный текст на языке С#   

            return "public static double " + NAME_FUNCTION + "(double x) { return " + textFunc + "; }"; 
        }        

        public static Func<double, double> CreateOneArgFuncFromText(string sourceTextOfFunc)
        {
            DelegateGenerator.DelegateInfo<Func<double, double>> funcInfo = DelegateGenerator.CreateDelegateInfo< Func<double, double> >("OneArgFunc", NAME_FUNCTION, GetSourceCodeOneArgFunction(sourceTextOfFunc));
            if (funcInfo.WasError)
                return null;          // funcInfo.ErrorText будет содержать текст ошибки компиляции
            else return funcInfo.Exec;
        }

        private static string GetSourceCodeTwoArgFunction(string textFunc)
        {
            //тут должно быть преобразование более удобного текста функции в исходный текст на языке С#   

            return "public static double " + NAME_FUNCTION + "(double x, double y) { return " + textFunc + "; }";
        }

        public static Func<double, double, double> CreateTwoArgFuncFromText(string sourceTextOfFunc)
        {
            DelegateGenerator.DelegateInfo<Func<double, double, double>> funcInfo = DelegateGenerator.CreateDelegateInfo<Func<double, double, double>>("TwoArgFunc", NAME_FUNCTION, GetSourceCodeTwoArgFunction(sourceTextOfFunc));
            if (funcInfo.WasError)
                return null;          // funcInfo.ErrorText будет содержать текст ошибки компиляции
            else return funcInfo.Exec;
        }
    }
}
