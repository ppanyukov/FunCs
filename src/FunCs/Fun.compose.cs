////////////////////////////////////////////////////////////////////////////////
//
// Project Fun - championing functional style.
//
// Copyright (c) 2013 Philip Panyukov
// 
////////////////////////////////////////////////////////////////////////////////


namespace FunCs
{
    using System;

    // Functional composition
    public static partial class Fun
    {
        // ReSharper disable InconsistentNaming

        //  Functional composition

        /// <summary>
        /// Composes two functions f1:(T1->T2) and f3:(T2->T3) into another function f3:(T1-T3)
        /// by feeding result of the first function into the second. The
        /// result is another function which takes paramters of first function and return the
        /// result of the second.
        /// 
        /// Example:
        ///     f1 = int StringToInt(string s);
        ///     f2 = float IntToFloat(int i);
        /// 
        ///     f3 = compose(f1, f2)
        /// 
        ///     The f3 is equivalent of this:
        /// 
        ///     float StringToFloat(string s){
        ///         int i = StringToInt(s)
        ///         float f = IntToFloat(i)
        ///         return f;
        ///     }
        /// 
        /// Can also be used as an extension to build chains of funtions
        /// of arbitrary length:
        /// 
        ///     var megaFun = StringToInt.compose(IntToFoat).compose(FloatToSomethingElse).etc;
        /// 
        /// </summary>
        /// <typeparam name="T1">Type of argument taken by fist function. This will be the type of argument taken by the produced composed function.</typeparam>
        /// <typeparam name="T2">Type of value returned by the first function and type of argument taken by the second function.</typeparam>
        /// <typeparam name="T3">Type of value returned by the second function. This will be the type of value produced by the composed function.</typeparam>
        /// <param name="f1">The function whose result to feed into the second function.</param>
        /// <param name="f2">The function which accepts results from the first function.</param>
        /// <returns>A function which takes argument of first function and returns the value of the second function.</returns>
        public static Func<T1, T3> compose<T1, T2, T3>(this Func<T1, T2> f1, Func<T2, T3> f2)
        {
            return (T1 x1) => f2(f1(x1));
        }


        // ReSharper restore InconsistentNaming
    }
}