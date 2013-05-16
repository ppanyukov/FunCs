////////////////////////////////////////////////////////////////////////////////
//
// Project Fun - championing functional style.
//
// Copyright (c) 2013 Philip Panyukov
// 
////////////////////////////////////////////////////////////////////////////////


namespace Fun.Csex
{
    using System;

    // Using 'var' to declare lamdas.
    public static partial class FunFun
    {
        // ReSharper disable InconsistentNaming

        // Syntax sugar for lamdas.
        // 
        // Enables to use var to declare lambdas like this:
        //
        //  // Not a valid syntax in C#!
        //  var f = (int x) => x.ToString();
        //
        // This of course is not possible directly, but is possible with:
        //
        //  // Legal C# and gives us what we want.
        //  var f = function((int x) => x.ToString());
        //
        //  This is similar with JavaScript
        //
        //  // JavaScript:
        //  var f = function(x) { toString(x); }
        // 
        // Supports Func<T> with up to a 10 type parameters.
        //
        // The idea behind this is:
        //   1. C# allows lambdas as arguments to methods/functions.
        //   2. C# allows to use 'var' to declare and initial varialbe from a method/function call.
        //   3. C# compiler infers type parameters so type parameters don't need to be specified.
        //
        //   4. Therefore, all we need is a method which would take lamda as an argument
        //      and then return it as a result. This can then be assigned to a var using
        //      'var' keyword.
        //
        // NOTE: cannot pass methods as arguments :(
        //
        public static Func<TResult> function<TResult>(Func<TResult> f) { return f; }
        public static Func<T1, TResult> function<T1, TResult>(Func<T1, TResult> f) { return f; }
        public static Func<T1, T2, TResult> function<T1, T2, TResult>(Func<T1, T2, TResult> f) { return f; }
        public static Func<T1, T2, T3, TResult> function<T1, T2, T3, TResult>(Func<T1, T2, T3, TResult> f) { return f; }
        public static Func<T1, T2, T3, T4, TResult> function<T1, T2, T3, T4, TResult>(Func<T1, T2, T3, T4, TResult> f) { return f; }
        public static Func<T1, T2, T3, T4, T5, TResult> function<T1, T2, T3, T4, T5, TResult>(Func<T1, T2, T3, T4, T5, TResult> f) { return f; }
        public static Func<T1, T2, T3, T4, T5, T6, TResult> function<T1, T2, T3, T4, T5, T6, TResult>(Func<T1, T2, T3, T4, T5, T6, TResult> f) { return f; }
        public static Func<T1, T2, T3, T4, T5, T6, T7, TResult> function<T1, T2, T3, T4, T5, T6, T7, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, TResult> f) { return f; }
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> f) { return f; }
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> f) { return f; }

        // ReSharper restore InconsistentNaming
    }
}