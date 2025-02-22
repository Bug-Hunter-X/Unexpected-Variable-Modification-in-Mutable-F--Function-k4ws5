# Unexpected Variable Modification in Mutable F# Function

This repository demonstrates a subtle bug in F# code involving mutable variables and the order of operations within a function. The `add` function unexpectedly modifies its input variables, leading to incorrect results.  The solution illustrates how to avoid this issue by using immutable values or carefully managing side effects.

## Bug Description
The `add` function is intended to add two numbers. However, due to the way mutable variables are updated within the function and its return statement, both x and y are modified in unexpected ways, resulting in an incorrect sum.

## Solution
The solution demonstrates two approaches to fix the issue:  using immutable values to avoid side effects, and managing mutable variables more carefully with a more explicit assignment.