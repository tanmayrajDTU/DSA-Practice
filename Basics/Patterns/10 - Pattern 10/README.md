# Pattern 10

## 📌 Platform

TakeUForward (TUF)

## 🟢 Difficulty

Easy

## 🏷️ Tags

Patterns, Nested Loops, Triangles, Basics

---

## ❓ Question

Given an integer `n`, print the following star pattern:

For example, when `n = 5`, the output should be:

```text
*
**
***
****
*****
****
***
**
*
```

Print the pattern in the function provided.

---

## 💡 Approach

The pattern consists of **two right-angled triangles**:

1. An **increasing triangle** from `1` to `n` stars.
2. A **decreasing triangle** from `n - 1` to `1` stars.

### Upper Half

* Use an **outer loop** to iterate from `1` to `n`.
* For each row, print the current row number of asterisks.

### Lower Half

* Use another **outer loop** to iterate from `n - 1` down to `1`.
* For each row, print the current number of asterisks.

By combining these two triangles, the required pattern is formed.

---

## 📝 Examples

### Example 1

**Input**

```text
n = 4
```

**Output**

```text
*
**
***
****
***
**
*
```

**Explanation**

The pattern first increases from **1** to **4** asterisks and then decreases back to **1**, forming a symmetric triangle.

---

### Example 2

**Input**

```text
n = 2
```

**Output**

```text
*
**
*
```

**Explanation**

The first half prints one and two asterisks. The second half prints one asterisk, completing the pattern.

---

## ⏱️ Time Complexity

**O(n²)**

A total of `1 + 2 + ... + n + (n - 1) + ... + 1 = n²` characters are printed, resulting in **O(n²)** time complexity.

---

## 💾 Space Complexity

**O(1)**

Only a constant amount of extra space is used.

---

## 📚 Concepts Practiced

* Nested loops
* Pattern printing
* Increasing triangle
* Decreasing triangle
* Combining multiple patterns
* Output formatting
* Basic C# syntax

---

## ✅ Key Takeaway

This problem demonstrates how more complex patterns can be created by combining simpler ones. By printing an increasing triangle followed by a decreasing triangle, a vertically symmetric pattern is formed. This approach is commonly used in advanced pattern-printing problems and helps build a strong understanding of nested loops and loop boundaries.
