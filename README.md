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


### Use 'var' to declare lambas:

    var f = function((int x) => x.ToString());


### function composition: create functions by chaining them together.
    
    var stringToInt = function((string s) => int.Parse(s));
    var intToHexString = function((int n) => n.ToString("X"));

    // compose
    var stringToHexString = compose(stringToInt, intToHexString);

    // or, using extension
    var stringToHexString = stringToInt.compose(intToHextString);

    // use it
    var s = stringToHexString("255");  // = "FF"


### Partial function application (currying)

    var plus = function((int x1, int x2) => x1 + x2);
    var plus10 = plus.curry(10);    // or curry(plus, 10)
    var r1 = plus(2);               // = 10 + 2 = 12
    var r2 = plus(5);               // = 10 + 5 = 15


## Getting the stuff

This is a sort of a "beta" at the moment. More stuff will be addded.

### .NET Version Support
Currently only 4.0 and 4.5.

If there is a demand for earlier versions (3.5, 3.0 and 2.0), add an issue
to this project.

### Nuget

There is a nuget package for it here: [https://www.nuget.org/packages/FunCs/].

### Binaries

There are pre-built binaries in `published` directory. Feel free to grab those.

### Source code

Feel free to use as a source code. It should be trivial to do so.

## License

MIT license. Feel free to use either as binary releases or as source code.

## 