# Pattern 5

## 📌 Platform

TakeUForward (TUF)

## 🟢 Difficulty

Easy

## 🏷️ Tags

Patterns, Nested Loops, Basics

---

## ❓ Question

Given an integer `n`, print an inverted right-angled triangle pattern of `*` (asterisks).

For example, when `n = 5`, the output should be:

```text
*****
****
***
**
*
```

Print the pattern in the function provided.

---

## 💡 Approach

The pattern consists of:

* `n` rows.
* The first row contains `n` asterisks.
* Each subsequent row contains one fewer asterisk than the previous row.
* The last row contains a single asterisk.

To generate the pattern:

1. Use an **outer loop** to iterate from `n` down to `1`.
2. For each row, use an **inner loop** to print the current number of asterisks.
3. After printing each row, move to the next line.

The number of asterisks decreases by **one** with every new row.

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
***
**
*
```

**Explanation**

The pattern starts with **4** asterisks in the first row. Each subsequent row contains one fewer asterisk until only one remains.

---

### Example 2

**Input**

```text
n = 2
```

**Output**

```text
**
*
```

**Explanation**

The first row contains **2** asterisks, and the second row contains **1** asterisk.

---

## ⏱️ Time Complexity

**O(n²)**

A total of `n + (n - 1) + ... + 1 = n(n + 1) / 2` asterisks are printed, resulting in **O(n²)** time complexity.

---

## 💾 Space Complexity

**O(1)**

Only a constant amount of extra space is used.

---

## 📚 Concepts Practiced

* Nested loops
* Pattern printing
* Reverse iteration
* Output formatting
* Basic C# syntax

---

## ✅ Key Takeaway

This problem demonstrates how nested loops can be used to generate decreasing patterns. Unlike the previous increasing triangle patterns, the outer loop iterates in reverse, making it a good introduction to reverse iteration and inverted pattern generation.
