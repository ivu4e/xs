# Loop
Sometimes, we may need to execute the same code multiple times.

Under normal circumstances, the statement is executed in order, the first statement in the function first, followed by the second statement, and so on.
## Collection Loop
If we happen to have a collection that can be an array, a dictionary, or a piece of text, then we can use the `@ id <- value {}` statement to iterate over the collection, taking each element out of `id`.

E.g:
```
arr := {1, 2, 3, 4, 5}
@ item <- arr {
    prt(item)     # print each number
}
```

If we need to fetch the index and value at the same time, we can replace `id` with the `[index]value` syntax, which is valid for both the list and the dictionary.

E.g:
```
@ [i]v <- arr  {
    prt(""i":"v"")
}
```

This can be thought of as a `foreach` structure relative to other languages.
## Iterator Loop
There are times when we do not necessarily have a collection, but we just need to take numbers like `0` to `100`. We have an iterator syntax to accomplish such a task.

Iterators can loop from the start point to the end point, we use the collection expression, using the `<=` symbol between the two numbers.

E.g:
```
@ i <- [0 <= 100] {
    prt(i)      # print each number
}
```
It should be noted that the meaning of `0 <= 100` is read from` 0` to `100` one by one, that is, a total execution of` 101` times. Iterator will be executed until the last number is completed, rather than an early end.

So if we need to do it a hundred times, we can use `0 < 99` or` 1 <= 100-1`, remembering this difference.

By default, iterators add `1` to each interval. If we need to take every other number, we can add a step-by-step condition, just insert `,` and a number behind the start point and the end point.

E.g:
```
@ i <- [0 <= 100, 2] {
    todo("...")
}
```
So every interval is not `1` but `2`, empathy we can set other numbers.

We can also reverse it in reverse order, as long as we use `>=`.

E.g:
```
@ i <- [100 >= 0] {
     todo("...")    # from 100 to 0
}
```
For the same reason, if you don't want to reach the last one, you can use `100 > 0`.

This can be considered as a `for` structure relative to other languages.
## Infinite Loop
At other times, we may need an infinite loop. Very easy, we only need to use the `@ {};` statement..

E.g:
```
@ {
    todo("...") # never jump out
}
```
This can be thought of as a while while for other languages.
## Jump Out
So how to jump out of infinite loop? We can use the `<- @` statement to jump out.

E.g:
```
@ {
    <- @  # jump out
}
```
In addition to the infinite loop, jump out can also be used in other cycles.

Note that if you jump out of a multi-nested loop, it will only jump out the loop closest to it.
## Conditional Loop
What if we need a loop that just judges a certain condition?
Add a condition `?` to it.

E.g:
```
I := 0
@ ? I < 6 {
     I += 1
}
```
## Continue
If you only need to jump out of the current loop, use the `-> @` statement.

### [Next Chapter](function-type.md)

## Example of this chapter
```
\Demo <- {
    System
}

example -> {
    Main() -> () {
        arr := {1,2,3,4,5}
        @ i <- arr {
            prt(i)
        }

        @ i <- [1 <= 50] {
            prt(i)
        }

        @ [i]v <- [100 >= 0, 2] {
            prt(i, v)
        }

        $x := 0
        @ ? x <= 10 {
            x += 1
        }
    }
}
```