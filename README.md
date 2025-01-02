# F# Mutable Variable Swap Bug

This repository demonstrates a common pitfall in F# when working with mutable variables: unexpected behavior when passing them to functions that modify them.  The `swap` function attempts to swap two variables' values, but due to pass-by-reference, it directly alters the original variables.

The `bug.fs` file shows the incorrect implementation, resulting in the variables being swapped as expected. However, the `bugSolution.fs` file showcases a corrected approach using tuples to avoid unintended side effects.

## How to reproduce

1.  Clone this repository.
2.  Open `bug.fs` in an F# editor (e.g., Visual Studio, Ionide).
3.  Compile and run the code. Observe the output.
4.  Open `bugSolution.fs`. Compile and run this version. Observe the improved output.

## Solution

The solution involves avoiding direct modification of mutable variables passed as arguments. Instead, use tuples or return the swapped values.