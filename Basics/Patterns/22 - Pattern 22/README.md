# Pattern 22

## 📌 Platform

TakeUForward (TUF)

## 🟡 Difficulty

Medium

## 🏷️ Tags

Patterns, Nested Loops, Matrix Patterns, Concentric Patterns

---

## ❓ Question

Given an integer `n`, print the following concentric number pattern.

For example, when `n = 5`, the output should be:

```text
5 5 5 5 5 5 5 5 5
5 4 4 4 4 4 4 4 5
5 4 3 3 3 3 3 4 5
5 4 3 2 2 2 3 4 5
5 4 3 2 1 2 3 4 5
5 4 3 2 2 2 3 4 5
5 4 3 3 3 3 3 4 5
5 4 4 4 4 4 4 4 5
5 5 5 5 5 5 5 5 5
```

Print the pattern in the function provided.

---

## 💡 Approach

The pattern forms a **square matrix** of size **`(2 × n - 1) × (2 × n - 1)`**.

Each cell's value depends on its **minimum distance from any of the four boundaries**.

### Steps

1. Determine the size of the matrix:

   * `size = 2 × n - 1`

2. Iterate through every cell using two nested loops.

3. For each cell `(row, col)`, calculate its minimum distance from the four edges:

   * Top → `row`
   * Left → `col`
   * Bottom → `size - 1 - row`
   * Right → `size - 1 - col`

4. Find the minimum of these four distances.

5. The value to print is:

```text
n - minimumDistance
```

This creates concentric square layers where the outermost layer contains `n`, and each inner layer decreases by `1` until the center reaches `1`.

---

## 📝 Examples

### Example 1

**Input**

```text
n = 4
```

**Output**

```text
4 4 4 4 4 4 4
4 3 3 3 3 3 4
4 3 2 2 2 3 4
4 3 2 1 2 3 4
4 3 2 2 2 3 4
4 3 3 3 3 3 4
4 4 4 4 4 4 4
```

**Explanation**

The outermost layer contains `4`. Each inner layer decreases by one until the center element becomes `1`.

---

### Example 2

**Input**

```text
n = 2
```

**Output**

```text
2 2 2
2 1 2
2 2 2
```

**Explanation**

The outer border contains `2`, while the center contains `1`, forming two concentric layers.

---

## ⏱️ Time Complexity

**O(n²)**

The algorithm visits every cell in a matrix of size `(2n - 1) × (2n - 1)`, which results in approximately `4n²` operations. Ignoring constants, the time complexity is **O(n²)**.

---

## 💾 Space Complexity

**O(1)**

The pattern is printed directly without using any additional data structures.

---

## 📚 Concepts Practiced

* Nested loops
* Matrix traversal
* Concentric patterns
* Boundary distance calculation
* Mathematical reasoning
* Output formatting
* Basic C# syntax

---

## ✅ Key Takeaway

This is one of the most important pattern-printing problems because it relies on **mathematical observation** rather than simply counting rows and columns. The key insight is that every cell belongs to a concentric square layer, which can be determined by its **minimum distance from the four boundaries**. Understanding this technique builds strong problem-solving skills for matrix traversal, geometry-based patterns, and coordinate-based algorithms.
