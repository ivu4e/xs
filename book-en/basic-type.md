# Basic Type
We only need three simple basic types, we can do most of the work.

## Integer
Since our current computer architecture is better at calculating integers, a separate integer type helps to increase the efficiency of the program.

In this language, the default integer is the `i32` type, which is a 32-bit signed integer type data.

E.g:
```
integer := 3987349
```

If we need integers of other numeric ranges, other types can also be used. All supported integer types are shown in the following table.
```
i8      # 8-bit signed     -128 to 127
u8      # 8-bit unsigned   0 to 255
i16     # 16-bit signed    -32,768 to 32,767
u16     # 16-bit unsigned  0 to 65,535
i32     # 32-bit signed    -2,147,483,648 to 2,147,483,647
u32     # 32-bit unsigned  0 to 4,294,967,295
i64     # 64-bit signed    -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
u64     # 64-bit unsigned  0 to 18,446,744,073,709,551,615
```
## Basic Type Conversion
Since the default integer is `i32`, how do we use other types of integers?

We can use type conversion to change the number to the type we need, just use the `toType` method.

E.g:
```
integer8 := (16).toI8()
```

Note that, the basic type conversion function is only valid for the base type.

If you need all types of casts, use the `to<Type>` method, which crashes against incompatible types, so use it with caution.
## Float 
Integers do not meet our digital needs, and we often need to deal with decimals.

In this language, the default decimal is `f64`, which is a 64-bit double-precision floating-point data.

E.g:
```
float1 := 855.544
float2 := 0.3141592653
```
Note that due to the special nature of computer-calculated floating-point numbers, there are certain accuracy issues in floating-point number operations, so the sensitivity-sensitive requirements should consider special handling.

All supported floating-point types are as follows:
```
f32     # 32-bit   ±1.5e−45 to ±3.4e38
f64     # 64-bit   ±5.0e−324 to ±1.7e308
```
## Character
Computers usually use a specific number to encode characters, so a type is needed to express the characters. This is the `chr` type.

It can only be a single character, and it only represents the correspondence between a certain character and a number, so it is a character and a number.

You only need to wrap a character with `''`, it will be recognized as a character value.

E.g:
```
char := 'x'
char2 := '8'
```
### String
We are not living in a world of numbers alone, so we also need to use text to display the information we need. 

In this language, the default text is the `str` type, which is an unlimited-length character array data.

You only need to use `""` package a text content, it will be recognized as a string value.

E.g:
```
string := "Hello world!"
```

It should be noted that a string is a type consisting of multiple characters, so in fact the string is a fixed-order list, and there is a correspondence between the two. Many times we can process strings as if they were lists.
## String Template
Many times we need to insert other content into a string. How do we usually do it?

E.g:
```
title := "Year:"
content := 2018
string := "Hello world! " + title + content.toStr()
# Hello world! Year:2018
```

This of course does not affect the functionality, but we can use a more intuitive and convenient way, that is string templates.
We can insert elements directly in the middle of two strings, and the language will automatically merge into one string.

E.g:
```
string := "Hello world! " title " " content ""
# Hello world! Year:2018
```
## Boolean
boolean are logical values ​​because they can only be true or false. It is often used to assist in judging logic.

In this language, the default boolean is the type `bl`, which is a type that has only true and false values.

E.g:
```
boolean1 := true     # true  
boolean2 := false     # false  
```
## Object
In particular, sometimes you need a type that can be any object to assist in the completion of the function, so it is `obj`.

E.g:
```
a :obj = 1  # any type
```

## nil value
We will need a value that can be any nil value, so it is `nil`.

E.g:
```
nil # empty value
```

### [Next Chapter](operator.md)

## Example of this chapter
```
\Demo <- {
    System
}

example -> {
    Main() -> () {
        a := 123
        b := a.toI64()
        c := 123.456
        d := "hello"
        c := ""d" world"
        e := true
        f :obj = false
    }
}
```