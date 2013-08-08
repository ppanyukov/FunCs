FunCs
========

Functional extensions and support for C#.

## What it's for

Very lightweight syntax functional support for C#, for things which either don't exist,
or a pain to use.

Currently included:

- Use `var` to declare lambdas;
- Functional composition;
- Partial function application (currying).


### Use 'var' to declare lambdas:

What is a less of a pain and makes more sense to you?
And what is easier to convert to a method should you want to?

	// Standard C#
	Func<int, string> f = (x) => x.ToString();

	// With FunCs
    var f = Fun.function((int x) => x.ToString());


Restrictions:

- Can only use inside a method: can't use var to declare instance members :(
- Up to 9 input parameters;
- It's a `Func`, so must have a return value, can't do `void.



### Function composition: create functions by chaining them together.
    
    var stringToInt = Fun.function((string s) => int.Parse(s));
    var intToHexString = Fun.function((int n) => n.ToString("X"));

    // compose
    var stringToHexString = Fun.compose(stringToInt, intToHexString);

    // or, using extension
    var stringToHexString = stringToInt.compose(intToHextString);

    // use it
    var s = stringToHexString("255");  // = "FF"


Restrictions:

- Can only use with `Func<>` types.
- Cannot use with methods :(  For a somewhat unconvincing answer *why*, see [Eric Lippert's post on SO](http://stackoverflow.com/a/4966409/190460).



### Partial function application (currying)

    var plus = Fun.function((int x1, int x2) => x1 + x2);
    var plus10 = plus.curry(10);    // or Fun.curry(plus, 10)
    var r1 = plus(2);               // = 10 + 2 = 12
    var r2 = plus(5);               // = 10 + 5 = 15

Restrictions:

- Same as with `compose`.


## Getting the stuff

This is a sort of a "beta" at the moment. More stuff will be added.

### .NET Version Support
Currently only 4.0 and 4.5.

If there is a demand for earlier versions (3.5, 3.0 and 2.0), add an issue
to this project.

### Nuget

There is a [nuget package for it here](https://www.nuget.org/packages/FunCs/).

### Binaries

There are pre-built binaries in `published` directory. Feel free to grab those.

### Source code

Feel free to use as a source code. It should be trivial to do so.

## License

MIT license. Feel free to use either as binary releases or as source code.

