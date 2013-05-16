////////////////////////////////////////////////////////////////////////////////
//
// Project Fun - championing functional style.
//
// Copyright (c) 2013 Philip Panyukov
// 
////////////////////////////////////////////////////////////////////////////////


namespace Fun.Csex
{
    // This is an umbrella file, see other partial files.

    /// <summary>
    /// Functional programming syntax support for C#, for things
    /// which either don't exist in C#, or a pain.
    /// </summary>
    /// 
    /// <remarks>
    /// Includes:
    /// 
    /// - use 'var' to declare lambas:
    /// 
    ///     var f = function((int x) => x.ToString());
    /// 
    /// 
    /// - function composition: create functions by chaining them together.
    ///     
    ///     var stringToInt = function((string s) => int.Parse(s));
    ///     var intToHexString = function((int n) => n.ToString("X"));
    /// 
    ///     // compose
    ///     var stringToHexString = compose(stringToInt, intToHexString);
    /// 
    ///     // or, using extension
    ///     var stringToHexString = stringToInt.compose(intToHextString);
    /// 
    ///     // use it
    ///     var s = stringToHexString("255");  // = "FF"
    /// 
    /// 
    /// - partial function application (currying)
    /// 
    ///     var plus = function((int x1, int x2) => x1 + x2);
    ///     var plus10 = plus.curry(10);    // or curry(plus, 10)
    ///     var r1 = plus(2);               // = 10 + 2 = 12
    ///     var r2 = plus(5);               // = 10 + 5 = 15
    /// </remarks>
    public static partial class FunFun
    {
    }
}