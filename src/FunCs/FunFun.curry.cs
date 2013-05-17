////////////////////////////////////////////////////////////////////////////////
//
// Project Fun - championing functional style.
//
// Copyright (c) 2013 Philip Panyukov
//
// Portions are based on Prelude.cs, Copyright (c) 2011 Clark Gaebel
// https://gist.github.com/anonymous/1086817
// 
////////////////////////////////////////////////////////////////////////////////


namespace FunCs
{
    using System;

    // Partial function application (currying)
    public static partial class FunFun
    {
        // ReSharper disable InconsistentNaming

        # region Adopted from Prelude.cs, https://gist.github.com/anonymous/1086817

        // Changed these into extention methods but adding 'this' keyword to first param.

        /* Prelude.cs : What happens when a haskell programmer learns C#.
           Copyright (c) 2011 Clark Gaebel
 
           Permission is hereby granted, free of charge, to any person obtaining
           a copy of this software and associated documentation files (the "Software"),
           to deal in the Software without restriction, including without limitation
           the rights to use, copy, modify, merge, publish, distribute, sublicense,
           and/or sell copies of the Software, and to permit persons to whom the
           Software is furnished to do so, subject to the following conditions:
 
           The above copyright notice and this permission notice shall be included
           in all copies or substantial portions of the Software.
 
           THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
           IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
           FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
           AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
           WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN
           CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
        */
        public static Func<R> curry<I1, R>(this Func<I1, R> f, I1 v)
        {
            return () => f(v);
        }

        public static Func<I2, R> curry<I1, I2, R>(this Func<I1, I2, R> f, I1 v)
        {
            return (x1) => f(v, x1);
        }

        public static Func<I2, I3, R> curry<I1, I2, I3, R>(this Func<I1, I2, I3, R> f, I1 v)
        {
            return (x1, x2) => f(v, x1, x2);
        }

        public static Func<I2, I3, I4, R> curry<I1, I2, I3, I4, R>(this Func<I1, I2, I3, I4, R> f, I1 v)
        {
            return (x1, x2, x3) => f(v, x1, x2, x3);
        }

        public static Func<I2, I3, I4, I5, R> curry<I1, I2, I3, I4, I5, R>(this Func<I1, I2, I3, I4, I5, R> f, I1 v)
        {
            return (x1, x2, x3, x4) => f(v, x1, x2, x3, x4);
        }

        public static Func<I2, I3, I4, I5, I6, R> curry<I1, I2, I3, I4, I5, I6, R>(this Func<I1, I2, I3, I4, I5, I6, R> f, I1 v)
        {
            return (x1, x2, x3, x4, x5) => f(v, x1, x2, x3, x4, x5);
        }

        public static Func<I2, I3, I4, I5, I6, I7, R> curry<I1, I2, I3, I4, I5, I6, I7, R>(this Func<I1, I2, I3, I4, I5, I6, I7, R> f, I1 v)
        {
            return (x1, x2, x3, x4, x5, x6) => f(v, x1, x2, x3, x4, x5, x6);
        }

        public static Func<I2, I3, I4, I5, I6, I7, I8, R> curry<I1, I2, I3, I4, I5, I6, I7, I8, R>(this Func<I1, I2, I3, I4, I5, I6, I7, I8, R> f, I1 v)
        {
            return (x1, x2, x3, x4, x5, x6, x7) => f(v, x1, x2, x3, x4, x5, x6, x7);
        }

        public static Func<I2, I3, I4, I5, I6, I7, I8, I9, R> curry<I1, I2, I3, I4, I5, I6, I7, I8, I9, R>(this Func<I1, I2, I3, I4, I5, I6, I7, I8, I9, R> f, I1 v)
        {
            return (x1, x2, x3, x4, x5, x6, x7, x8) => f(v, x1, x2, x3, x4, x5, x6, x7, x8);
        }

        public static Func<I2, I3, I4, I5, I6, I7, I8, I9, I10, R> curry<I1, I2, I3, I4, I5, I6, I7, I8, I9, I10, R>(this Func<I1, I2, I3, I4, I5, I6, I7, I8, I9, I10, R> f, I1 v)
        {
            return (x1, x2, x3, x4, x5, x6, x7, x8, x9) => f(v, x1, x2, x3, x4, x5, x6, x7, x8, x9);
        }

        public static Func<I2, I3, I4, I5, I6, I7, I8, I9, I10, I11, R> curry<I1, I2, I3, I4, I5, I6, I7, I8, I9, I10, I11, R>(this Func<I1, I2, I3, I4, I5, I6, I7, I8, I9, I10, I11, R> f, I1 v)
        {
            return (x1, x2, x3, x4, x5, x6, x7, x8, x9, x10) => f(v, x1, x2, x3, x4, x5, x6, x7, x8, x9, x10);
        }

        public static Func<I2, I3, I4, I5, I6, I7, I8, I9, I10, I11, I12, R> curry<I1, I2, I3, I4, I5, I6, I7, I8, I9, I10, I11, I12, R>(this Func<I1, I2, I3, I4, I5, I6, I7, I8, I9, I10, I11, I12, R> f, I1 v)
        {
            return (x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11) => f(v, x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11);
        }

        public static Func<I2, I3, I4, I5, I6, I7, I8, I9, I10, I11, I12, I13, R> curry<I1, I2, I3, I4, I5, I6, I7, I8, I9, I10, I11, I12, I13, R>(this Func<I1, I2, I3, I4, I5, I6, I7, I8, I9, I10, I11, I12, I13, R> f, I1 v)
        {
            return (x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12) => f(v, x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12);
        }

        public static Func<I2, I3, I4, I5, I6, I7, I8, I9, I10, I11, I12, I13, I14, R> curry<I1, I2, I3, I4, I5, I6, I7, I8, I9, I10, I11, I12, I13, I14, R>(this Func<I1, I2, I3, I4, I5, I6, I7, I8, I9, I10, I11, I12, I13, I14, R> f, I1 v)
        {
            return (x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13) => f(v, x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13);
        }

        public static Func<I2, I3, I4, I5, I6, I7, I8, I9, I10, I11, I12, I13, I14, I15, R> curry<I1, I2, I3, I4, I5, I6, I7, I8, I9, I10, I11, I12, I13, I14, I15, R>(this Func<I1, I2, I3, I4, I5, I6, I7, I8, I9, I10, I11, I12, I13, I14, I15, R> f, I1 v)
        {
            return (x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14) => f(v, x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14);
        }

        public static Func<I2, I3, I4, I5, I6, I7, I8, I9, I10, I11, I12, I13, I14, I15, I16, R> curry<I1, I2, I3, I4, I5, I6, I7, I8, I9, I10, I11, I12, I13, I14, I15, I16, R>(this Func<I1, I2, I3, I4, I5, I6, I7, I8, I9, I10, I11, I12, I13, I14, I15, I16, R> f, I1 v)
        {
            return (x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14, x15) => f(v, x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14, x15);
        }

        #endregion

        // ReSharper restore InconsistentNaming
    }
}
