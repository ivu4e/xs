# Basic Grammar
## Basic Statement
In this language, any expression must be attributed to the statement.

The basic form of the statement is:
```
StatementContent;
```
In this language, the grammar rules are clear, and each statement has a clear scope and must be terminated by `;` or `newline`.  
So in most cases, we can end up using line breaks directly. When there is a special need, you can choose to use `;` to maintain the current line.

So we prefer to write like this:
```
StatementContent # auto end
StatementContent
```

## Export Namespace
All content in this language can only be defined in the namespace so that content can be efficiently divided into distinct blocks for management. You can define it freely in a separate namespace without undue restrictions on naming.

We can use the `\id <- {}` statement to define the namespace of the current file.

E.g:
```
\Demo <- {}
```
The meaning of this statement is to mark the content tag in the current code file as `Demo`, so that the content naming inside is limited to the area, and it is not necessary to consider naming conflicts with the outside of the area.

At the same time the external area can import `Demo` to use the contents of which, we will then understand how to import.
## Import Namespace
We can use the `id` statement in the `{}` of the export statement to import other namespaces, libraries, and frameworks into a namespace.

E.g:
```
\Demo <- {
    System
    Library
}
```
This imports the `System` libraries into the `Demo` namespace, and then you can use them in the program.

You can write multiple import statements that their order does not affect the import function.

For more details on namespaces, please see [Namespace](namespace.md)

## Main Entry
We need to define a main entry to let the program know where to start. The main entry is declared with a function `Main() -> () {}` and must be package mount property.  
Depending on the target platform, the main entry may be declared differently, and the main function of C# is used here by default.

E.g:
```
\Demo <- {
    System
}

example -> {
    Main() -> () {
    }
}
```
The main entry function here is defined of the `example` and is a function with no arguments and no return value. It is automatically recognized as the main entry and the main entry function is executed when the program is started, so we simply write the function main entry function can be.

In the examples that follow, we are by default implemented in the main entry function, so we will not overplay this part of the code.

In particular, there can be only one main entry function in a namespace because the entry must be unique.

More details about the function will be explained in later chapters.

## Display information
We use the program in order to obtain some useful information, so we need a feature to browse information, this feature can be display, print or output.

If we write a console program, we can use `prt()` function, it can display data or text information to the console for us to browse.

E.g:
```
prt("Hello world")    # output Hello world
```
In the following examples, we will all use the console as a presentation environment.
## Comment
Single-line comment starting with `#`:
```
# single-line comment
```
Comment is only used to provide additional information to the user, and will not be really compiled into the executable program.

Multi-line comments only need to wrap the content with `##`:
```
##
Multi-line 
comment
##
```
## Definition
We can create new variable using the `id:type` statement.

E.g:
```
a: i32
```
This will create an identifier for the name on the left and define it as the type on the right, in which case the identifier is a nil value.

Once an identifier is created, its data type will not be changed in the valid area.

## Assignment
Like a normal programming language, we need to use the `id = value` statement to assign the data on the right to the identifier on the left.

E.g:
```
a = 2
```
But the definition is not the same, the left side of the assignment can only be an identifier that has been defined, otherwise the assignment statement does not hold.
## Automatic derivation
In most cases, you can use the simpler automatic derivation syntax `id := value`, we don't need to explicitly specify the type of data, the compiler will automatically infer the type for the data.

E.g:
```
b := 10
```

This defines the new variable `b`, which is equal to `10` and is automatically derived as an `i32` type.

If we don't want automatic derivation, we can also use the write statement definition to mark the type we need.

E.g:
```
b: i16 = 10
```
## Mutable Data
We can easily define mutable data, and identifiers that start with `$` are all mutable data.

E.g:
```
$i := 1          # can be changed
$j: i32 = 1      # do not use automatic derivation
```

## Immutable Data
We can also define immutable data, which is immutable after assignment, and all the markers that not start with `$` are immutable data.

E.g:
```
i := 2         # cannot be changed
j: i32 = 3     # do not use automatic derivation
```

## Constant
Constants are languages that are determined at compile time and are unchangeable. Only a special type of the underlying type is supported. Use `id:type value` to define it, and `:type` can usually be omitted.  

E.g:
```
i 2         # automatic derivation
j:i32 3     # do not use automatic derivation
```

## Identifier
Identifier is the variable, function, package, protocol, etc. specified name. The letters that make up the identifier all have a certain norm, and the naming convention of the identifier in this language is as follows:

1. Case sensitive, Myname and myname are two different identifiers;
1. The first character of an identifier can start with an underscore `_` or a letter, but it can not be a number;
1. Other characters in the identifier can be underlined `_`, letters, or numbers.
1. Within the same `{}`, you can not define more than two identifiers of the same name.
1. In different `{}`, you can define the identifier of the duplicate name, the language will give priority to the identifier defined in the current range.

In particular, in namespace, packages and protocols, properties and method names that begin with the underscore `_` are considered private and the rest are considered public.
## Keyword
none.

Yes, you are not mistaken, we do not have keywords. So you can use any character as your identifier, regardless of conflict issues.
## Space
By default, spaces are ignored by the compiler.

However, in practical projects, the use of partition will effectively improve the reading effect of the code, so we strongly recommend that you use the partition reasonably to improve the source code expression.

E.g:
```
a.b(x,y).c(()->(i32){<-(2+1)}).D=1+3*5/4

a.b(x, y).c( () -> (i32) {
    <- (2 + 1)
}).D = 1 + 3 * 5 / 4
```
### [Next Chapter](basic-type.md)

## Example of this chapter
```
\Demo <- {
    System
}

example -> {
    Main() -> () {
        a : i32
        a = 5
        b := 6
        c: i8 = 1
    }
}
```