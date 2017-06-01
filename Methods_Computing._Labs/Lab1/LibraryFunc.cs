using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class LibraryFunc
    {
        /// <summary>
        /// Вспомогательная структура, об'единяющая хранимые в себе функцию и её текстовый вид
        /// </summary>
        private struct FuncWithText
        {       
            /// <summary>
            /// Вещественная функция от одного переменного 
            /// </summary>
            public Func<double, double> F;
            /// <summary>
            /// Текстовый вид функции F
            /// </summary>
            public string T;           
        }

        /// <summary>
        /// Вспомогательный класс, об'единяющий хранимые в себе функцию, некоторые её производные 
        /// и итерационную формулу в виде структур типа FuncWithText 
        /// </summary>
        private class FuncInfo
        {
            /// <summary>
            /// Вещественная функция от одного переменного и её текстовый вид
            /// </summary>
            public FuncWithText Function;
            /// <summary>
            /// Некоторые производные функции Function и их текстовые виды
            /// </summary>
            public Dictionary<uint, FuncWithText> list_derivativesOfFunction;            
            /// <summary>
            /// Итерационная функция функции Function и её текстовый вид(используется в методе хорд)
            /// </summary>
            public FuncWithText IterForm;

            public FuncInfo(Func<double, double> func, string text_func)
            {
                Function = new FuncWithText{F = func, T = text_func};                
                list_derivativesOfFunction = new Dictionary<uint, FuncWithText>();
                IterForm = new FuncWithText { F = null, T = "" };
            }
        }

        private List<FuncInfo> listFunction = new List<FuncInfo>(); 
       
        /// <summary>
        /// Метод для добавления новых функций
        /// </summary>
        /// <param name="textFunc">текстовый вид функции</param>
        /// <returns>показывает была ли добавлена функция</returns>
        public bool AddFuncAsText(string textFunc)
        {
            Func<double, double> f = TextToFuncTranslater.CreateFuncFromText(textFunc);
            if (f != null)
            {
                listFunction.Add(new FuncInfo(f, textFunc));
                return true;
            }

            return false;
        }

        /// <summary>
        /// Метод для добавления новых производных ранее добавленной функции 
        /// </summary>
        /// <param name="indFunc">индекс ранее добавленной функции</param>
        /// <param name="derivOrder">порядок добавляемой производной</param>
        /// <param name="textDerivative">текстовый вид добавляемой производной</param>
        /// <returns>показывает была ли добавлена производная</returns>
        public bool AddDerivativeOfFuncAsText(uint indFunc, uint derivOrder, string textDerivative) 
        {
            if ((indFunc < listFunction.Count) && (derivOrder > 0))
                if (!listFunction[(int)indFunc].list_derivativesOfFunction.ContainsKey(derivOrder))
                {                   
                    //пытаемся превратить текст в функцию
                    Func<double, double> dF = TextToFuncTranslater.CreateFuncFromText(textDerivative);
                    if (dF != null)
                    {
                        listFunction[(int)indFunc].list_derivativesOfFunction.Add(derivOrder, new FuncWithText { F = dF, T = textDerivative });
                        return true;
                    }
                }
            return false;
        }

        /// <summary>
        /// Метод для изменения ранее добавленных производных ранее добавленной функции 
        /// </summary>
        /// <param name="indFunc">индекс ранее добавленной функции</param>
        /// <param name="derivOrder">порядок ранее добавленной производной</param>
        /// <param name="textDerivative">новый текстовый вид производной</param>
        /// <returns>показывает была ли изменена производная</returns>
        public bool ChangeDerivativeOfFuncAsText(uint indFunc, uint derivOrder, string textDerivative) 
        {
            if ((indFunc < listFunction.Count) && (derivOrder > 0))
                if (listFunction[(int)indFunc].list_derivativesOfFunction.ContainsKey(derivOrder))
                {
                    //пытаемся превратить текст в функцию
                    Func<double, double> dF = TextToFuncTranslater.CreateFuncFromText(textDerivative);
                    if (dF != null)
                    {
                        listFunction[(int)indFunc].list_derivativesOfFunction[derivOrder] = new FuncWithText { F = dF, T = textDerivative };
                        return true;
                    }                    
                }
            return false;
        }

        /// <summary>
        /// Метод для добавления итерационной формулы-функции ранее добавленной функции 
        /// </summary>
        /// <param name="indFunc">индекс ранее добавленной функции</param>
        /// <param name="textIterForm">текстовый вид добавляемой итерационной формулы-функции</param>
        /// <returns>показывает была ли добавлена итерационная формула-функция</returns>
        public bool AddIterFormAsText(uint indFunc, string textIterForm) 
        {
            if (indFunc < listFunction.Count)
                if (listFunction[(int)indFunc].IterForm.F == null)
                {
                    //пытаемся превратить текст в функцию
                    Func<double, double> IF = TextToFuncTranslater.CreateFuncFromText(textIterForm);
                    if (IF != null)
                    {
                        listFunction[(int)indFunc].IterForm = new FuncWithText() { F = IF, T = textIterForm };                        
                        return true;
                    }                   
                }

            return false;
        }

        /// <summary>
        /// Метод для изменения итерационной формулы-функции ранее добавленной функции 
        /// </summary>
        /// <param name="indFunc">индекс ранее добавленной функции</param>
        /// <param name="textIterForm">новый текстовый вид итерационной формулы-функции</param>
        /// <returns>показывает была ли изменена итерационная формула-функция</returns>
        public bool ChangeIterFormAsText(uint indFunc, string textIterForm) 
        {
            if (indFunc < listFunction.Count)
            {
                //пытаемся превратить текст в функцию
                Func<double, double> IF = TextToFuncTranslater.CreateFuncFromText(textIterForm);
                if (IF != null)
                {
                    listFunction[(int)indFunc].IterForm = new FuncWithText() { F = IF, T = textIterForm };
                    return true;
                }                
            }

            return false;
        }

        public string GetTextFunc(uint indFunc)
        {
            return getFunction((int)indFunc).T;
        }

        public Func<double, double> GetFunc(uint indFunc)
        {
            return getFunction((int)indFunc).F;
        }

        private FuncWithText getFunction(int indFunc)
        {
            return (indFunc < listFunction.Count) ? (listFunction[indFunc].Function) : (new FuncWithText { F = null, T = null });
        }

        public string GetTextDerivativeOfFunc(uint indFunc, uint derivOrder)
        {
            return getDerivativeOfFunc(indFunc, derivOrder).T;
        }

        public Func<double, double> GetDerivativeOfFunc(uint indFunc, uint derivOrder)
        {
            return getDerivativeOfFunc(indFunc, derivOrder).F;
        }

        private FuncWithText getDerivativeOfFunc(uint indFunc, uint derivOrder)
        {
            if (indFunc < listFunction.Count)
                if (listFunction[(int)indFunc].list_derivativesOfFunction.ContainsKey(derivOrder))
                    return listFunction[(int)indFunc].list_derivativesOfFunction[derivOrder];

            return new FuncWithText { F = null, T = null };
        }

        public string GetTextIterForm(uint indFunc)
        {
            return getIterForm(indFunc).T;
        }

        public Func<double, double> GetIterForm(uint indFunc)
        {
            return getIterForm(indFunc).F;
        }

        private FuncWithText getIterForm(uint indFunc)
        {
            if (indFunc < listFunction.Count)
                return listFunction[(int)indFunc].IterForm;

            return new FuncWithText { F = null, T = null };
        }
    }
}
