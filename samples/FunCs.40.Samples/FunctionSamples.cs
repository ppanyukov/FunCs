namespace FunCs.Samples
{
    using System;
    using NUnit.Framework;

    /// <summary>
    /// Samples for FunFun.function().
    /// 
    /// Problem:
    /// 
    ///     I want to use 'var' keyword with lamdas, e.g.
    /// 
    ///         var f = (int x) => x * 2;
    /// 
    ///     But I get C# compiler error:
    /// 
    ///         error CS0815: Cannot assign lambda expression to an implicitly-typed local variable
    /// 
    /// Solution:
    /// 
    ///     Use function() methods.
    /// 
    ///         var f = function((int x) => x * 2);
    /// </summary>
    [TestFixture]
    public partial class FunctionSamples
    {
        [Test]
        public void VeryBasicUsage()
        {
            // The following does not compile:
            //
            // error CS0815: Cannot assign lambda expression to an implicitly-typed local variable
            // var f = (x) => x*2;
            // var f = (int x) => x*2;


            // But this does:
            var square = z.function((int x) => x * x);


            // The above is equivalent of writing.
            Func<int, int> square2 = (x) => x * x;


            // The 'var' syntax is arguably more natural cleaner and makes more sense.
            // There are ways to make it even more concise.


            // Use just like normal function:
            var x1 = square(3);
            var x2 = square(15);
            Console.WriteLine("square(3)={0}; square(15)={1}", x1, x2);
        }



        [Test]
        public void TheTypeOfLambda()
        {
            // The type of the 'var' is Func<TResult>, or Func<T1, TResult> etc
            // depending on the number of the arguments.

            var fWithZeroArgs = z.function(() => 10);
            var fWithOneArgs = z.function((int x1) => x1);
            var fWithTwoArgs = z.function((int x1, int x2) => x1*x2);

            Console.WriteLine("Type of FunFun.function(() => 10): {0}", fWithZeroArgs.GetType().Name);
            Console.WriteLine("Type of FunFun.function((int x1) => x1): {0}", fWithOneArgs.GetType().Name);
            Console.WriteLine("Type of FunFun.function((int x1, int x2) => x1*x2): {0}", fWithTwoArgs.GetType().Name);
        }


    }
}
