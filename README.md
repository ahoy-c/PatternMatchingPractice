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

##How it works

GetRandomArray(int length) generates a random array of objects.

ObjectClassifier(object[] array) analyzes each element's type and value, returning a description.

Uses pattern matching (switch expressions) to inspect types, ranges, and properties.
