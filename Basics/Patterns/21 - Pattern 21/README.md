# Pattern 21

## 📌 Platform

TakeUForward (TUF)

## 🟡 Difficulty

Medium

## 🏷️ Tags

Patterns, Nested Loops, Hollow Patterns, Basics

---

## ❓ Question

Given an integer `n`, print a hollow square pattern of `*` (asterisks).

For example, when `n = 5`, the output should be:

```text
*****
*   *
*   *
*   *
*****
```

Print the pattern in the function provided.

---

## 💡 Approach

The pattern consists of an `n × n` square where:

* The **first row** and **last row** are completely filled with asterisks.
* The **first column** and **last column** are completely filled with asterisks.
* All remaining positions inside the square are filled with spaces.

To generate the pattern:

1. Use an **outer loop** to iterate through each row.
2. Use an **inner loop** to iterate through each column.
3. For each position:

   * Print `*` if it lies on the border:

     * First row
     * Last row
     * First column
     * Last column
   * Otherwise, print a space.
4. Move to the next line after completing each row.

This problem is solved by checking whether the current cell belongs to the boundary of the square.

---

## 📝 Examples

### Example 1

**Input**

```text
n = 4
```

**Output**

```text
****
*  *
*  *
****
```

**Explanation**

The border of the `4 × 4` square is filled with asterisks, while the inner cells are left empty.

---

### Example 2

**Input**

```text
n = 2
```

**Output**

```text
**
**
```

**Explanation**

Since every position belongs to the border in a `2 × 2` square, all cells contain asterisks.

---

## ⏱️ Time Complexity

**O(n²)**

The algorithm visits every cell in the `n × n` grid exactly once.

---

## 💾 Space Complexity

**O(1)**

Only a constant amount of extra space is used.

---

## 📚 Concepts Practiced

* Nested loops
* Hollow patterns
* Boundary conditions
* Matrix traversal
* Conditional statements
* Output formatting
* Basic C# syntax

---

## ✅ Key Takeaway

This problem introduces **hollow patterns**, where the decision to print a character depends on whether the current position lies on the boundary. Recognizing and checking border conditions (`first row`, `last row`, `first column`, and `last column`) is a common technique used in pattern printing, matrix problems, and grid-based algorithms.
