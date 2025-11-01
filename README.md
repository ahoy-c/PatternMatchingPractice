# PatternMatchingPractice

This project is a small console application that demonstrates the use of **pattern matching** and **switch expressions** with various object types.

## Features

- Generates a random array of objects, which can include:
  - `int` (random integers)
  - `string` (random strings)
  - `Point` (from `System.Drawing`)
  - `null`
- Classifies each object in the array and prints a description using `switch` and **pattern matching**.
- Demonstrates property patterns, relational patterns, and type patterns in C#.

## How it works

GetRandomArray(int length) generates a random array of objects.

ObjectClassifier(object[] array) analyzes each element's type and value, returning a description.

Uses pattern matching (switch expressions) to inspect types, ranges, and properties.

## Example Output
5 is a small number<br>
-3 is a negative number<br>
Hi is a short string<br>
Hello world is a long string<br>
{X=1,Y=2} is a point in the first quadrant<br>
{X=-1,Y=-2} is a point in the third quadrant<br>
is a null
