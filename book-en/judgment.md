# Judgment
The judgment statement executes the program by setting one or more conditions, executes the specified statement if the condition is true, and executes the otherwise specified statement if the condition is false.

We only need to use the `? value {}` to declare the judgment statement, according to the following value into the corresponding area.

E.g:
```
? true {
    prt("true")  # true
}
```
# Boolean Judgment
When the judgment value is only `bl`, the statement is executed only if it is `true`. 
If we need to deal with other situations at the same time, we can continue to declare another processing statement after using `value {}`.
If you only need `false`, use `_ {}` to declare it.

E.g:
```
b := false
? b {
    todo("...") # since b is false, it will never enter this branch
} _ {
    todo("...") # handle false
}
```

We can also insert more judgments in the middle, and the language will automatically implement them as continuous processing.

E.g:
```
i := 3
? i == 0 {
    todo("...")
} i == 1 {
    todo("...")
} i == 2 {
    todo("...")
}
```

This can be considered as an `if elseif else` structure relative to other languages.
# Condition Judgment
If we need to judge an identifier, we can use the `? value -> case {}` statement, the statement implements multiple conditional matching, and the matching condition is used to execute the corresponding logic, so that it will only execute the statement with successful matching.

E.g:
```
? i -> 1 {
    todo("...")
} 2 {
    todo("...")
}
```
This kind of condition judgment is very suitable for the multi-condition judgment of a certain identifier, and avoids writing too many judgment conditions.

Yes, just as the Boolean Judgment above, every condition here will be terminated when it is done and will not continue to execute.

### Default Condition
What if you need a default condition to execute logic? We can use an anonymous identifier `_` to accomplish this goal.

E.g:
```
? i -> 1 {
    todo("...")
} 2 {
    todo("...")
} _ {
    todo("...")
}
```
In this case can not match, it will go to the default processing area to execute.

This can be thought of as the `switch case default` structure relative to other languages.

### Pattern Matching
Conditional judgment can do more, for example, we need to judge the type of the identifier,
You can use the `? value -> id:type{}` syntax to match types, `id` can be omitted.

E.g:
```
? x -> :i32 {       # When i32
     prt("i32")
} content:str {     # when str
     prt(content)
} nil {             # When it is nil
     prt("nil")
}
```
### Get type
If we need to explicitly get the type value, we can use the `?(id)` or `?(:type)` syntax to get it.

E.g:
```
?(expr)    # Get the expression type value
?(:type)   # Get the type value directly by type
```
### [Next Chapter](loop.md)

## Example of this chapter
```
\Demo <- {
    System
}

example -> {
    Main() -> () {
        a := 5
        ? a == 2 { 
            prt(2) 
        } a == 4 { 
            prt(4) 
        } _ { 
            prt("not find") 
        }

        b := 7
        ? b -> 5 { 
            prt(5) 
        } 7 { 
            prt(7) 
        } _ { 
            prt("not find") 
        }

        prt( ?(b) )
        prt( ?(:i32) )
    }
}
```